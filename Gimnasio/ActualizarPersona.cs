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
        /*
public override void Agregar()
{
int indice = comboBox1.SelectedIndex;
string idPersona = tablaPersona.Tables[0].Rows[indice].ItemArray[0].ToString();
string nombrePersona = comboBox1.Text;
string fotoPersona = openFileDialog1.FileName;
string alturaPersona = txtAlturaPersona.Text.Trim();
string pesoPersona = txtPesoPersona.Text.Trim();


string cmd = string.Format("EXEC actualizaPersona '{0}', '{1}', '{2}', '{3}', '{4}'", idPersona, nombrePersona.Trim(), fotoPersona.Trim(), alturaPersona, pesoPersona);
Utilidades.Ejecutar(cmd);
}

private void Button1_Click(object sender, EventArgs e)
{
if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
//openFileDialog1.FileName   acá está la direccion de la foto
}
}*/
    }
}
