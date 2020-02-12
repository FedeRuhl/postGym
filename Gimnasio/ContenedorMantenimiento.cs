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
        }

        private void ContenedorMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass MC = new MainClass();
            this.Hide();
            MC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Width = 45;
                panel2.Controls.Clear();
                CrearPersona MP = new CrearPersona();
                MP.TopLevel = false;
                MP.Dock = DockStyle.Fill;
                panel2.Controls.Add(MP);
                MP.Show();
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
                panel1.Width = 45;
                panel2.Controls.Clear();
                MantenimientoEjercicio ME = new MantenimientoEjercicio();
                ME.TopLevel = false;
                ME.Dock = DockStyle.Fill;
                panel2.Controls.Add(ME);
                ME.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
                panel1.Width = 277;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
                panel1.Width = 277;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
                panel1.Width = 277;
        }
    }
}
