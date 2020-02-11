using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LibreriaGimnasio;

namespace Gimnasio
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public virtual void Buscar()
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
