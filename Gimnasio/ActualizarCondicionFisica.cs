﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class ActualizarCondicionFisica : Form
    {
        private List<Image> fotosPersona = new List<Image>();
        public ActualizarCondicionFisica()
        {
            InitializeComponent();

            string consulta = string.Format("select * from personas");
            DataSet ds = BD.Consultar(consulta);
            cbPersonas.DataSource = ds.Tables[0];
            cbPersonas.DisplayMember = "nombre";
            cbPersonas.ValueMember = "nombre";
            cbPersonas.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (String direccionFoto in openFileDialog1.FileNames)
                        fotosPersona.Add(Image.FromFile(direccionFoto));

                    lCheck.Location = new Point(btnSeleccionar.Location.X + btnSeleccionar.Width + 10, btnSeleccionar.Location.Y);
                    lCheck.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar la foto. " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region Inicializacion variables
            String fecha = Fecha.convertirFormatoUniversal(dtpActualizacion.Value);
            DataRowView Persona = (DataRowView)cbPersonas.Items[cbPersonas.SelectedIndex];
            int personaID = Convert.ToInt32(Persona.Row["id"]);
            #endregion
            if (float.TryParse(tbPeso.Text, out float peso) && fotosPersona.Count != 0)
            {
                BD.insertarDetallesPersona(peso, fecha, personaID);
                int DetallesPersonaID = Convert.ToInt32(BD.ObtenerPrimeraCoincidencia($"select id from DetallesPersonas where PersonaId = {personaID} order by id desc"));

                foreach (Image Foto in fotosPersona)
                {
                    byte[] fotoPersona = ConversorImagenes.ConvertirImagenBytes(Foto);
                    BD.insertarFoto(DetallesPersonaID, fotoPersona);
                }

                MessageBox.Show("¡Los cambios han sigo guardados correctamente!");
                limpiarForm();
        }
            else
            {
                MessageBox.Show("¡Recorda que debes seleccionar al menos una foto, y que el peso debe ser numérico!");
            }
        }

        private void limpiarForm()
        {
            tbPeso.Text = "";
            lCheck.Visible = false;
            openFileDialog1.FileName = "";
            fotosPersona.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void ActualizarCondicionFisica_Load(object sender, EventArgs e)
        {
            dtpActualizacion.Value = DateTime.Now;
            dtpActualizacion.MaxDate = DateTime.Now;
        }
    }
}
