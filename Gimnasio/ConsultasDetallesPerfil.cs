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
            try
            {
                //Esto nos trae todas las personas con detalles, pero no las que no tengan detalles.
                string cmd = string.Format("EXEC unirPersona");
                DataSet DS = Utilidades.Ejecutar(cmd);
                dataGridView3.DataSource = DS.Tables[0];
                cmd = string.Format("select fecha from tablaDetallesPersona");
                DS = Utilidades.Ejecutar(cmd);
                listBox1.DataSource = DS.Tables[0];
                listBox1.ValueMember = "fecha";
                this.Location = new Point(this.Location.X, this.Location.Y+30);
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + error.Message);
            }
        }

        public static string direccion = "";
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            direccion = dataGridView3.Rows[e.RowIndex].Cells["fotoPersona"].Value.ToString();
            pictureBox1.Image = Image.FromFile(direccion);
            pictureBox1.Refresh();
        }
        public override void Buscar()
        {
            try
            {
                DataSet ds;
                DateTime fecha = DateTime.Parse(listBox1.Text);
                string fechaInicio = fecha.ToString("yyyyMMdd HH:mm:ss");
                fecha = fecha.AddMinutes(1);
                string fechaFin = fecha.ToString("yyyyMMdd HH:mm:ss");
                string cmd = "Select * from tablaDetallesPersona where fecha >= '" + fechaInicio + "' and  fecha < '" + fechaFin + "'";
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
            DataGridView3_CellClick(sender, e);
            pictureBox1.Refresh();
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
    }
}