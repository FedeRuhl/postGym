using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaGimnasio;

namespace Gimnasio
{
    public partial class subirRutina : Form
    {
        private int y = 0;
        private int conteo = 0;
        private TextBox textPeso;
        private TextBox textRepOSeg;
        private CheckBox checkSegundos;
        private CheckBox checkRepeticiones;

        public subirRutina()
        {
            InitializeComponent();
        }

        private void SubirRutina_Load(object sender, EventArgs e)
        {

            try
            {
                this.tablaEjercicioTableAdapter.Fill(this.tablaEjercicioDataSet.tablaEjercicio);
                this.tablaPersonaTableAdapter.Fill(this.tablaPersonaDataSet.tablaPersona);
                y = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar la ventana. " + ex.Message);
            }
        }

        private void btnAgregarSerie_Click(object sender, EventArgs e)
        {
            try
            {
                Color colour = ColorTranslator.FromHtml("#3a3a3a");

                textPeso = new TextBox
                {
                    BackColor = colour,
                    ForeColor = Color.White,
                    Text = "Peso (kg)",
                    Width = 75,
                    Location = new Point(0, y),
                    Name = "textPeso" + conteo.ToString()
                };
                panelPesos.Controls.Add(textPeso);

                textRepOSeg = new TextBox
                {
                    BackColor = colour,
                    ForeColor = Color.White,
                    Text = "Rep. o seg.",
                    Width = 75,
                    Location = new Point(75, y),
                    Name = "txtRepOSeg" + conteo.ToString()
                };
                panelPesos.Controls.Add(textRepOSeg);

                checkSegundos = new CheckBox
                {
                    ForeColor = Color.White,
                    BackColor = colour,
                    Width = 50,
                    Text = "S",
                    Location = new Point(150, y),
                    Name = "checkSegundos" + conteo.ToString()
                };
                panelPesos.Controls.Add(checkSegundos);

                checkRepeticiones = new CheckBox
                {
                    ForeColor = Color.White,
                    BackColor = colour,
                    Width = 50,
                    Text = "R",
                    Location = new Point(200, y),
                    Name = "checkRepeticiones" + conteo.ToString()
                };
                panelPesos.Controls.Add(checkRepeticiones);

                conteo++;
                y += 25;
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido un error: " + error.Message);
            }
        }

        private void btnGuardarEjercicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbEjercicio.Text != "" && cbPersona.Text != "")
                {
                    String[] segundoOrepeticion = new String[conteo + 1];
                    segundoOrepeticion = verificarCheckBoxActivados(segundoOrepeticion);

                    String[] pesos = generarArregloDinamico("textPeso");
                    //String[] repeticionesYsegundos = generarArregloDinamico("txtRepOSeg", ref segundoOrepeticion);
                    String[] repeticionesYsegundos = generarArregloDinamico("txtRepOSeg");



                    if (conteo > 0)
                    {
                        crearSerie(segundoOrepeticion, pesos, repeticionesYsegundos);
                        y = 0;
                        conteo = 0;
                    }
                    else
                        MessageBox.Show("Para subir la rutina los pesos de las series deben ser ingresados correctamente.");
                }
                else
                {
                    MessageBox.Show("Antes de subir una rutina debes crear un usuario y al menos un ejercicio.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private string[] generarArregloDinamico(String nombreTexto)
        {
            String cadena = "";
            float number = 0;
            String[] arregloDinamico = new String[conteo + 1];

            for (int i = 0; i < conteo; i++)
            {
                String textBox = nombreTexto + i;
                if (Controls.Find(textBox, true).Length > 0)
                {
                    cadena = Controls.Find(textBox, true).First().Text;
                    cadena = cadena.Replace(",", ".");

                    if (float.TryParse(cadena, out number) && Controls.Find(textBox, true).Count() != 0)
                        arregloDinamico[i] = cadena;
                }
            }
            return arregloDinamico;
        }

        private void crearSerie(string[] segundoOrepeticion, string[] pesos, string[] repeticionesYsegundos)
        {
            string nombrePersona = cbPersona.Text;
            string nombreEjercicio = cbEjercicio.Text;
            DateTime fecha = dtpFechaRutina.Value;
            string fechaFormatoUniversal = Utilidades.convertirFormatoUniversal(fecha);
            string cmd = string.Format("EXEC actualizaDetallesEjercicio '{0}', '{1}', '{2}', '{3}'", nombrePersona, nombreEjercicio, fechaFormatoUniversal, conteo);
            DataSet ds = Utilidades.Ejecutar(cmd);
            for (int i = 0; i < conteo; i++)
            {
                if (segundoOrepeticion.Length > 0)
                {
                    if (segundoOrepeticion[i] == "S")
                        cmd = string.Format("EXEC crearSerie '{0}', '{1}', '{2}', '{3}'", pesos[i], nombreEjercicio, null, repeticionesYsegundos[i]);
                    else
                        cmd = string.Format("EXEC crearSerie '{0}', '{1}', '{2}', '{3}'", pesos[i], nombreEjercicio, repeticionesYsegundos[i], null);
                }
                else
                    cmd = string.Format("EXEC crearSerie '{0}', '{1}', '{2}', '{3}'", pesos[i], nombreEjercicio, null, null);

                ds = Utilidades.Ejecutar(cmd);
            }

            MessageBox.Show("¡Se ha guardado correctamente!");
            panelPesos.Controls.Clear();
        }

        private String[] verificarCheckBoxActivados(String[] segundoOrepeticion)
        {
            for (int i = 0; i<conteo; i++)
            {
                String checkSegundos = "checkSegundos" + i;
                String checkRepeticiones = "checkRepeticiones" + i;
                int cantidadCheck = Controls.Find(checkSegundos, true).Length;
                if (cantidadCheck == 1)
                {
                    CheckBox arregloSegundos = Controls.Find(checkSegundos, true).First() as CheckBox;
                    //CheckBox arregloRepeticiones = Controls.Find(checkRepeticiones, true).First() as CheckBox;

                    if (arregloSegundos.Checked)
                        segundoOrepeticion[i] = "S";
                    else
                        segundoOrepeticion[i] = "R";
                }
            }
            return segundoOrepeticion;
        }
    }
}
