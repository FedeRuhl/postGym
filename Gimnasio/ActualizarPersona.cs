using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class ActualizarPersona : FormularioBase
    {
        string fotoPersona = "";
        public ActualizarPersona()
        {
            InitializeComponent();
        }

        private void ActualizarPersona_Load_1(object sender, EventArgs e)
        {
            this.tablaPersonaTableAdapter.Fill(this.personaDataSet.tablaPersona);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPersona = openFileDialog1.FileName;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idPersona = comboBox1.SelectedIndex + 1;
            string nombrePersona = comboBox1.Text.Trim();
            string altura = txtAlturaPersona.Text;
            string peso = txtPesoPersona.Text;
            double alturaPersona = Convert.ToDouble(altura.Replace(',', '.'));
            double pesoPersona = Convert.ToDouble(peso.Replace(',', '.'));
            string cmd = string.Format("EXEC actualizaPersona '{0}', '{1}', '{2}', '{3}', '{4}'", idPersona, nombrePersona, fotoPersona, alturaPersona, pesoPersona);
            Utilidades.Ejecutar(cmd);

            MessageBox.Show("¡Se ha actualizado correctamente!");
        }
    }
}
