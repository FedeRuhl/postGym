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
                TextBox text = new TextBox();
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
    }
}
