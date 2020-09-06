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
        public ConsultaRutinas()
        {
            InitializeComponent();
        }

        private void ConsultaRutinas_Load(object sender, EventArgs e)
        {
            
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
                DataRowView Opciones = (DataRowView)cbOpcion.Items[cbOpcion.SelectedIndex];
                int rutinaID = Convert.ToInt32(Opciones.Row["rutinaID"]);
                int musculoID = Convert.ToInt32(dgbMusculos.Rows[idFilaActual].Cells["ID"].Value);
                
                BD.eliminarMusculoRutina(musculoID, rutinaID);
                dgbMusculos.Rows.RemoveAt(idFilaActual);
            }
        }
    }
}
