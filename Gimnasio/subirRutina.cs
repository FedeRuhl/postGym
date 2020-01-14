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
    public partial class subirRutina : FormularioBase
    {
        private int y = 150;
        private int conteo = 0;
        TextBox text = new TextBox();
        public subirRutina()
        {
            InitializeComponent();
        }

        private void SubirRutina_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'detallesEjercicio.unirEjercicio' Puede moverla o quitarla según sea necesario.
            //this.unirEjercicioTableAdapter.Fill(this.detallesEjercicio.unirEjercicio);
            string cmd = string.Format("select * from tablaEjercicio");
            DataSet DS = Utilidades.Ejecutar(cmd);
            comboBox1.DataSource = DS.Tables[0];

          //  MessageBox.Show((DS.Tables[0].Rows[comboBox1.SelectedIndex]["idEjercicio"]).ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                text = new TextBox();
                text.Text = "Cantidad de peso (kg)";
                text.Height = 23;
                text.Width = 200;
                text.Location = new Point(115, y);
                y += 25;
                text.Name = "txtDinamic" + conteo.ToString();
                conteo++;
                Controls.Add(text);
                

            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido un error: " + error.Message); 
            }
        }
		//$exception	{"Sintaxis incorrecta cerca de '/'."}	System.Data.SqlClient.SqlException

        private void btnGuardarEjercicio_Click(object sender, EventArgs e)
        {
            
            //La cantidad de series queda en CONTEO.
            //Convert.ToInt32(txtDinamic1.text.Trim());
            //MessageBox.Show(text.Text); //esto me da el último
            String[] arregloDinamico = new String[conteo+1];
            string nombreTexto;
            for (int i = 0; i<conteo; i++)
            {
                nombreTexto = "txtDinamic" + i;
                //MessageBox.Show(Controls.Find(nombreTexto, true).First().Text);
                arregloDinamico[i] = Controls.Find(nombreTexto, true).First().Text;
            }

            string nombreEjercicio = "'" + comboBox1.Text.Trim() + "'";
            string fecha = "'" + dateTimePicker1.Value + "'";

            string cmd = string.Format("EXEC actualizaDetallesEjercicio {0}, {1}, {2}", nombreEjercicio, fecha, conteo);
            DataSet ds = Utilidades.Ejecutar(cmd);

            int idDetallesEjercicioInventado = 1;

            for (int i = 0; i<conteo; i++)
            {
                MessageBox.Show(arregloDinamico[i]);
                cmd = string.Format("EXEC crearSerie {0}, {1}", arregloDinamico[i], idDetallesEjercicioInventado);
                ds = Utilidades.Ejecutar(cmd);
            }

            
            
        }
    }
}
