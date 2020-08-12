using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gimnasio
{
    public partial class ConsultasDetallesEjercicio : Consultas
    {
        public ConsultasDetallesEjercicio()
        {
            InitializeComponent();
        }

        public override void Buscar()
        {
            try
            {
                DataSet ds;
                DateTime fecha = DateTime.Parse(listBox1.Text);
                string fechaFormatoUniversal = Utilidades.convertirFormatoUniversal(fecha);
                string cmd = string.Format("EXEC traerEjercicioConFecha '{0}'", fechaFormatoUniversal);
                ds = Utilidades.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha prudocido el siguiente error: " + ex.Message);
            }
        }

        private void ConsultasDetallesEjercicio_Load(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("EXEC traerEjercicio");
                DataSet ds = Utilidades.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
                cmd = "select fecha from tablaDetallesEjercicio group by fecha";
                ds = Utilidades.Ejecutar(cmd);
                listBox1.DataSource = ds.Tables[0];

                dataGridView1.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                //this.unirEjercicioTableAdapter1.Fill(this.unirEjercicioDataSet1.unirEjercicio);
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido el siguiente error: " + error.Message);
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    int id = Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    string cmd = string.Format("EXEC eliminarDetallesEjercicio '{0}'", id);
                    DataSet DS = Utilidades.Ejecutar(cmd);
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String ColumnaModificada = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            String ValorCeldaModificada = dataGridView1.CurrentCell.Value.ToString();
            String TablaAModificar = "";
            String ClavePrimaria = "";
            switch (ColumnaModificada)
            {
                case "nombrePersona":
                    TablaAModificar = "tablaPersona";
                    ClavePrimaria = "idPersona";
                    break;
                case "nombreEjercicio":
                    TablaAModificar = "tablaEjercicio";
                    ClavePrimaria = "idEjercicio";
                    break;
                case "cantidadSeries":
                case "fecha":
                    TablaAModificar = "tablaDetallesEjercicio";
                    ClavePrimaria = "idDetalles";
                    break;
                case "Lista de pesos":
                    ColumnaModificada = "peso";
                    TablaAModificar = "tablaSerie";
                    ClavePrimaria = "idSerie";
                    break;
                case "Repeticiones":
                    ColumnaModificada = "cantidadRepeticiones";
                    TablaAModificar = "tablaSerie";
                    ClavePrimaria = "idSerie";
                    break;
                case "Segundos":
                    ColumnaModificada = "cantidadSegundos";
                    TablaAModificar = "tablaSerie";
                    ClavePrimaria = "idSerie";
                    break;
                default:
                    MessageBox.Show(ColumnaModificada + " no es un dato que se pueda modificar.");
                    this.Close();
                    break;
            }
            if (TablaAModificar != "")
            {
                int IndiceFila = dataGridView1.CurrentCell.RowIndex;
                String ValorClave = dataGridView1[ClavePrimaria, IndiceFila].Value.ToString();
                String Consulta = "Update " + TablaAModificar + " set " + ColumnaModificada + " = '" +
                ValorCeldaModificada + "' where " + ClavePrimaria + " = '" + ValorClave + "'";

                MessageBox.Show(Consulta);
                //DataSet ds = Utilidades.Ejecutar(Consulta);
            }
        }
    }
}
