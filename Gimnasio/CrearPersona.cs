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
    public partial class CrearPersona : Mantenimiento
    {
        int number = 0;
        public CrearPersona()
        {
            InitializeComponent();
        }

        public override void Agregar()
        {
            try
            {
                if (txtIdPersona.Text != "" && txtNombrePersona.Text != "" && int.TryParse(txtIdPersona.Text, out number))
                {
                    string buscarId = "select * from tablaPersona where idPersona = '" + txtIdPersona.Text + "'";
                    DataSet DS = Utilidades.Ejecutar(buscarId);

                    if (DS.Tables[0].Rows.Count == 0)
                    {
                        string cmd = string.Format("EXEC crearPersona '{0}', '{1}'", txtIdPersona.Text.Trim(), txtNombrePersona.Text.Trim());
                        DataSet ds = Utilidades.Ejecutar(cmd);
                        MessageBox.Show("Se ha agregado correctamente");
                    }

                    else
                    {
                        string ultimoId = "select top 1 idPersona from tablaPersona order by idPersona DESC";
                        DS = Utilidades.Ejecutar(ultimoId);
                        int id = Convert.ToInt32(DS.Tables[0].Rows[0].ItemArray.First()) + 1;
                        MessageBox.Show("No se ha podido agregar debido a que el id ya existe. Intente con el número de id " + id.ToString());
                    }

                    txtIdPersona.Clear();
                    txtNombrePersona.Clear();
                }

                else
                {
                    MessageBox.Show("Ningún campo debe estar vacio. Además el identificador debe ser un número entero.");
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            if (txtIdPersona.Text != "" && txtNombrePersona.Text != "" && int.TryParse(txtIdPersona.Text, out number))
            {
                string cmd = string.Format("EXEC modificarPersona '{0}', '{1}'", txtIdPersona.Text.Trim(), txtNombrePersona.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha modificado correctamente");

                txtIdPersona.Clear();
                txtNombrePersona.Clear();
            }
            else
            {
                MessageBox.Show("Ningún campo debe estar vacio.");
            }
            
        }
    }
}
