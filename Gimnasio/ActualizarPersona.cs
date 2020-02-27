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
    public partial class ActualizarPersona : Form
    {
        string fotoPersona = "";
        public ActualizarPersona()
        {
            InitializeComponent();
        }

        private void ActualizarPersona_Load_1(object sender, EventArgs e)
        {
            try
            {
                this.tablaPersonaTableAdapter.Fill(this.personaDataSet.tablaPersona);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fotoPersona = openFileDialog1.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido cargar la foto. " + ex.Message);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string buscarPersona = "select idPersona from tablaPersona where nombrePersona = '" + comboBox1.Text + "'";
                DataSet DS = Utilidades.Ejecutar(buscarPersona);
                if (comboBox1.Text != "" && fotoPersona != "" && txtAlturaPersona.Text != "" && txtPesoPersona.Text != "" && DS.Tables[0].Rows.Count != 0)
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
                    txtAlturaPersona.Clear();
                    txtPesoPersona.Clear();
                }

                else
                {
                    MessageBox.Show("Ningún campo debe estar vacio para poder actualizar. El nombre de la persona debe ser seleccionado entre los existentes.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + ex.Message);
            }
        }
    }
}