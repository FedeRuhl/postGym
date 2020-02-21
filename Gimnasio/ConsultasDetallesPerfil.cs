﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using LibreriaGimnasio;
using System.IO;

namespace Gimnasio
{
    public partial class ConsultasDetallesPerfil : Consultas
    {
        public ConsultasDetallesPerfil()
        {
            InitializeComponent();
        }

        private void ConsultasPersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'unirPersonaDataSet.unirPersona' Puede moverla o quitarla según sea necesario.
            this.unirPersonaTableAdapter.Fill(this.unirPersonaDataSet.unirPersona);
            try
            {
                this.unirPersonaTableAdapter.Fill(this.unirPersonaDataSet.unirPersona);
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + error.Message);
            }
        }

        public static string direccion = "";
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet ds;
                string idDetalles = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                string cmd = "Select fotoPersona from tablaDetallesPersona where idDetalles = '" + idDetalles + "'";
                ds = Utilidades.Ejecutar(cmd);
                direccion = ds.Tables[0].Rows[0]["fotoPersona"].ToString();
                pictureBox2.Image = Image.FromFile(direccion);
                pictureBox2.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }  
        }
        public override void Buscar()
        {
            try
            {
                DataSet ds;
                DateTime fecha = DateTime.Parse(listBox1.Text);
                string cmd = "select tablaPersona.idPersona, idDetalles, nombrePersona, alturaPersona, pesoPersona, fecha from tablaPersona inner join tablaDetallesPersona on tablaPersona.idPersona = tablaDetallesPersona.idPersona where fecha = '" + fecha.ToString() + "'";
                ds = Utilidades.Ejecutar(cmd);
                dataGridView3.DataSource = ds.Tables[0];
            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + error.Message);
            }
        }

        private void DataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView3_CellClick(sender, e);
                pictureBox2.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private void dataGridView3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int id = Convert.ToInt16(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[1].Value);
                    MessageBox.Show(id.ToString());
                    dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
                    string cmd = string.Format("EXEC eliminarDetallesPersona '{0}'", id);
                    DataSet DS = Utilidades.Ejecutar(cmd);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = Convert.ToDouble(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value);
                double peso = Convert.ToDouble(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[4].Value);
                double IMC = peso / Math.Pow(altura, 2);
                if (IMC < 16)
                {
                    MessageBox.Show("Su IMC es de " + IMC.ToString() + ". Usted posee delgadez severa.");
                }
                else if (IMC >= 16 && IMC < 18)
                {
                    MessageBox.Show("Su IMC es de " + IMC.ToString() + ". Usted posee delgadez moderada.");
                }
                else if (IMC >= 18 && IMC < 18.5)
                {
                    MessageBox.Show("Su IMC es de " + IMC.ToString() + ". Usted posee delgadez leve.");
                }
                else if (IMC >= 18.5 && IMC < 25)
                {
                    MessageBox.Show("Su IMC es de " + IMC.ToString() + ". Usted posee un peso normal y saludable.");
                }
                else if (IMC >= 25 && IMC < 30)
                {
                    MessageBox.Show("Su IMC es de " + IMC.ToString() + ". Usted posee pre-obesidad.");
                }
                else if (IMC >= 30 && IMC < 35)
                {
                    MessageBox.Show("Su IMC es de " + IMC.ToString() + ". Usted posee obesidad tipo I.");
                }
                else if (IMC >= 35 && IMC < 40)
                {
                    MessageBox.Show("Su IMC es de " + IMC.ToString() + ". Usted posee obesidad tipo II.");
                }
                else if (IMC > 40)
                {
                    MessageBox.Show("Su IMC es de " + IMC.ToString() + ". Usted posee obesidad tipo III.");
                }
                else
                    MessageBox.Show("No se ha podido calcular correctamente el índice de masa corporal.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }    
        }
    }
}
