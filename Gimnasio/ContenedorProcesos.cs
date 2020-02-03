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
            subirRutina SR = new subirRutina();
            SR.MdiParent = this;
            SR.Show();
        }

        private void ContenedorProcesos_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass MC = new MainClass();
            this.Hide();
            MC.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            ActualizarPersona AP = new ActualizarPersona();
            AP.MdiParent = this;
            AP.Show();
        }
    }
}
