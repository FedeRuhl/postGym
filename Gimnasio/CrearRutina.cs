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
    public partial class CrearRutina : Form
    {
        public CrearRutina()
        {
            InitializeComponent();
            #region DataSet Ejercicios
            actualizarCheckedListEjercicios();
            #endregion

            #region DataSet Dias
            clbDias.DataSource = Dias.obtenerDias().Tables[0];
            clbDias.DisplayMember = "dia";
            clbDias.ValueMember = "dia";
            #endregion

            #region DataSet Musculos
            clbMusculos.DataSource = Musculos.obtenerMusculos().Tables[0];
            clbMusculos.DisplayMember = "musculo";
            clbMusculos.ValueMember = "musculo";
            #endregion


        }

        private void actualizarCheckedListEjercicios()
        {
            clbEjercicios.DataSource = Ejercicios.obtenerEjercicios().Tables[0];
            clbEjercicios.DisplayMember = "nombre";
            clbEjercicios.ValueMember = "nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbDias.SelectedItems.Count > 0
                    && clbEjercicios.SelectedItems.Count > 0
                    && clbMusculos.CheckedItems.Count > 0)
                {
                    int idRutina = Convert.ToInt32(Rutinas.insertarRutina());

                    PersistirDiasRutina(idRutina);
                    PersistirMusculosRutina(idRutina);
                    PersistirEjerciciosRutina(idRutina);

                    MessageBox.Show("La rutina se ha creado correctamente.");

                    LimpiarDatos();
                }
                else
                    MessageBox.Show("¡Acordate que primero tenés que seleccionar los días, músculos y ejercicios!");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PersistirDiasRutina(int idRutina)
        {
            foreach (DataRowView Dia in clbDias.CheckedItems)
                Rutinas.insertarDiaRutina(idRutina, Convert.ToInt32(Dia.Row["id"]));
        }

        private void PersistirMusculosRutina(int idRutina)
        {
            foreach (DataRowView Musculo in clbMusculos.CheckedItems)
                Rutinas.insertarMusculoRutina(Convert.ToInt32(Musculo.Row["id"]), idRutina);
        }

        private void PersistirEjerciciosRutina(int idRutina)
        {
            foreach (DataRowView Ejercicio in clbEjercicios.CheckedItems)
                Rutinas.insertarEjercicioRutina(Convert.ToInt32(Ejercicio.Row["id"]), idRutina);
        }

        private void LimpiarDatos()
        {
            for (int i = 0; i < clbDias.Items.Count; i++)
                clbDias.SetItemChecked(i, false);

            for (int i = 0; i < clbMusculos.Items.Count; i++)
                clbMusculos.SetItemChecked(i, false);

            for (int i = 0; i < clbEjercicios.Items.Count; i++)
                clbEjercicios.SetItemChecked(i, false);
        }

        private void tbFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            BindingSource bs = new BindingSource
            {
                DataSource = clbEjercicios.DataSource,
                Filter = "nombre like '%" + tbFiltro.Text + "%'"
            };
            clbEjercicios.DataSource = bs.DataSource;
        }

        private void CrearRutina_Enter(object sender, EventArgs e)
        {
            actualizarCheckedListEjercicios();
        }
    }
}