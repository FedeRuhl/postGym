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
            cbOpcion.DisplayMember = "rutinaID";
            cbOpcion.ValueMember = "rutinaID";
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

                string consulta = string.Format($"select Musculo from VRutinaMusculos where RutinaID = {rutinaID} and DiaID = {dia}");
                DataSet ds = BD.Consultar(consulta);
                dgbMusculos.DataSource = ds.Tables[0];

                consulta = string.Format($"select Ejercicio from VRutinaEjercicios where RutinaID = {rutinaID} and DiaID = {dia}");
                ds = BD.Consultar(consulta);
                dgbEjercicios.DataSource = ds.Tables[0];
            }
            else
            {
                dgbMusculos.DataSource = "";
                dgbEjercicios.DataSource = "";
                cbOpcion.Text = "";
            }
        }
    }
}
