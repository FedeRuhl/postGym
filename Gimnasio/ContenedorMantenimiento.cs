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

        private void Label1_Click(object sender, EventArgs e)
        {
            CrearPersona MP = new CrearPersona();
            MP.MdiParent = this;
            MP.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            MantenimientoEjercicio ME = new MantenimientoEjercicio();
            ME.MdiParent = this;
            ME.Show();
        }

        private void ContenedorMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass MC = new MainClass();
            this.Hide();
            MC.Show();
        }
    }
}
