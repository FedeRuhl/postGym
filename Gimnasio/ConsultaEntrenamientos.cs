using Gimnasio.Datos;
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
        private bool programaCargado = false;
        public ConsultaEntrenamientos()
        {
            InitializeComponent();
        }

        private void ConsultaEntrenamientos_Load(object sender, EventArgs e)
        {
            dtpSetsEntrenamiento.Value = DateTime.Now;
        }

        private void ConsultaEntrenamientos_Enter(object sender, EventArgs e)
        {
            programaCargado = true;
            cargarFechasValidas();
        }

        private void cargarFechasValidas()
        {
                DateTime fechaInicio = Sets.obtenerDiasSets().Item1;
                DateTime fechaFin = Sets.obtenerDiasSets().Item2;

                dtpSetsEntrenamiento.MinDate = fechaInicio;
                dtpSetsEntrenamiento.MaxDate = fechaFin;
        }

        private void actualizarDataGridView()
        {
            DateTime fecha = dtpSetsEntrenamiento.Value;
            string fechaFormatoUniversal = Fecha.convertirFormatoUniversal(fecha);

            dgbEntrenamientos.DataSource = Series.obtenerEntrenamientos(fechaFormatoUniversal).Tables[0];
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
            if (dgbEntrenamientos.Rows.Count > 0
                && dgbEntrenamientos.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                String pregunta = "¿Segurísimo que querés borrar esa serie?";
                if (MessageBox.Show(pregunta, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int idFilaActual = dgbEntrenamientos.CurrentRow.Index;
                    int serieID = Convert.ToInt32(dgbEntrenamientos.Rows[idFilaActual].Cells["SERIEID"].Value);

                    Series.eliminarSerie(serieID);
                    dgbEntrenamientos.Rows.RemoveAt(idFilaActual);
                }
            }
        }

        private void btnEliminarSet_Click(object sender, EventArgs e)
        {
            DateTime fechaFicticia = DateTime.Parse("1999/01/01");
            String pregunta = "¿Segurísimo que querés borrar el entrenamiento completo del día " + dtpSetsEntrenamiento.Value.ToShortDateString().ToString() + "?";
            if (dgbEntrenamientos.Rows.Count > 0
                && MessageBox.Show(pregunta, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes
                && dtpSetsEntrenamiento.MinDate.Year != fechaFicticia.Year)
            {
                int setID = Convert.ToInt32(dgbEntrenamientos.Rows[0].Cells["SETID"].Value);
                Sets.eliminarSet(setID);
                actualizarDataGridView();

                cargarFechasValidas();
            }
        }

        private void dgbEntrenamientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (programaCargado)
            {
                String columnaModificada = dgbEntrenamientos.Columns[e.ColumnIndex].Name;
                int serieID = Convert.ToInt32(dgbEntrenamientos.Rows[e.RowIndex].Cells["SERIEID"].Value);

                switch (columnaModificada)
                {
                    case "Peso":
                        double peso = Convert.ToDouble(dgbEntrenamientos.Rows[e.RowIndex].Cells["PESO"].Value);
                        Series.actualizarPesoSerie(peso, serieID);
                        break;
                    case "Segundos":
                        int segundos = Convert.ToInt32(dgbEntrenamientos.Rows[e.RowIndex].Cells["Segundos"].Value);
                        Series.actualizarSegundosSerie(segundos, serieID);
                        break;
                    case "Repeticiones":
                        int repeticiones = Convert.ToInt32(dgbEntrenamientos.Rows[e.RowIndex].Cells["Repeticiones"].Value);
                        Series.actualizarRepeticionesSerie(repeticiones, serieID);
                        break;
                    default:
                        MessageBox.Show("¡Solo el peso, la cantidad de repeticiones y los segundos pueden ser modificados!");
                        break;
                }
            }
        }

        private void dtpSetsEntrenamiento_CloseUp(object sender, EventArgs e)
        {
            actualizarDataGridView();
            reorganizarColumnas();
        }

        private void dgbEntrenamientos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgbEntrenamientos.Columns[e.ColumnIndex].Name == "Eliminar")
                dgbEntrenamientos[e.ColumnIndex, e.RowIndex].ToolTipText = "Doble clic para eliminar";
        }
    }
}