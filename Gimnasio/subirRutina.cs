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

        private void TxtCantidadSeries_TextChanged(object sender, EventArgs e)
        {/*
            try
            {
            Label lblCantRepeticiones = new Label();
            TextBox txtCantRepeticiones = new TextBox();

            lblCantRepeticiones.Width = 226;
            lblCantRepeticiones.Height = 26;
            lblCantRepeticiones.Margin = new Padding(10, 30, 3, 3);

            panel1.Controls.Add(lblCantRepeticiones);

            txtCantRepeticiones.Width = 157;
            txtCantRepeticiones.Height = 22;
            txtCantRepeticiones.Margin = new Padding(3, 3, 3,3);

            panel1.Controls.Add(txtCantRepeticiones);
            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido un error: " + error.Message); 
            }
            */
        }
        private void TxtCantidadSeries_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            try
            {
                    
                Label lblCantRepeticiones = new Label();
                TextBox txtCantRepeticiones = new TextBox();

                lblCantRepeticiones.Width = 226;
                lblCantRepeticiones.Height = 26;
                lblCantRepeticiones.Margin = new Padding(10, 30, 3, 3);

                panel1.Controls.Add(lblCantRepeticiones);

                txtCantRepeticiones.Width = 157;
                txtCantRepeticiones.Height = 22;
                txtCantRepeticiones.Margin = new Padding(3, 3, 3, 3);

                panel1.Controls.Add(txtCantRepeticiones);
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido un error: " + error.Message);
            }
            */
        }

        private void Button1_Click(object sender, EventArgs e)
        {          
            try
            {
            Label lblCantRepeticiones = new Label();
            TextBox txtCantRepeticiones = new TextBox();
            
            lblCantRepeticiones.Width = 171;
            lblCantRepeticiones.Height = 26;
            //lblCantRepeticiones.Margin = new Padding(10, 30, 3, 3);
            lblCantRepeticiones.Text = "Cantidad de repeticiones: ";
                lblCantRepeticiones.Visible = true;
                lblCantRepeticiones.Location = new Point(12, 284);
                //lblCantRepeticiones.Show();
                
            this.Controls.Add(lblCantRepeticiones);
  
            txtCantRepeticiones.Width = 157;
            txtCantRepeticiones.Height = 22;
           // txtCantRepeticiones.Margin = new Padding(3, 3, 3,3);
                txtCantRepeticiones.Text = "Hola";
                txtCantRepeticiones.Location = new Point(171+12, 288);
                txtCantRepeticiones.Visible = true;
               // txtCantRepeticiones.Show();
           this.Controls.Add(txtCantRepeticiones);
            
                

            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido un error: " + error.Message); 
            }
        }
    }
}
