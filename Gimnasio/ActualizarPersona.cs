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
    public partial class ActualizarPersona : Mantenimiento
    {
        string fotoPersona = "";
        public ActualizarPersona()
        {
            InitializeComponent();
        }

        private void ActualizarPersona_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("select * from tablaPersona");
            DataSet DS = Utilidades.Ejecutar(cmd);
            comboBox1.DataSource = DS.Tables[0];
            comboBox1.ValueMember = "nombrePersona";
        }

        private void ActualizarPersona_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'personaDataSet.tablaPersona' Puede moverla o quitarla según sea necesario.
            this.tablaPersonaTableAdapter.Fill(this.personaDataSet.tablaPersona);

        }
        
public override void Agregar()
{
//int idPersona = (tablaPersonaBindingSource7.CurrencyManager.Position + 1);
int idPersona = comboBox1.SelectedIndex + 1;
string nombrePersona = comboBox1.Text.Trim();
//double alturaPersona = Convert.ToDouble(txtAlturaPersona.Text);
decimal alturaPersona = Convert.ToDecimal(txtAlturaPersona.Text);
//double pesoPersona = Convert.ToDouble(txtPesoPersona.Text);
decimal pesoPersona = Convert.ToDecimal(txtPesoPersona.Text);
// LA ALTURA Y EL PESO TIENEN QUE IR CON . Y NO CON ,

string cmd = string.Format("EXEC actualizaPersona '{0}', '{1}', '{2}', '{3}', '{4}'", idPersona, nombrePersona, fotoPersona, alturaPersona, pesoPersona);
Utilidades.Ejecutar(cmd);
}

private void button1_Click_1(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
                fotoPersona = openFileDialog1.FileName;
                MessageBox.Show(fotoPersona);
        }
    }
    }
}
