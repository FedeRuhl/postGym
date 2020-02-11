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
    public partial class ContenedorConsultas : FormularioBase
    {
        public ContenedorConsultas()
        {
            InitializeComponent();
        }

        private void ContenedorConsultas_Load(object sender, EventArgs e)
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
            }*/
        }

        private void ContenedorConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass MC = new MainClass();
            this.Hide();
            MC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel1.Width = 55;
            ConsultasPerfiles CP = new ConsultasPerfiles();
            CP.TopLevel = false;
            CP.Dock = DockStyle.Fill;
            panel2.Controls.Add(CP);
            CP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel1.Width = 55;
            ConsultasDetallesPerfil CP = new ConsultasDetallesPerfil();
            CP.TopLevel = false;
            CP.Dock = DockStyle.Fill;
            panel2.Controls.Add(CP);
            CP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel1.Width = 55;
            ConsultaEjercicio CE = new ConsultaEjercicio();
            CE.TopLevel = false;
            CE.Dock = DockStyle.Fill;
            panel2.Controls.Add(CE);
            CE.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel1.Width = 55;
            ConsultasDetallesEjercicio CE = new ConsultasDetallesEjercicio();
            CE.TopLevel = false;
            CE.Dock = DockStyle.Fill;
            panel2.Controls.Add(CE);
            CE.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //if (panel2.Controls.Count == 0)
                panel1.Width = 242;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //if (panel2.Controls.Count == 0)
                panel1.Width = 242;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
           // if (panel2.Controls.Count == 0)
                panel1.Width = 242;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            //if (panel2.Controls.Count == 0)
                panel1.Width = 242;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
           // if (panel2.Controls.Count == 0)
                panel1.Width = 242;
        }

        private void ContenedorConsultas_Resize(object sender, EventArgs e)
        {
           // MessageBox.Show("La cantidad de elementos es : " + this.Controls.Count);
        }
    }
}
