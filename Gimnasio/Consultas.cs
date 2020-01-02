using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaGimnasio;

namespace Gimnasio
{
    public partial class Consultas : FormularioBase
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet LlenarDataGridView(string tabla)
        {
            DataSet ds;
            string cmd = string.Format("SELECT * FROM " + tabla);
            ds = Utilidades.Ejecutar(cmd);

            return ds;
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gimnasioDataSet.tablaDetalles' Puede moverla o quitarla según sea necesario.
           //this.tablaDetallesTableAdapter.Fill(this.gimnasioDataSet.tablaDetalles);

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
