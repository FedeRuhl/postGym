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
    public partial class MainClass : Form
    {
        public MainClass()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            ContenedorProcesos CP = new ContenedorProcesos();
            this.Hide();
            CP.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            ContenedorMantenimiento CM = new ContenedorMantenimiento();
            this.Hide();
            CM.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            ContenedorConsultas CC = new ContenedorConsultas();
            this.Hide();
            CC.Show();
        }

        private void MainClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
