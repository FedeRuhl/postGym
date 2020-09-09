using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class ConsultaEntrenamientos : Form
    {
        public ConsultaEntrenamientos()
        {
            InitializeComponent();
        }

        private void ConsultaEntrenamientos_Load(object sender, EventArgs e)
        {
            cargarFechasValidas();
        }

        private void cargarFechasValidas()
        {
            DateTime fechaInicio = BD.obtenerDiasSets().Item1;
            DateTime fechaFin = BD.obtenerDiasSets().Item2;

            dtpSetsEntrenamiento.MinDate = fechaInicio;
            dtpSetsEntrenamiento.MaxDate = fechaFin;
        }

        private void dtpSetsEntrenamiento_ValueChanged(object sender, EventArgs e)
        {
            actualizarDataGridView();
            reorganizarColumnas();
        }

        private void actualizarDataGridView()
        {
            DateTime fecha = dtpSetsEntrenamiento.Value;
            string fechaFormatoUniversal = Fecha.convertirFormatoUniversal(fecha);

            dgbEntrenamientos.DataSource = BD.obtenerEntrenamientos(fechaFormatoUniversal).Tables[0];
        }

        private void reorganizarColumnas()
        {
            dgbEntrenamientos.Columns["Eliminar"].DisplayIndex = dgbEntrenamientos.Columns.Count - 1;
            dgbEntrenamientos.Columns["SETID"].Visible = false;
            dgbEntrenamientos.Columns["SERIEID"].Visible = false;
            dgbEntrenamientos.Columns["FECHA"].Visible = false;
            dgbEntrenamientos.Columns["Ejercicio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgbEntrenamientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbEntrenamientos.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                int idFilaActual = dgbEntrenamientos.CurrentRow.Index;
                int serieID = Convert.ToInt32(dgbEntrenamientos.Rows[idFilaActual].Cells["SERIEID"].Value);

                BD.eliminarSerie(serieID);
                dgbEntrenamientos.Rows.RemoveAt(idFilaActual);
            }
        }

        private void btnEliminarSet_Click(object sender, EventArgs e)
        {
            int setID = Convert.ToInt32(dgbEntrenamientos.Rows[0].Cells["SETID"].Value);
            BD.eliminarSet(setID);
            actualizarDataGridView();
        }
    }
}
