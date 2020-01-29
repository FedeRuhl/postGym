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
    public partial class ConsultaEjercicio : FormularioBase
    {
        public ConsultaEjercicio()
        {
            InitializeComponent();
        }

        private void ConsultaEjercicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tablaEjercicio._tablaEjercicio' Puede moverla o quitarla según sea necesario.
            this.tablaEjercicioTableAdapter.Fill(this.tablaEjercicio._tablaEjercicio);

        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back))){
                /* if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                 {
                     dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);

               */
                int id = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                string cmd = string.Format("delete from tablaEjercicio where idEjercicio = 2");
                DataSet DS = Utilidades.Ejecutar(cmd);

            }
        }
    }
}
