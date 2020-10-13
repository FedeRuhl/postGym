using Gimnasio.Datos;
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
    public partial class ConsultaCondicionesFisicas : Form
    {
        private bool dataGridViewCargado = false;
        public ConsultaCondicionesFisicas()
        {
            InitializeComponent();
        }

        private void ConsultaCondicionesFisicas_Load(object sender, EventArgs e)
        {
            CargarListBoxFechas();
        }

        private void CargarListBoxFechas()
        {
            lbFechas.DataSource = DetallesPersonas.obtenerFechasDetalles().Tables[0];
            lbFechas.DisplayMember = "fecha";
            lbFechas.ValueMember = "fecha";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LLenarDataGridView();
            ReorganizarColumnas();
        }

        private void LLenarDataGridView()
        {
            if (lbFechas.SelectedValue != null)
            {
                DateTime fecha = Convert.ToDateTime(lbFechas.SelectedValue.ToString());
                String fechaFormatoUniversal = Fecha.convertirFormatoUniversal(fecha);
                dgbCondicionesFisicas.DataSource = DetallesPersonas.obtenerDetalles(fechaFormatoUniversal).Tables[0];
                dataGridViewCargado = true;
            }
        }

        private void ConsultaCondicionesFisicas_Enter(object sender, EventArgs e)
        {
            CargarListBoxFechas();
        }

        private void ReorganizarColumnas()
        {
            if (lbFechas.Items.Count > 0)
            {
                dgbCondicionesFisicas.Columns["Eliminar"].DisplayIndex = dgbCondicionesFisicas.Columns.Count - 1;
                dgbCondicionesFisicas.Columns["PersonaID"].Visible = false;
                dgbCondicionesFisicas.Columns["ID"].Visible = false;
                dgbCondicionesFisicas.Columns["Fecha"].Visible = false;
                dgbCondicionesFisicas.Columns["FotoID"].Visible = false;

                //dgbCondicionesFisicas.RowTemplate.Height = 50; seteado desde el form evita errores

                DataGridViewImageColumn columnaImagen = (DataGridViewImageColumn)dgbCondicionesFisicas.Columns["Foto"];
                columnaImagen.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }           
        }

        private void dgbCondicionesFisicas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewCargado)
            {
                if (dgbCondicionesFisicas.Columns[e.ColumnIndex].Name == "Foto")
                {
                    dgbCondicionesFisicas.Cursor = new Cursor(Application.StartupPath + "\\cursor\\zoom.cur");
                }
                else
                    dgbCondicionesFisicas.Cursor = Cursors.Default;
            }
        }

        private void dgbCondicionesFisicas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbCondicionesFisicas.Columns[e.ColumnIndex].Name == "Foto")
            {
                Byte[] foto = (Byte[])dgbCondicionesFisicas[e.ColumnIndex, e.RowIndex].Value;
                MostrarFotos MF = new MostrarFotos(foto);
                MF.Show();
            }
        }

        private void dgbCondicionesFisicas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbCondicionesFisicas.Rows.Count > 0
                && dgbCondicionesFisicas.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                String pregunta = "¿Segurísimo que querés borrar ese avance personal? ";
                if (MessageBox.Show(pregunta, "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    int idFilaActual = dgbCondicionesFisicas.CurrentRow.Index;
                    int fotoID = Convert.ToInt32(dgbCondicionesFisicas.Rows[idFilaActual].Cells["fotoID"].Value);
                    int detallesID = Convert.ToInt32(dgbCondicionesFisicas.Rows[e.RowIndex].Cells["ID"].Value);

                    bool ultimaFotoEliminada = DetallesPersonas.eliminarFoto(fotoID, detallesID);
                    if (ultimaFotoEliminada)
                    {
                        DetallesPersonas.eliminarDetallesPersona(detallesID);
                        CargarListBoxFechas();
                    }
                    dgbCondicionesFisicas.Rows.RemoveAt(idFilaActual);
                }
            }
        }

        private void dgbCondicionesFisicas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCargado)
            {
                if (dgbCondicionesFisicas.Columns[e.ColumnIndex].Name == "Peso")
                {
                    int detallesID = Convert.ToInt32(dgbCondicionesFisicas.Rows[e.RowIndex].Cells["ID"].Value);
                    double peso = Convert.ToDouble(dgbCondicionesFisicas.Rows[e.RowIndex].Cells["PESO"].Value);
                    DetallesPersonas.actualizarPesoPersona(detallesID, peso);

                    LLenarDataGridView();
                }
                else
                    MessageBox.Show("El único valor que puede modificarse desde acá es" +
                        " el peso. Si desea modificar el nombre o la altura, puede dirigirse" +
                        " a la sección de datos básicos");
            }
        }
    }
}
