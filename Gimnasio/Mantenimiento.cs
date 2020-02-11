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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        public virtual void Agregar()
        {

        }

        public virtual void Eliminar()
        {

        }

        public virtual void Modificar()
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}
