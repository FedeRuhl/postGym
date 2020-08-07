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
                string fechaFormatoUniversal = Utilidades.convertirFormatoUniversal(fecha);
                string cmd = string.Format("EXEC traerEjercicioConFecha '{0}'", fechaFormatoUniversal);
                ds = Utilidades.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha prudocido el siguiente error: " + ex.Message);
            }
        }

        private void ConsultasDetallesEjercicio_Load(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("EXEC traerEjercicio");
                DataSet ds = Utilidades.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
                cmd = "select fecha from tablaDetallesEjercicio group by fecha";
                ds = Utilidades.Ejecutar(cmd);
                listBox1.DataSource = ds.Tables[0];

                dataGridView1.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                //this.unirEjercicioTableAdapter1.Fill(this.unirEjercicioDataSet1.unirEjercicio);
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + error.Message);
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int id = Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    string cmd = string.Format("EXEC eliminarDetallesEjercicio '{0}'", id);
                    DataSet DS = Utilidades.Ejecutar(cmd);
                }
            }
        }
    }
}
