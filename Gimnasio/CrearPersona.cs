using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaGimnasio;

namespace Gimnasio
{
    public partial class CrearPersona : Mantenimiento
    {
        public CrearPersona()
        {
            InitializeComponent();
        }

        public override void Agregar()
        {
            try
            {
                string buscarId = "select * from tablaPersona where idPersona = '" + txtIdPersona.Text +  "'";
                DataSet DS = Utilidades.Ejecutar(buscarId);

               if(DS.Tables[0].Rows.Count == 0)
                {
                    string cmd = string.Format("EXEC crearPersona {0}, {1}", txtIdPersona.Text.Trim(), txtNombrePersona.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha agregado correctamente");
                }

                else
                {
                    MessageBox.Show("No se ha podido agregar debido a que el id ya existe.");
                }
 
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("EXEC modificarPersona {0}, {1}", txtIdPersona.Text.Trim(), txtNombrePersona.Text.Trim());
            Utilidades.Ejecutar(cmd);
        }
    }
}
