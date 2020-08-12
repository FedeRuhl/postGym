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
    public partial class ConsultasPerfiles : Form
    {
        public ConsultasPerfiles()
        {
            InitializeComponent();
        }

        private void ConsultasPerfiles_Load(object sender, EventArgs e)
        {    
            try
            {
                string cmd = string.Format("select * from tablaPersona");
                DataSet ds = Utilidades.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int id = Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    string cmd = string.Format("EXEC eliminarPersona '{0}'", id);
                    DataSet DS = Utilidades.Ejecutar(cmd);
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String ColumnaModificada = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            String ValorCeldaModificada = dataGridView1.CurrentCell.Value.ToString();
            if (ColumnaModificada == "nombrePersona")
            {
                int IndiceFila = dataGridView1.CurrentCell.RowIndex;
                String ValorClave = dataGridView1["idPersona", IndiceFila].Value.ToString();
                String Consulta = "Update tablaPersona set nombrePersona = '" +
                ValorCeldaModificada + "' where idPersona  = '" + ValorClave + "'";

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
