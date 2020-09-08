using Gimnasio.Modelos;
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
            string cmd = string.Format("select * from ejercicios");
            DataSet ds = BD.Consultar(cmd);
            clbEjercicios.DataSource = ds.Tables[0];
            clbEjercicios.DisplayMember = "nombre";
            clbEjercicios.ValueMember = "nombre";
            #endregion

            #region DataSet Dias
            cmd = string.Format("select * from dias");
            ds = BD.Consultar(cmd);
            clbDias.DataSource = ds.Tables[0];
            clbDias.DisplayMember = "dia";
            clbDias.ValueMember = "dia";
            #endregion

            #region DataSet Musculos
            cmd = string.Format("select * from musculos");
            ds = BD.Consultar(cmd);
            clbMusculos.DataSource = ds.Tables[0];
            clbMusculos.DisplayMember = "musculo";
            clbMusculos.ValueMember = "musculo";
            #endregion


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BD.insertarRutina();
                int idRutina = Convert.ToInt32(BD.ObtenerPrimeraCoincidencia("select id from rutinas order by id desc"));

                PersistirDiasRutina(idRutina);
                PersistirMusculosRutina(idRutina);
                PersistirEjerciciosRutina(idRutina);

                MessageBox.Show("La rutina se ha creado correctamente.");

                LimpiarDatos();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PersistirDiasRutina(int idRutina)
        {
            foreach (DataRowView Dia in clbDias.CheckedItems)
                BD.insertarDiaRutina(idRutina, Convert.ToInt32(Dia.Row["id"]));
        }

        private void PersistirMusculosRutina(int idRutina)
        {
            foreach (DataRowView Musculo in clbMusculos.CheckedItems)
                BD.insertarMusculoRutina(Convert.ToInt32(Musculo.Row["id"]), idRutina);
        }

        private void PersistirEjerciciosRutina(int idRutina)
        {
            foreach (DataRowView Ejercicio in clbEjercicios.CheckedItems)
                BD.insertarEjercicioRutina(Convert.ToInt32(Ejercicio.Row["id"]), idRutina);
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
    }
}