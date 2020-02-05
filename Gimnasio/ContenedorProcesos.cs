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
        private bool salio;
        private bool botonDosAdentro;
        public ContenedorProcesos()
        {
            InitializeComponent();
        }

        private void ContenedorProcesos_Load(object sender, EventArgs e)
        {
            MdiClient oMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    oMDI = (MdiClient)ctl;
                    oMDI.BackColor = this.BackColor;

                    panel1.Controls.Add(button1);

                    botonDosAdentro = false;
                }
                catch (InvalidCastException exc)
                {
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Width = 52;
            subirRutina SR = new subirRutina();
            SR.MdiParent = this;
            SR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Width = 52;
            ActualizarPersona AP = new ActualizarPersona();
            AP.MdiParent = this;
            AP.Show();
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
