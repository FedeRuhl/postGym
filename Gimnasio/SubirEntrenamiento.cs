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
            string consulta = string.Format("select * from personas");
            DataSet ds = BD.Consultar(consulta);
            cbPersonas.DataSource = ds.Tables[0];
            cbPersonas.DisplayMember = "nombre";
            cbPersonas.ValueMember = "nombre";
            cbPersonas.SelectedIndex = 0;

            consulta = string.Format("select * from ejercicios");
            ds = BD.Consultar(consulta);
            cbEjercicios.DataSource = ds.Tables[0];
            cbEjercicios.DisplayMember = "nombre";
            cbEjercicios.ValueMember = "nombre";
            cbEjercicios.SelectedIndex = 0;

        }

        private void cbRepOseg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validarCantidadSeriesRepSeg())
            {
                String nombreTextBox = "";
                int cantidadSeries = Convert.ToInt32(tbCantidadSeries.Text);
                String textPlaceHolder = cbRepOseg.SelectedItem.ToString() == "Repeticiones" ? "Cantidad de repeticiones" : "Cantidad de segundos";

                for (int i = 0; i < cantidadSeries; i++)
                {
                    nombreTextBox = "textRepOSeg";
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
            #region Inicializacion variables
            int tope = Convert.ToInt32(tbCantidadSeries.Text);
            int[] arregloRepSeg = generarArregloEntero("textRepOSeg", tope);
            float[] arregloPesos = generarArregloFlotante("textPeso", tope);
            String fecha = Fecha.convertirFormatoUniversal(dtpDiaEntrenamiento.Value);
            DataRowView Persona = (DataRowView) cbPersonas.Items[cbPersonas.SelectedIndex];
            int personaID = Convert.ToInt32(Persona.Row["id"]);
            DataRowView Ejercicio = (DataRowView)cbEjercicios.Items[cbEjercicios.SelectedIndex];
            int ejercicioID = Convert.ToInt32(Ejercicio.Row["id"]);
            #endregion

            if (arregloPesos != null && arregloRepSeg != null)
            {
                BD.insertarSet(fecha, personaID);
                int setID = Convert.ToInt32(BD.ObtenerPrimeraCoincidencia("select id from sets order by id desc"));

                for (int i = 0; i < tope; i++)
                {
                    if (cbRepOseg.SelectedItem.ToString() == "Repeticiones")
                        BD.insertarSerieRepeticiones(setID, ejercicioID, arregloRepSeg[i], arregloPesos[i]);
                    else
                        BD.insertarSerieSegundos(setID, ejercicioID, arregloRepSeg[i], arregloPesos[i]);
                }

                MessageBox.Show("¡La serie se ha insertado correctamente!");
                limpiarForm();
            }
        }

        private int[] generarArregloEntero(String nombreTexto, int tope)
        {
            String cadena = "";
            int[] arregloDinamico = new int[tope];
            String textBox = "";

            for (int i = 0; i < tope; i++)
            {
                textBox = nombreTexto + i;
                Control[] controles = Controls.Find(textBox, true);
                if (controles.Length > 0)
                {
                    cadena = controles.First().Text;
                    cadena = cadena.Replace(",", ".");

                    if (int.TryParse(cadena, out int nuevoValor) && controles.Count() != 0)
                        arregloDinamico[i] = nuevoValor;
                    else
                    {
                        MessageBox.Show("¡No te olvides que las series, las repeticiones y los pesos deben ser números!");
                        return null;
                    }
                }
            }
            return arregloDinamico;
        }


        private float[] generarArregloFlotante(String nombreTexto, int tope)
        {
            String cadena = "";
            float[] arregloDinamico = new float[tope];
            String textBox = "";

            for (int i = 0; i < tope; i++)
            {
                textBox = nombreTexto + i;
                Control[] controles = Controls.Find(textBox, true);
                if (controles.Length > 0)
                {
                    cadena = controles.First().Text;
                    cadena = cadena.Replace(",", ".");

                    if (float.TryParse(cadena, out float nuevoValor) && controles.Count() != 0)
                        arregloDinamico[i] = nuevoValor;
                    else
                    {
                        MessageBox.Show("¡No te olvides que las series, las repeticiones y los pesos deben ser números!");
                        return null;
                    }
                }
            }
            return arregloDinamico;
        }
    }
}