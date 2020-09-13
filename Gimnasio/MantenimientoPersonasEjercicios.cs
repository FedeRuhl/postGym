using Gimnasio.Datos;
using Gimnasio.Utilidades;
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
    public partial class MantenimientoPersonasEjercicios : Form
    {
        bool programaCargado = false;
        public MantenimientoPersonasEjercicios()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            cbEjercicioOPersona.SelectedIndex = 0;
            programaCargado = true;
        }

        private void RecargarDataGridView()
        {
            if (ValidarComboBox.opcionValida(cbEjercicioOPersona, cbEjercicioOPersona.Text))
            {
                if (cbEjercicioOPersona.SelectedItem.ToString() == "Personas")
                {
                    dataGridView1.DataSource = Personas.obtenerPersonas().Tables[0];
                    lAltura.Visible = true;
                    tbAltura.Visible = true;
                }
                else
                {
                    dataGridView1.DataSource = Ejercicios.obtenerEjercicios().Tables[0];
                    lAltura.Visible = false;
                    tbAltura.Visible = false;
                }

                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["Eliminar"].DisplayIndex = dataGridView1.Columns.Count - 1;
            }
        }

        private void cbEjercicioOPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecargarDataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
            if (ValidarComboBox.opcionValida(cbEjercicioOPersona, cbEjercicioOPersona.Text)
                && !String.IsNullOrEmpty(nombre))
            {
                if (cbEjercicioOPersona.SelectedItem.ToString() == "Ejercicios")
                    Ejercicios.insertarEjercicio(nombre);
                else if (cbEjercicioOPersona.SelectedItem.ToString() == "Personas" && double.TryParse(tbAltura.Text, out double altura))
                    Personas.insertarPersona(nombre, altura);
                else
                    MessageBox.Show("¡Recordá que la altura tiene que ser un número!");
            }
            else
                MessageBox.Show("Recordá que el nombre no puede estar vacío. Además, solo se pueden seleccionar personas o ejercicios.");

            RecargarDataGridView();
            tbNombre.Text = "";
            tbAltura.Text = "";
        }

        

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (programaCargado == true)
            {
                int id = Convert.ToInt32(dataGridView1["id", e.RowIndex].Value);
                String nombre = dataGridView1["nombre", e.RowIndex].Value.ToString();

                if (cbEjercicioOPersona.SelectedItem.ToString() == "Ejercicios")
                    Ejercicios.actualizarEjercicio(id, nombre);
                else
                {
                    double altura = altura = Convert.ToDouble(dataGridView1["altura", e.RowIndex].Value);
                    Personas.actualizarPersona(id, nombre, altura);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int idFilaActual = dataGridView1.CurrentRow.Index;
                int id = Convert.ToInt32(dataGridView1["id", idFilaActual].Value);
                if (cbEjercicioOPersona.SelectedItem.ToString() == "Personas")
                    Personas.eliminarPersona(id);
                else
                    Ejercicios.eliminarEjercicio(id);
                dataGridView1.Rows.RemoveAt(idFilaActual);
            }
        }
    }
}
