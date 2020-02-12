﻿using System;
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
        //private int y = 198;
        private int y = 0;
        private int conteo = 0;
        TextBox text = new TextBox();
        public subirRutina()
        {
            InitializeComponent();
        }

        private void SubirRutina_Load(object sender, EventArgs e)
        {
            this.tablaPersonaTableAdapter.Fill(this.personaDataSet.tablaPersona);
            string cmd = string.Format("select * from tablaEjercicio");
            DataSet DS = Utilidades.Ejecutar(cmd);
            comboBox1.DataSource = DS.Tables[0];
            //y = labelPeso.Location.Y;
            y = 0;

            //y = 254;
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
            bool continuar = true;
            if (comboBox2.Text != "" && comboBox1.Text != "")
            {
                String[] arregloDinamico = new String[conteo + 1];
                string nombreTexto;
                int number = 0;
                string cadena;
                for (int i = 0; i < conteo; i++)
                {
                    nombreTexto = "txtDinamic" + i;
                    if (Controls.Find(nombreTexto, true).Length > 0)
                    {
                        cadena = Controls.Find(nombreTexto, true).First().Text;
                        if (int.TryParse(cadena, out number) && Controls.Find(nombreTexto, true).Count() != 0)
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
                    string fecha = dateTimePicker1.Value.ToString("yyyyMMdd HH:mm:ss");
                    string cmd = string.Format("EXEC actualizaDetallesEjercicio '{0}', '{1}', '{2}', '{3}'", nombrePersona, nombreEjercicio, fecha, conteo);
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    for (int i = 0; i < conteo; i++)
                    {
                        cmd = string.Format("EXEC crearSerie '{0}', '{1}'", arregloDinamico[i], nombreEjercicio);
                        ds = Utilidades.Ejecutar(cmd);
                    }

                    MessageBox.Show("¡Se ha guardado correctamente!");
                    for (int i = 0; i < conteo; i++)
                    {
                        nombreTexto = "txtDinamic" + i;
                        //Controls.Find(nombreTexto, true).First().Hide();
                        Controls.RemoveByKey(nombreTexto);
                        //y = 198;
                    }
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

        private void subirRutina_SizeChanged(object sender, EventArgs e)
        {
            //y = labelPeso.Location.Y;
        }
    }
}
