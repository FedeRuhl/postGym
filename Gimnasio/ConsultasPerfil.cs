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
    public partial class ConsultasPerfiles : FormularioBase
    {
        public ConsultasPerfiles()
        {
            InitializeComponent();
        }

        private void ConsultasPerfiles_Load(object sender, EventArgs e)
        {
            this.tablaPersonaTableAdapter.Fill(this.personaDataSet.tablaPersona);

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int id = Convert.ToInt16(dataGridView1.CurrentCell.Value);
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    string cmd = string.Format("EXEC eliminarPersona '{0}'", id);
                    DataSet DS = Utilidades.Ejecutar(cmd);
                }
            }
        }
    }
}
