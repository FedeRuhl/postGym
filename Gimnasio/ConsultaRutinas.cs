using Gimnasio.Datos;
using Gimnasio.Utilidades;
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
    public partial class ConsultaRutinas : Form
    {
        private DataRowView Opciones = null;
        private int rutinaID = 0;
        public ConsultaRutinas()
        {
            InitializeComponent();
        }

        private void ConsultaRutinas_Load(object sender, EventArgs e)
        {
            cbDias.SelectedIndex = 0;
        }

        private void cbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int diaID = cbDias.SelectedIndex + 1;
            cargarCheckBoxOpcion(diaID);
            actualizarDataGridViews();
        }

        private void acomodarColumnas()
        {
            dgbMusculos.Columns["Eliminar"].DisplayIndex = 1;
            dgbEjercicios.Columns["Borrar"].DisplayIndex = 1;

            dgbEjercicios.Columns["Ejercicio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void cargarCheckBoxOpcion(int diaID)
        {
            cbOpcion.DataSource = Rutinas.obtenerEjerciciosUnionMusculos(diaID).Tables[0];
            cbOpcion.ValueMember = "rutinaID";
            cbOpcion.DisplayMember = "rutinaID";
        }

        private void cbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Opciones = (DataRowView)cbOpcion.Items[cbOpcion.SelectedIndex];
            rutinaID = Convert.ToInt32(Opciones.Row["rutinaID"]);
            actualizarDataGridViews();
            acomodarColumnas();
        }

        private void actualizarDataGridViews()
        {
            #region Inicializacion variables
            int dia = cbDias.SelectedIndex + 1;
            if (cbOpcion.Items.Count > 0)
            {
                DataRowView Opcion = (DataRowView)cbOpcion.Items[cbOpcion.SelectedIndex];
                int rutinaID = Convert.ToInt32(Opcion.Row["rutinaID"]);
                #endregion

                dgbMusculos.DataSource = Rutinas.obtenerRutinaMusculos(rutinaID, dia).Tables[0];
                dgbEjercicios.DataSource = Rutinas.obtenerRutinaEjercicios(rutinaID, dia).Tables[0];

                dgbMusculos.Columns["ID"].Visible = false;
                dgbEjercicios.Columns["ID"].Visible = false;
            }
            else
            {
                limpiarForm();
            }
        }

        private void limpiarForm()
        {
            dgbMusculos.DataSource = "";
            dgbEjercicios.DataSource = "";
            cbOpcion.Text = "";
        }

        private void dgbMusculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbMusculos.Rows.Count > 0
                && dgbMusculos.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                String pregunta = "¿Segurísimo que querés borrar todos los datos del grupo muscular " + dgbMusculos["musculo", e.RowIndex].Value.ToString() + "?";
                if (MessageBox.Show(pregunta, "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    int idFilaActual = dgbMusculos.CurrentRow.Index;
                    int musculoID = Convert.ToInt32(dgbMusculos.Rows[idFilaActual].Cells["ID"].Value);

                    Rutinas.eliminarMusculoRutina(musculoID, rutinaID);
                    dgbMusculos.Rows.RemoveAt(idFilaActual);
                }
                    
            }
        }

        private void dgbEjercicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbEjercicios.Rows.Count > 0
                && dgbEjercicios.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                String pregunta = "¿Segurísimo que querés borrar todos los datos del ejercicio " + dgbEjercicios["ejercicio", e.RowIndex].Value.ToString() + "?";
                if (MessageBox.Show(pregunta, "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    int idFilaActual = dgbEjercicios.CurrentRow.Index;
                    int ejercicioID = Convert.ToInt32(dgbEjercicios.Rows[idFilaActual].Cells["ID"].Value);

                    Rutinas.eliminarEjercicioRutina(ejercicioID, rutinaID);
                    dgbEjercicios.Rows.RemoveAt(idFilaActual);
                }
                   
            }
        }

        private void btnEliminarRutina_Click(object sender, EventArgs e)
        {
            String pregunta = "¿Segurísimo que querés borrar la rutina " + cbOpcion.Text + "?";
            if (cbOpcion.SelectedIndex != -1
                && MessageBox.Show(pregunta, "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                int diaID = cbDias.SelectedIndex + 1;
                Rutinas.eliminarRutina(rutinaID);
                cargarCheckBoxOpcion(diaID);
                limpiarForm();
            }
        }

        private void cbEjercicios_Click(object sender, EventArgs e)
        {
            cbEjercicios.DataSource = Ejercicios.obtenerEjercicios().Tables[0];
            cbEjercicios.DisplayMember = "nombre";
            cbEjercicios.ValueMember = "nombre";
            //cbEjercicios.SelectedIndex = 0;
        }

        private void cbMusculos_Click(object sender, EventArgs e)
        {
            cbMusculos.DataSource = Musculos.obtenerMusculos().Tables[0];
            cbMusculos.DisplayMember = "musculo";
            cbMusculos.ValueMember = "musculo";
            cbMusculos.SelectedIndex = 0;
        }

        private void btnAgregarMusculo_Click(object sender, EventArgs e)
        {
            if (ValidarComboBox.opcionValida(cbOpcion, cbOpcion.Text)
                && ValidarComboBox.opcionValida(cbMusculos, cbMusculos.Text))
            {
                DataRowView Musculo = (DataRowView)cbMusculos.Items[cbMusculos.SelectedIndex];
                int musculoID = Convert.ToInt32(Musculo.Row["id"]);
                Rutinas.insertarMusculoRutina(musculoID, rutinaID);
                actualizarDataGridViews();
                cbMusculos.Focus();
            }
            else
            {
                MessageBox.Show("¡Primero tenes que seleccionar una opción de rutina y algún músculo!");
            }
        }

        private void btnAgregarEjercicio_Click(object sender, EventArgs e)
        {
            if (ValidarComboBox.opcionValida(cbOpcion, cbOpcion.Text)
                && ValidarComboBox.opcionValida(cbEjercicios, cbEjercicios.Text))
            {
                DataRowView Ejercicio = (DataRowView)cbEjercicios.Items[cbEjercicios.SelectedIndex];
                int ejercicioID = Convert.ToInt32(Ejercicio.Row["id"]);
                Rutinas.insertarEjercicioRutina(ejercicioID, rutinaID);
                actualizarDataGridViews();
                cbEjercicios.Focus();
            }
            else
            {
                MessageBox.Show("¡Primero tenes que seleccionar una opción de rutina y algún ejercicio!");
            }
        }

        private void dgbMusculos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgbMusculos.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                dgbMusculos[e.ColumnIndex, e.RowIndex].ToolTipText = "Doble clic para eliminar";
        }

        private void dgbEjercicios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgbEjercicios.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                dgbEjercicios[e.ColumnIndex, e.RowIndex].ToolTipText = "Doble clic para eliminar";
        }
    }
}
