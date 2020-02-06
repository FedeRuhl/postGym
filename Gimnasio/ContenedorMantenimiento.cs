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
    public partial class ContenedorMantenimiento : FormularioBase
    {
        public ContenedorMantenimiento()
        {
            InitializeComponent();
        }

        private void ContenedorMantenimiento_Load(object sender, EventArgs e)
        {
            MdiClient oMDI;
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
        }

        private void ContenedorMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass MC = new MainClass();
            this.Hide();
            MC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Width = 45;
            CrearPersona MP = new CrearPersona();
            MP.MdiParent = this;
            MP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Width = 45;
            MantenimientoEjercicio ME = new MantenimientoEjercicio();
            ME.MdiParent = this;
            ME.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
                panel1.Width = 277;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
                panel1.Width = 277;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0)
                panel1.Width = 277;
        }
    }
}
