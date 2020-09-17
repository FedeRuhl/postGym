using Gimnasio.Datos;
using Gimnasio.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class SubirEntrenamiento : Form
    {
        private TextBoxPersonalizado textRepOSeg;
        private TextBoxPersonalizado textPeso;
        private int posicionY = 0;
        private bool textBoxIzquierda = false;
        public SubirEntrenamiento()
        {
            InitializeComponent();
        }

        private void SubirEntrenamiento_Load(object sender, EventArgs e)
        {
            actualizarComboBoxPersonas();

            dtpDiaEntrenamiento.Value = DateTime.Now;
            dtpDiaEntrenamiento.MaxDate = DateTime.Now;
        }

        private void cbRepOseg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validarCantidadSeriesRepSeg())
            {
                int cantidadSeries = Convert.ToInt32(tbCantidadSeries.Text);
                String textPlaceHolder = cbRepOseg.SelectedItem.ToString() == "Repeticiones" ? "Cantidad de repeticiones" : "Cantidad de segundos";

                for (int i = 0; i < cantidadSeries; i++)
                {
                    string nombreTextBox = "textRepOSeg";
                    textRepOSeg = inicializarTextBox(textPlaceHolder, nombreTextBox, i);

                    nombreTextBox = "textPeso";
                    textPeso = inicializarTextBox("Cantidad de peso (kg.)", nombreTextBox, i);

                    panelSubirRutina.Controls.Add(textRepOSeg);
                    panelSubirRutina.Controls.Add(textPeso);
                    posicionY += 25;
                }

                posicionarBotones();
                cbRepOseg.Enabled = false;
            }
            else if (cbRepOseg.SelectedIndex == -1)
                return;
            else
            {
                MessageBox.Show("¡No te olvides que la cantidad de series realizadas debe ser un número!");
                tbCantidadSeries.Clear();
                tbCantidadSeries.Focus();
            }
        }

        private void limpiarForm()
        {
            tbCantidadSeries.Clear();
            cbRepOseg.SelectedIndex = -1;
            panelSubirRutina.Controls.Clear();
            cbRepOseg.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void posicionarBotones()
        {
            panelSubirRutina.Controls.Add(panelBotones);
            btnGuardar.Visible = true;
            btnLimpiar.Visible = true;
        }

        private bool validarCantidadSeriesRepSeg()
        {
            if (int.TryParse(tbCantidadSeries.Text, out _)
                && !String.IsNullOrEmpty(cbRepOseg.SelectedItem.ToString()))
                return true;
            else
                return false;
        }

        private TextBoxPersonalizado inicializarTextBox(String placeHolder, String nombre, int Indice)
        {
            TextBoxPersonalizado txt = new TextBoxPersonalizado()
            {
                Name = nombre + Indice,
                BackColor = Color.FromArgb(23, 21, 32),
                ForeColor = Color.White,
                Width = 150,
                Text = placeHolder,
                TextAlign = HorizontalAlignment.Center,
                Anchor = (AnchorStyles.Left | AnchorStyles.Right),
                Location = new Point(0, posicionY)
            };

            if (!textBoxIzquierda)
            {
                txt.Anchor = AnchorStyles.Left;
                textBoxIzquierda = true;
            }
            else
            {
                txt.Anchor = AnchorStyles.Right;
                textBoxIzquierda = false;
            }
                
            return txt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarComboBox.opcionValida(cbPersonas, cbPersonas.Text)
                && ValidarComboBox.opcionValida(cbEjercicios, cbEjercicios.Text))
            {
                #region Inicializacion variables
                int tope = Convert.ToInt32(tbCantidadSeries.Text);
                int[] arregloRepSeg = generarArreglo<int>("textRepOSeg", tope);
                double[] arregloPesos = generarArreglo<double>("textPeso", tope);
                String fecha = Fecha.convertirFormatoUniversal(dtpDiaEntrenamiento.Value);
                DataRowView Persona = (DataRowView)cbPersonas.Items[cbPersonas.SelectedIndex];
                int personaID = Convert.ToInt32(Persona.Row["id"]);
                DataRowView Ejercicio = (DataRowView)cbEjercicios.Items[cbEjercicios.SelectedIndex];
                int ejercicioID = Convert.ToInt32(Ejercicio.Row["id"]);
                #endregion

                if (arregloPesos != null
                    && arregloRepSeg != null
                    && ValidarComboBox.opcionValida(cbRepOseg, cbRepOseg.Text))
                {
                    int setID = Sets.obtenerSet(fecha, personaID);
                    if (setID == 0)
                        setID = Sets.insertarSet(fecha, personaID);
                    for (int i = 0; i < tope; i++)
                    {
                        if (cbRepOseg.SelectedItem.ToString() == "Repeticiones")
                            Series.insertarSerieRepeticiones(setID, ejercicioID, arregloRepSeg[i], arregloPesos[i]);
                        else
                            Series.insertarSerieSegundos(setID, ejercicioID, arregloRepSeg[i], arregloPesos[i]);
                    }

                    MessageBox.Show("¡La serie se ha insertado correctamente!");
                    limpiarForm();
                }
            }
            else
                MessageBox.Show("Recordá que las personas y los ejercicios deben ser ingresados correctamente");
        }

        private type[] generarArreglo<type>(String nombreTexto, int tope)
        {
            type[] arregloDinamico = new type[tope];

            for (int i = 0; i < tope; i++)
            {
                string textBox = nombreTexto + i;
                Control[] controles = Controls.Find(textBox, true);
                if (controles.Length > 0)
                {
                    string cadena = controles.First().Text;
                    cadena = cadena.Replace(",", ".");

                    if (double.TryParse(cadena, out double valor) && controles.Count() != 0)
                    {
                        object objeto = Convert.ChangeType(valor, typeof(type));
                        arregloDinamico[i] = (type) objeto;
                    }
                        
                    else
                    {
                        MessageBox.Show("¡No te olvides que las series, las repeticiones y los pesos deben ser números!");
                        return null;
                    }
                }
            }
            return arregloDinamico;
        }

        private void dtpDiaEntrenamiento_ValueChanged(object sender, EventArgs e)
        {
            int diaSemana = Convert.ToInt32(dtpDiaEntrenamiento.Value.DayOfWeek);
            diaSemana = (diaSemana == 0) ? 7 : diaSemana;

            actualizarComboBoxEjercicios(diaSemana);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbEjercicios.DataSource = Ejercicios.obtenerEjercicios().Tables[0];
            cbEjercicios.DisplayMember = "Nombre";
            cbEjercicios.ValueMember = "Nombre";
        }

        private void SubirEntrenamiento_Enter(object sender, EventArgs e)
        {
            int diaSemana = Convert.ToInt32(dtpDiaEntrenamiento.Value.DayOfWeek);
            diaSemana = (diaSemana == 0) ? 7 : diaSemana;

            actualizarComboBoxPersonas();
            actualizarComboBoxEjercicios(diaSemana);
        }

        private void actualizarComboBoxPersonas()
        {
            cbPersonas.DataSource = Personas.obtenerPersonas().Tables[0];
            cbPersonas.DisplayMember = "nombre";
            cbPersonas.ValueMember = "nombre";
            //cbPersonas.SelectedIndex = 0;
        }

        private void actualizarComboBoxEjercicios(int diaSemana)
        {
            cbEjercicios.DataSource = Ejercicios.obtenerEjerciciosSegunDia(diaSemana).Tables[0];
            cbEjercicios.DisplayMember = "Ejercicio";
            cbEjercicios.ValueMember = "Ejercicio";
            //cbEjercicios.SelectedIndex = 0;
        }
    }
}