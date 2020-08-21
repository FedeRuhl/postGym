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
    public partial class MantenimientoEjercicio : Mantenimiento
    {
        int number = 0;
        public MantenimientoEjercicio()
        {
            InitializeComponent();
        }

        public void Agregar()
        {
            try
            {
                if (txtIdEjercicio.Text != "" && txtNombreEjercicio.Text != "" && int.TryParse(txtIdEjercicio.Text, out number))
                {
                    string buscarId = "select * from tablaEjercicio where idEjercicio = '" + txtIdEjercicio.Text + "'";
                    DataSet DS = Utilidades.Ejecutar(buscarId);

                    if (DS.Tables[0].Rows.Count == 0)
                    {
                        string cmd = string.Format("EXEC crearEjercicio '{0}', '{1}'", txtIdEjercicio.Text, txtNombreEjercicio.Text);
                        DataSet ds = Utilidades.Ejecutar(cmd);
                        MessageBox.Show("Se ha agregado correctamente");
                    }

                    else
                    {
                        string ultimoId = "select top 1 idEjercicio from tablaEjercicio order by idEjercicio DESC";
                        DS = Utilidades.Ejecutar(ultimoId);
                        int id = Convert.ToInt32(DS.Tables[0].Rows[0].ItemArray.First()) + 1;
                        MessageBox.Show("No se ha podido agregar debido a que el id ya existe. Intente con el número de id " + id.ToString());
                    }

                    txtIdEjercicio.Clear();
                    txtNombreEjercicio.Clear();
                    txtIdEjercicio.Focus();

                }

                else
                {
                    MessageBox.Show("Ningún campo debe estar vacio. Además el identificador debe ser un número entero.");
                }
            }
                
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        public void Modificar()
        {

            try
            {
                if (txtIdEjercicio.Text != "" && txtNombreEjercicio.Text != "" && int.TryParse(txtIdEjercicio.Text, out number))
                {
                    string buscarId = "select * from tablaEjercicio where idEjercicio = '" + txtIdEjercicio.Text + "'";
                    DataSet DS = Utilidades.Ejecutar(buscarId);

                    if (DS.Tables[0].Rows.Count == 1)
                    {
                        string cmd = string.Format("EXEC modificarEjercicio '{0}', '{1}'", txtIdEjercicio.Text, txtNombreEjercicio.Text);
                        DataSet ds = Utilidades.Ejecutar(cmd);
                        MessageBox.Show("Se ha modificado correctamente");
                    }

                    else
                    {
                        MessageBox.Show("No se ha podido modificar debido a que el id no existe.");
                    }

                    txtIdEjercicio.Clear();
                    txtNombreEjercicio.Clear();
                    txtIdEjercicio.Focus();

                }

                else
                {
                    MessageBox.Show("Ningún campo debe estar vacio. Además el identificador debe ser un número entero.");
                }
            }
                
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        public void Eliminar()
        {
            try
            {
                if (txtIdEjercicio.Text != "" && int.TryParse(txtIdEjercicio.Text, out number))
                {
                    string buscarId = "select * from tablaEjercicio where idEjercicio = '" + txtIdEjercicio.Text + "'";
                    DataSet DS = Utilidades.Ejecutar(buscarId);

                    if (DS.Tables[0].Rows.Count == 1)
                    {
                        string cmd = string.Format("EXEC eliminarEjercicio '{0}'", txtIdEjercicio.Text);
                        DataSet ds = Utilidades.Ejecutar(cmd);
                        MessageBox.Show("Se ha eliminado correctamente");
                    }

                    else
                    {
                        MessageBox.Show("No se ha podido eliminar debido a que el id no existe.");
                    }

                    txtIdEjercicio.Clear();
                    txtNombreEjercicio.Clear();
                    txtIdEjercicio.Focus();
                }

                else
                {
                    MessageBox.Show("El id no debe estar vacio. Además debe ser un número entero.");
                }
            }
                
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}
