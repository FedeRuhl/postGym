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
    public partial class ContenedorProcesos : FormularioBase
    {
        public ContenedorProcesos()
        {
            InitializeComponent();
        }

        private void ContenedorProcesos_Load(object sender, EventArgs e)
        {
            /*MdiClient oMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    oMDI = (MdiClient)ctl;
                    oMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }
            */
        }

        private void ContenedorProcesos_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass MC = new MainClass();
            this.Hide();
            MC.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
                panel1.Width = 250;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                panel1.Width = 52;
                panel2.Controls.Clear();
                subirRutina SR = new subirRutina();
                SR.TopLevel = false;
                SR.Dock = DockStyle.Fill;
                panel2.Controls.Add(SR);
                SR.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                panel1.Width = 52;
                panel2.Controls.Clear();
                ActualizarPersona AP = new ActualizarPersona();
                AP.TopLevel = false;
                AP.Dock = DockStyle.Fill;
                panel2.Controls.Add(AP);
                AP.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            panel1.Width = 250;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
                panel1.Width = 250;
        }
    }
}
