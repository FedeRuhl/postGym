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
    public partial class Mantenimiento : Form
    {
        bool programaCargado = false;
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            cbEjercicioOPersona.SelectedIndex = 0;
            programaCargado = true;
        }

        private void cbEjercicioOPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmd = string.Format("select * from " + cbEjercicioOPersona.SelectedItem);
            DataSet ds = BD.Consultar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
            if (cbEjercicioOPersona.SelectedItem.ToString() == "Personas")
            {
                lAltura.Visible = true;
                tbAltura.Visible = true;
            }
            else
            {
                lAltura.Visible = false;
                tbAltura.Visible = false;
            }
            dataGridView1.Columns["Eliminar"].DisplayIndex = dataGridView1.Columns.Count - 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbEjercicioOPersona.SelectedItem.ToString() == "Personas")
                insertarPersona(tbNombre.Text, tbAltura.Text);
            else
                insertarEjercicio(tbNombre.Text);

            cbEjercicioOPersona_SelectedIndexChanged(sender, e); //recargar el datagridview
            tbNombre.Text = "";
            tbAltura.Text = "";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (programaCargado == true)
            {
                String id = dataGridView1["id", e.RowIndex].Value.ToString();
                String nombre = dataGridView1["nombre", e.RowIndex].Value.ToString();

                if (cbEjercicioOPersona.SelectedItem.ToString() == "Ejercicios")
                    actualizarEjercicio(id, nombre);
                else
                {
                    String altura = altura = dataGridView1["altura", e.RowIndex].Value.ToString();
                    actualizarPersona(id, nombre, altura);
                }
            }
            
            
        }

        private void insertarEjercicio(String nombre)
        {
            string cmd = string.Format("EXEC insertarEjercicio '{0}'", nombre);
            DataSet ds = BD.Consultar(cmd);
        }

        private void insertarPersona(String nombre, String altura)
        {
            string cmd = string.Format("EXEC insertarPersona '{0}', '{1}'", nombre, altura);
            DataSet ds = BD.Consultar(cmd);
        }

        private void actualizarEjercicio(String id, String nombre)
        {
            string cmd = string.Format("EXEC modificarEjercicio '{0}', '{1}'", id, nombre);
            DataSet ds = BD.Consultar(cmd);
        }

        private void actualizarPersona(String id, String nombre, String altura)
        {
            string cmd = string.Format("EXEC modificarPersona '{0}', '{1}', '{2}'", id, nombre, altura);
            DataSet ds = BD.Consultar(cmd);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int idFilaActual = dataGridView1.CurrentRow.Index;
                String id = dataGridView1["id", idFilaActual].Value.ToString();
                if (cbEjercicioOPersona.SelectedItem.ToString() == "Personas")
                    eliminarPersona(id);
                else
                    eliminarEjercicio(id);
                dataGridView1.Rows.RemoveAt(idFilaActual);
            }
        }

        private void eliminarPersona(String id)
        {
            String cmd = "delete from Personas where id = " + id;
            DataSet DS = BD.Consultar(cmd);
        }

        private void eliminarEjercicio(String id)
        {
            String cmd = "delete from Ejercicios where id = " + id;
            DataSet DS = BD.Consultar(cmd);
        }

        private void Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainClass MC = new MainClass();
            this.Hide();
            MC.Show();
        }
    }
}
