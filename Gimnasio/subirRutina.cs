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
    public partial class subirRutina : FormularioBase
    {
        private int y = 150;
        private int conteo = 0;
        TextBox text = new TextBox();
        public subirRutina()
        {
            InitializeComponent();
        }

        private void SubirRutina_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("select * from tablaEjercicio");
            DataSet DS = Utilidades.Ejecutar(cmd);
            comboBox1.DataSource = DS.Tables[0];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                text = new TextBox();
                text.Text = "Cantidad de peso (kg)";
                text.Height = 23;
                text.Width = 200;
                text.Location = new Point(115, y);
                y += 25;
                text.Name = "txtDinamic" + conteo.ToString();
                conteo++;
                Controls.Add(text);
            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido un error: " + error.Message); 
            }
        }

        private void btnGuardarEjercicio_Click(object sender, EventArgs e)
        {
            String[] arregloDinamico = new String[conteo+1];
            string nombreTexto;
            for (int i = 0; i<conteo; i++)
            {
                nombreTexto = "txtDinamic" + i;
                arregloDinamico[i] = Controls.Find(nombreTexto, true).First().Text;
            }
            string nombreEjercicio = comboBox1.Text.Trim();
            string cmd = string.Format("EXEC actualizaDetallesEjercicio '{0}', '{1}', '{2}'", nombreEjercicio, dateTimePicker1.Value, conteo);
            DataSet ds = Utilidades.Ejecutar(cmd);
            for (int i = 0; i<conteo; i++)
            {
                cmd = string.Format("EXEC crearSerie {0}, {1}", arregloDinamico[i], nombreEjercicio);
                ds = Utilidades.Ejecutar(cmd);
            }

            
            
        }
    }
}
