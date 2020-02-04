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
            ConsultasPerfiles CP = new ConsultasPerfiles();
            CP.MdiParent = this;
            CP.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            ConsultaEjercicio CE = new ConsultaEjercicio();
            CE.MdiParent = this;
            CE.Show();
        }

        private void ContenedorConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass MC = new MainClass();
            this.Hide();
            MC.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ConsultasDetallesPerfil CP = new ConsultasDetallesPerfil();
            CP.MdiParent = this;
            CP.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ConsultasDetallesEjercicio CE = new ConsultasDetallesEjercicio();
            CE.MdiParent = this;
            CE.Show();
        }
    }
}
