using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class ConsultaEjercicio : Form
    {
        public ConsultaEjercicio()
        {
            InitializeComponent();
        }

        private void ConsultaEjercicio_Load(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("select * from tablaEjercicio");
                DataSet ds = Utilidades.Ejecutar(cmd);
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error : " + ex.Message);
            }
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back))){
                if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int id = Convert.ToInt16(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                    string cmd = string.Format("EXEC eliminarEjercicio '{0}'", id);
                    DataSet DS = Utilidades.Ejecutar(cmd);
                }
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String ColumnaModificada = dataGridView2.Columns[e.ColumnIndex].HeaderText;
            String ValorCeldaModificada = dataGridView2.CurrentCell.Value.ToString();
            if (ColumnaModificada == "nombreEjercicio")
            {
                int IndiceFila = dataGridView2.CurrentCell.RowIndex;
                String ValorClave = dataGridView2["idEjercicio", IndiceFila].Value.ToString();
                String Consulta = "Update tablaEjercicio set nombreEjercicio = '" +
                ValorCeldaModificada + "' where idEjercicio  = '" + ValorClave + "'";

                DataSet ds = Utilidades.Ejecutar(Consulta);
            }
            else
            {
                MessageBox.Show(ColumnaModificada + " no es un dato que se pueda modificar.");
                this.Close();
            }
        }
    }
}
