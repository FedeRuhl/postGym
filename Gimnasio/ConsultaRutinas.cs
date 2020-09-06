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
            int indice = cbDias.SelectedIndex + 1;

            string consulta = string.Format($"select Musculo from VRutinaMusculos where DiaID = {indice}");
            DataSet ds = BD.Consultar(consulta);
            dgbMusculos.DataSource = ds.Tables[0];

            consulta = string.Format($"select Ejercicio from VRutinaEjercicios where DiaID = {indice}");
            ds = BD.Consultar(consulta);
            dgbEjercicios.DataSource = ds.Tables[0];

            acomodarColumnas();
        }

        private void acomodarColumnas()
        {
            dgbMusculos.Columns["Eliminar"].DisplayIndex = 1;
            dgbEjercicios.Columns["Borrar"].DisplayIndex = 1;

            dgbEjercicios.Columns["Ejercicio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
