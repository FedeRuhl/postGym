using System;
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
        bool unaVezMaximizar = false;
        bool unaVezRestaurar = false;
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
                string cmd = "Select * from tablaDetallesEjercicio where fecha >= '" + fechaInicio + "' and  fecha < '" + fechaFin + "'";
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
                this.unirEjercicioTableAdapter.Fill(this.unirEjercicioDataSet.unirEjercicio);
                this.unirPersonaTableAdapter.Fill(this.unirPersonaDataSet.unirPersona);
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

        protected override void iconMaximizar_Click(object sender, EventArgs e)
        {
            base.iconMaximizar_Click(sender, e);
            dataGridView3.Size = new Size(902, dataGridView3.Size.Height);
            if (!unaVezMaximizar)
            {
                dataGridView3.Location = new Point((dataGridView3.Location.X - 30), dataGridView3.Location.Y);
                unaVezMaximizar = true;
                unaVezRestaurar = false;
            }
        }

        protected override void iconRestaurar_Click(object sender, EventArgs e)
        {
            base.iconRestaurar_Click(sender, e);
            dataGridView3.Size = new Size(702, dataGridView3.Size.Height);
            if (!unaVezRestaurar)
            {
                dataGridView3.Location = new Point((dataGridView3.Location.X + 30), dataGridView3.Location.Y);
                unaVezRestaurar = true;
                unaVezMaximizar = false;
            }
        }
    }
}
