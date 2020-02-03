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
    public partial class FormularioBase : Form
    {
        public FormularioBase()
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

        public virtual void Buscar()
        {

        }

        private void FormularioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                if (MessageBox.Show("¿Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
