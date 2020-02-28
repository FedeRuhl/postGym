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
                this.tablaEjercicioTableAdapter.Fill(this.tablaEjercicioDataSet.tablaEjercicio);
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
    }
}
