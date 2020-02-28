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
        TextBox text = new TextBox();
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
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido cargar la ventana. " + ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                text = new TextBox();
                Color colour = ColorTranslator.FromHtml("#3a3a3a");
                text.BackColor = colour;
                text.ForeColor = Color.White;
                text.Text = "Cantidad de peso (kg)";
                text.Width = 228;
                text.Location = new Point(0, y);
                text.Name = "txtDinamic" + conteo.ToString();
                panelPesos.Controls.Add(text);
                conteo++;
                y += 25;
            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido un error: " + error.Message); 
            }
        }

        private void btnGuardarEjercicio_Click(object sender, EventArgs e)
        {
            try
            {
                bool continuar = true;
                if (comboBox2.Text != "" && comboBox1.Text != "")
                {
                    string buscarPersona = "select idPersona from tablaPersona where nombrePersona = '" + comboBox2.Text + "'";
                    DataSet DS = Utilidades.Ejecutar(buscarPersona);
                    string buscarEjercicio = "select idEjercicio from tablaEjercicio where nombreEjercicio = '" + comboBox1.Text + "'";
                    DataSet DS2 = Utilidades.Ejecutar(buscarEjercicio);
                    if (DS.Tables[0].Rows.Count == 0 || DS2.Tables[0].Rows.Count == 0)
                        continuar = false;
                    String[] arregloDinamico = new String[conteo + 1];
                    string nombreTexto;
                    float number = 0;
                    string cadena;
                    for (int i = 0; i < conteo; i++)
                    {
                        nombreTexto = "txtDinamic" + i;
                        if (Controls.Find(nombreTexto, true).Length > 0)
                        {
                            cadena = Controls.Find(nombreTexto, true).First().Text;
                            cadena = cadena.Replace(",", ".");

                            if (float.TryParse(cadena, out number) && Controls.Find(nombreTexto, true).Count() != 0)
                            {
                                arregloDinamico[i] = cadena;
                            }
                            else
                            {
                                continuar = false;
                            }
                        }
                    }

                    if (conteo > 0 && continuar)
                    {
                        string nombrePersona = comboBox2.Text;
                        string nombreEjercicio = comboBox1.Text;
                        DateTime fecha = dateTimePicker1.Value;
                        string cmd = string.Format("EXEC actualizaDetallesEjercicio '{0}', '{1}', '{2}', '{3}'", nombrePersona, nombreEjercicio, fecha, conteo);
                        DataSet ds = Utilidades.Ejecutar(cmd);
                        for (int i = 0; i < conteo; i++)
                        {
                            cmd = string.Format("EXEC crearSerie '{0}', '{1}'", arregloDinamico[i], nombreEjercicio);
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
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message); 
            } 
        }
    }
}
