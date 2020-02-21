﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LibreriaGimnasio;
using System.Data.SqlClient;

namespace Gimnasio
{
    public partial class ConsultasDetallesEjercicio : Consultas
    {
        public ConsultasDetallesEjercicio()
        {
            InitializeComponent();
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
                // este si string cmd = "Select nombrePersona, tablaEjercicio.idEjercicio, nombreEjercicio, cantidadSeries, peso, tablaDetallesEjercicio.fecha FROM tablaEjercicio inner join tablaDetallesEjercicio on tablaEjercicio.idEjercicio = tablaDetallesEjercicio.idEjercicio inner join tablaSerie on tablaDetallesEjercicio.idDetalles = tablaSerie.idDetallesEjercicio inner join tablaPersona on tablaDetallesEjercicio.idPersona = tablaPersona.idPersona where fecha >= '" + fechaInicio + "' and  fecha < '" + fechaFin + "'";
                string cmd = "Select nombrePersona, tablaEjercicio.idEjercicio, nombreEjercicio, cantidadSeries, STRING_AGG(tablaSerie.peso,',') 'Lista de pesos', tablaDetallesEjercicio.fecha from tablaEjercicio inner join tablaDetallesEjercicio on tablaEjercicio.idEjercicio = tablaDetallesEjercicio.idEjercicio inner join tablaSerie on tablaDetallesEjercicio.idDetalles = tablaSerie.idDetallesEjercicio inner join tablaPersona on tablaDetallesEjercicio.idPersona = tablaPersona.idPersona where fecha >= '" + fechaInicio + "' and  fecha < '" + fechaFin + "' group by nombrePersona, tablaEjercicio.idEjercicio, nombreEjercicio, cantidadSeries, tablaDetallesEjercicio.fecha";
                ds = Utilidades.Ejecutar(cmd);
                dataGridView3.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha prudocido el siguiente error: " + ex.Message);
            }
        }

        private void ConsultasEjercicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'unirEjercicioDataSet.unirEjercicio' Puede moverla o quitarla según sea necesario.
            this.unirEjercicioTableAdapter.Fill(this.unirEjercicioDataSet.unirEjercicio);
            // TODO: esta línea de código carga datos en la tabla 'unirEjercicioDataSet.unirEjercicio' Puede moverla o quitarla según sea necesario.
            this.unirEjercicioTableAdapter.Fill(this.unirEjercicioDataSet.unirEjercicio);
            try
            {
                this.unirEjercicioTableAdapter.Fill(this.unirEjercicioDataSet.unirEjercicio);
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + error.Message);
            }
        }

        private void dataGridView3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int id = Convert.ToInt16(dataGridView3.CurrentCell.Value);
                    dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
                    string cmd = string.Format("EXEC eliminarDetallesEjercicio '{0}'", id);
                    DataSet DS = Utilidades.Ejecutar(cmd);
                }
            }
        }
    }
}
