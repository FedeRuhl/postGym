using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                string cmd = "Select nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio, cantidadSeries, STRING_AGG(tablaSerie.peso,', ') 'Lista de pesos', tablaDetallesEjercicio.fecha from tablaEjercicio inner join tablaDetallesEjercicio on tablaEjercicio.idEjercicio = tablaDetallesEjercicio.idEjercicio inner join tablaSerie on tablaDetallesEjercicio.idDetalles = tablaSerie.idDetallesEjercicio inner join tablaPersona on tablaDetallesEjercicio.idPersona = tablaPersona.idPersona where fecha = '" + fecha.ToShortDateString() + "' group by nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio, cantidadSeries, tablaDetallesEjercicio.fecha";
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
            try
            {
                string cmd = "select fecha from tablaDetallesEjercicio group by fecha";
                DataSet ds = Utilidades.Ejecutar(cmd);
                listBox1.DataSource = ds.Tables[0];
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
                    int id = Convert.ToInt16(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[2].Value);
                    dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
                    string cmd = string.Format("EXEC eliminarDetallesEjercicio '{0}'", id);
                    DataSet DS = Utilidades.Ejecutar(cmd);
                }
            }
        }
    }
}
