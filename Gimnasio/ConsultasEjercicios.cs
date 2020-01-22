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
using System.Data.SqlClient;

namespace Gimnasio
{
    public partial class ConsultasEjercicios : Consultas
    {
        public ConsultasEjercicios()
        {
            InitializeComponent();
        }

        public override void Buscar()
        {
            try
            {
                DataSet ds;
                string fechaInicio = listBox1.Text;
                DateTime fechaModif = DateTime.Parse(fechaInicio);
                fechaModif = fechaModif.AddMinutes(1);
                string fechaFin = fechaModif.ToString();
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
                string cmd = string.Format("EXEC unirEjercicio");
                DataSet DS = Utilidades.Ejecutar(cmd);
                dataGridView3.DataSource = DS.Tables[0];
                listBox1.DataSource = DS.Tables[0];
                listBox1.ValueMember = "fecha";
                this.Location = new Point(this.Location.X, this.Location.Y + 30);
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + error.Message);
            }
        }
    }
}
