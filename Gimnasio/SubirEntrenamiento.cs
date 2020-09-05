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
    public partial class SubirEntrenamiento : Form
    {
        private TextBoxPersonalizado textRepOSeg;
        private TextBoxPersonalizado textPeso;
        private int posicionY = 0;
        private bool textBoxIzquierda = false;
        public SubirEntrenamiento()
        {
            InitializeComponent();
        }

        private void SubirEntrenamiento_Load(object sender, EventArgs e)
        {
            string consulta = string.Format("select * from personas");
            DataSet ds = BD.Consultar(consulta);
            cbPersonas.DataSource = ds.Tables[0];
            cbPersonas.DisplayMember = "nombre";
            cbPersonas.ValueMember = "nombre";
            cbPersonas.SelectedIndex = 0;

            consulta = string.Format("select * from ejercicios");
            ds = BD.Consultar(consulta);
            cbEjercicios.DataSource = ds.Tables[0];
            cbEjercicios.DisplayMember = "nombre";
            cbEjercicios.ValueMember = "nombre";
            cbEjercicios.SelectedIndex = 0;

        }

        private void cbRepOseg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validar())
            {
                int cantidadSeries = Convert.ToInt32(tbCantidadSeries.Text);
                String textPlaceHolder = cbRepOseg.SelectedItem.ToString() == "Repeticiones" ? "Cantidad de repeticiones" : "Cantidad de segundos";

                for (int i = 0; i < cantidadSeries; i++)
                {
                    textRepOSeg = inicializarTextBox(textPlaceHolder);
                    textPeso = inicializarTextBox("Cantidad de peso (kg.)");

                    panelSubirRutina.Controls.Add(textRepOSeg);
                    panelSubirRutina.Controls.Add(textPeso);
                    posicionY += 25;
                }

                posicionarBotones();
            }
            else if (cbRepOseg.SelectedIndex == -1)
                return;
            else
                MessageBox.Show("Las series, las repeticiones y los segundos deben ser ingresados correctamente.");
    }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbCantidadSeries.Clear();
            cbRepOseg.SelectedIndex = -1;
            panelSubirRutina.Controls.Clear();
        }

        private void posicionarBotones()
        {
            panelSubirRutina.Controls.Add(panelBotones);
            btnGuardar.Visible = true;
            btnLimpiar.Visible = true;
        }

        private bool esEntero(String cadena)
        {
            return int.TryParse(cadena, out _);
        }

        private bool validar()
        {
            if (esEntero(tbCantidadSeries.Text)
                && !String.IsNullOrEmpty(cbRepOseg.SelectedItem.ToString()))
                return true;
            else
                return false;
        }

        private TextBoxPersonalizado inicializarTextBox(String placeHolder)
        {
            TextBoxPersonalizado txt = new TextBoxPersonalizado()
            {
                BackColor = Color.FromArgb(23, 21, 32),
                ForeColor = Color.White,
                Width = 150,
                Text = placeHolder,
                TextAlign = HorizontalAlignment.Center,
                Anchor = (AnchorStyles.Left | AnchorStyles.Right),
                Location = new Point(0, posicionY)
            };

            if (!textBoxIzquierda)
            {
                txt.Anchor = AnchorStyles.Left;
                textBoxIzquierda = true;
            }
            else
            {
                txt.Anchor = AnchorStyles.Right;
                textBoxIzquierda = false;
            }
                
            return txt;
        }
    }
}
