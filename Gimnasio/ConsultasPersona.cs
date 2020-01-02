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
using System.IO;

namespace Gimnasio
{
    public partial class ConsultasPersona : Consultas
    {


        public ConsultasPersona()
        {
            InitializeComponent();
            //string cmd = string.Format("EXEC unirPersona");
            //DataSet DS = Utilidades.Ejecutar(cmd);
            //listBox1.DataSource = DS.Tables[0];
        }

        private void ConsultasPersona_Load(object sender, EventArgs e)
        {
            try
            {
                //Esto nos trae todas las personas con detalles, pero no las que no tengan detalles.
                string cmd = string.Format("EXEC unirPersona");
                DataSet DS = Utilidades.Ejecutar(cmd);
                dataGridView3.DataSource = DS.Tables[0];
                cmd = string.Format("select fecha from tablaDetallesPersona");
                DS = Utilidades.Ejecutar(cmd);
                listBox1.DataSource = DS.Tables[0];
                listBox1.ValueMember = "fecha";
                this.Location = new Point(this.Location.X, this.Location.Y+30);
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + error.Message);
            }
            
        }

        public static string direccion = "";
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            direccion = dataGridView3.Rows[e.RowIndex].Cells["fotoPersona"].Value.ToString();
            pictureBox1.Image = Image.FromFile(direccion);
            pictureBox1.Refresh();
        }

        public override void Buscar()
        {
            try
            {
                DataSet ds;
                string fechaInicio = listBox1.Text;
                DateTime fechaPrueba = DateTime.Parse(fechaInicio);
                fechaPrueba = fechaPrueba.AddMinutes(1);

                string fechaFin = fechaPrueba.ToString();

                //string fechaPosta = fecha.ToString("yyyyddMM HH:mm:ss");
                string cmd = "Select * from tablaDetallesPersona where fecha >= '" + fechaInicio + "' and  fecha < '" + fechaFin + "'";
                ds = Utilidades.Ejecutar(cmd);

                dataGridView3.DataSource = ds.Tables[0];
            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + error.Message);
            }
        }

        private void DataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView3_CellClick(sender, e);
            pictureBox1.Refresh();
        }
    }
}
