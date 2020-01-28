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
    public partial class ConsultasPerfiles : FormularioBase
    {
        public ConsultasPerfiles()
        {
            InitializeComponent();
        }

        private void ConsultasPerfiles_Load(object sender, EventArgs e)
        {
            this.tablaPersonaTableAdapter.Fill(this.personaDataSet.tablaPersona);

        }
    }
}
