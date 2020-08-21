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

        private void MainClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ContenedorProcesos CP = new ContenedorProcesos();
                this.Hide();
                CP.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento M = new Mantenimiento();
                this.Hide();
                M.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ContenedorConsultas CC = new ContenedorConsultas();
                this.Hide();
                CC.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }
    }
}
