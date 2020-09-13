using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Series
    {
        private static readonly String con = @"Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(con);
        public static void insertarSerieRepeticiones(int setID, int ejercicioID, int repeticiones, double peso)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into series (SetID, EjercicioID, Repeticiones, Peso) " +
                                    "values (@SetID, @EjercicioID, @Repeticiones, @Peso)";
            command.Parameters.AddWithValue("@SetID", setID);
            command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
            command.Parameters.AddWithValue("@Repeticiones", repeticiones);
            command.Parameters.AddWithValue("@Peso", peso);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static void insertarSerieSegundos(int setID, int ejercicioID, int segundos, double peso)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into series (SetID, EjercicioID, Segundos, Peso) " +
                                    "values (@SetID, @EjercicioID, @Segundos, @Peso)";
            command.Parameters.AddWithValue("@SetID", setID);
            command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
            command.Parameters.AddWithValue("@Segundos", segundos);
            command.Parameters.AddWithValue("@Peso", peso);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static DataSet obtenerEntrenamientos(String fecha)
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from VEntrenamientos where Fecha = @Fecha";
            command.Connection = conexion;
            command.Parameters.AddWithValue("@Fecha", fecha);
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }

        public static void eliminarSerie(int serieID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "delete from Series where id = @SerieID";
            command.Parameters.AddWithValue("@SerieID", serieID);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static void actualizarPesoSerie(double peso, int serieID)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "update Series set Peso = @Peso where ID = @SerieID";
                command.Parameters.AddWithValue("@Peso", peso);
                command.Parameters.AddWithValue("@SerieID", serieID);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public static void actualizarSegundosSerie(int segundos, int serieID)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "update Series set Segundos = @Segundos where ID = @SerieID";
                command.Parameters.AddWithValue("@Segundos", segundos);
                command.Parameters.AddWithValue("@SerieID", serieID);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public static void actualizarRepeticionesSerie(int repeticiones, int serieID)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "update Series set Repeticiones = @Repeticiones where ID = @SerieID";
                command.Parameters.AddWithValue("@Repeticiones", repeticiones);
                command.Parameters.AddWithValue("@SerieID", serieID);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
    }
}
