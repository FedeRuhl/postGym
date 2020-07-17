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
        private TextBox textPeso = new TextBox();
        private TextBox textRepOSeg = new TextBox();
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

        private void Button1_Click(object sender, EventArgs e)
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
                bool continuar = true;
                if (comboBox1.Text != "" && comboBox2.Text != "")
                {
                    string buscarPersona = "select idPersona from tablaPersona where nombrePersona = '" + comboBox2.Text + "'";
                    DataSet DS = Utilidades.Ejecutar(buscarPersona);
                    string buscarEjercicio = "select idEjercicio from tablaEjercicio where nombreEjercicio = '" + comboBox1.Text + "'";
                    DataSet DS2 = Utilidades.Ejecutar(buscarEjercicio);
                    if (DS.Tables[0].Rows.Count == 0 || DS2.Tables[0].Rows.Count == 0)
                        continuar = false;

                    String[] segundoOrepeticion = new String[conteo + 1];

                    String[] pesos = generarArregloDinamico("textPeso", ref continuar, false, ref segundoOrepeticion);
                    String[] repeticionesYsegundos = generarArregloDinamico("txtRepOSeg", ref continuar, true, ref segundoOrepeticion);

                    if (conteo > 0 && continuar)
                    {
                        string nombrePersona = comboBox2.Text;
                        string nombreEjercicio = comboBox1.Text;
                        DateTime fecha = dateTimePicker1.Value;
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
                        y = 0;
                        conteo = 0;
                    }
                    else
                    {
                        MessageBox.Show("Para subir la rutina los pesos de las series deben ser ingresados correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Ningún campo debe estar vacio para poder actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private String[] generarArregloDinamico(String nombreTexto, ref Boolean continuar, Boolean conSegundosYrepeticiones, ref String[] segundoOrepeticion)
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

                    if (conSegundosYrepeticiones)
                    {
                        String checkSegundos = "checkSegundos" + i;
                        String checkRepeticiones = "checkRepeticiones" + i;
                        CheckBox arregloSegundos = Controls.Find(checkSegundos, true).First() as CheckBox;
                        //CheckBox arregloRepeticiones = Controls.Find(checkRepeticiones, true).First() as CheckBox;

                        if (arregloSegundos.Checked)
                        {
                            segundoOrepeticion[i] = "S";
                        }
                        else
                        {
                            segundoOrepeticion[i] = "R";
                        }
                    }

                    if (float.TryParse(cadena, out number) && Controls.Find(textBox, true).Count() != 0)
                    {
                        arregloDinamico[i] = cadena;
                    }
                    else
                    {
                        continuar = false;
                    }
                }
            }

            return arregloDinamico;
        }
    }
}
