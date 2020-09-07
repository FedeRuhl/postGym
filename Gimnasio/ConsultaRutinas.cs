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
            string consulta = string.Format($"select VRutinaEjercicios.rutinaID from VRutinaEjercicios " +
                $"where DiaID = {diaID} union " +
                $"select VRutinaMusculos.rutinaID from VRutinaMusculos " +
                $"where DiaID = {diaID}");
            DataSet ds = BD.Consultar(consulta);

            cbOpcion.DataSource = ds.Tables[0];
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
                String rutinaID = Opcion.Row["rutinaID"].ToString();
                #endregion

                string consulta = string.Format($"select Musculo, ID from VRutinaMusculos where RutinaID = {rutinaID} and DiaID = {dia}");
                DataSet ds = BD.Consultar(consulta);
                dgbMusculos.DataSource = ds.Tables[0];

                consulta = string.Format($"select Ejercicio, ID from VRutinaEjercicios where RutinaID = {rutinaID} and DiaID = {dia}");
                ds = BD.Consultar(consulta);
                dgbEjercicios.DataSource = ds.Tables[0];

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
            if (dgbMusculos.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                int idFilaActual = dgbMusculos.CurrentRow.Index;
                int musculoID = Convert.ToInt32(dgbMusculos.Rows[idFilaActual].Cells["ID"].Value);
                
                BD.eliminarMusculoRutina(musculoID, rutinaID);
                dgbMusculos.Rows.RemoveAt(idFilaActual);
            }
        }

        private void dgbEjercicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbEjercicios.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                int idFilaActual = dgbEjercicios.CurrentRow.Index;
                int ejercicioID = Convert.ToInt32(dgbEjercicios.Rows[idFilaActual].Cells["ID"].Value);

                BD.eliminarEjercicioRutina(ejercicioID, rutinaID);
                dgbEjercicios.Rows.RemoveAt(idFilaActual);
            }
        }

        private void btnEliminarRutina_Click(object sender, EventArgs e)
        {
            int diaID = cbDias.SelectedIndex + 1;
            BD.eliminarRutina(rutinaID);
            cargarCheckBoxOpcion(diaID);
            limpiarForm();
        }

        private void cbEjercicios_Click(object sender, EventArgs e)
        {
            String consulta = string.Format("select * from ejercicios");
            DataSet ds = BD.Consultar(consulta);
            cbEjercicios.DataSource = ds.Tables[0];
            cbEjercicios.DisplayMember = "nombre";
            cbEjercicios.ValueMember = "nombre";
            cbEjercicios.SelectedIndex = 0;
        }

        private void cbMusculos_Click(object sender, EventArgs e)
        {
            String consulta = string.Format($"select * from musculos");
            DataSet ds = BD.Consultar(consulta);
            cbMusculos.DataSource = ds.Tables[0];
            cbMusculos.DisplayMember = "musculo";
            cbMusculos.ValueMember = "musculo";
            cbMusculos.SelectedIndex = 0;
        }

        private void btnAgregarMusculo_Click(object sender, EventArgs e)
        {
            if (cbOpcion.SelectedIndex != -1)
            {
                DataRowView Musculo = (DataRowView)cbMusculos.Items[cbMusculos.SelectedIndex];
                int musculoID = Convert.ToInt32(Musculo.Row["id"]);
                BD.insertarMusculoRutina(musculoID, rutinaID);
                actualizarDataGridViews();
            }
            else
            {
                MessageBox.Show("¡Primero tenes que seleccionar una opción de rutina!");
            }
        }

        private void btnAgregarEjercicio_Click(object sender, EventArgs e)
        {
            if (cbOpcion.SelectedIndex != -1)
            {
                DataRowView Ejercicio = (DataRowView)cbEjercicios.Items[cbEjercicios.SelectedIndex];
                int ejercicioID = Convert.ToInt32(Ejercicio.Row["id"]);
                BD.insertarEjercicioRutina(ejercicioID, rutinaID);
                actualizarDataGridViews();
            }
            else
            {
                MessageBox.Show("¡Primero tenes que seleccionar una opción de rutina!");
            }
        }
    }
}
