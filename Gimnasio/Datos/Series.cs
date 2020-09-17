using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Series
    {
        private static readonly String path = Application.StartupPath + "\\BD\\Gimnasio.db";
        private static readonly String con = $"Data Source={path};Version=3";
        //private static readonly SQLiteConnection conexion = new SQLiteConnection(con);
        public static void insertarSerieRepeticiones(int setID, int ejercicioID, int repeticiones, double peso)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into series (SetID, EjercicioID, Repeticiones, Peso) " +
                                            "values (@SetID, @EjercicioID, @Repeticiones, @Peso)";
                    command.Parameters.AddWithValue("@SetID", setID);
                    command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                    command.Parameters.AddWithValue("@Repeticiones", repeticiones);
                    command.Parameters.AddWithValue("@Peso", peso);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void insertarSerieSegundos(int setID, int ejercicioID, int segundos, double peso)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into series (SetID, EjercicioID, Segundos, Peso) " +
                                    "values (@SetID, @EjercicioID, @Segundos, @Peso)";
                    command.Parameters.AddWithValue("@SetID", setID);
                    command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                    command.Parameters.AddWithValue("@Segundos", segundos);
                    command.Parameters.AddWithValue("@Peso", peso);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataSet obtenerEntrenamientos(String fecha)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Select * from VEntrenamientos where Date(Fecha) = @Fecha";
                    using (DataSet DS = new DataSet())
                    {
                        command.Parameters.AddWithValue("@Fecha", fecha);
                        SQLiteDataAdapter DP = new SQLiteDataAdapter(command);
                        DP.Fill(DS);
                        return DS;
                    }
                }
            }
        }

        public static void eliminarSerie(int serieID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "delete from Series where id = @SerieID";
                    command.Parameters.AddWithValue("@SerieID", serieID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void actualizarPesoSerie(double peso, int serieID)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "update Series set Peso = @Peso where ID = @SerieID";
                        command.Parameters.AddWithValue("@Peso", peso);
                        command.Parameters.AddWithValue("@SerieID", serieID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void actualizarSegundosSerie(int segundos, int serieID)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "update Series set Segundos = @Segundos where ID = @SerieID";
                        command.Parameters.AddWithValue("@Segundos", segundos);
                        command.Parameters.AddWithValue("@SerieID", serieID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void actualizarRepeticionesSerie(int repeticiones, int serieID)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "update Series set Repeticiones = @Repeticiones where ID = @SerieID";
                        command.Parameters.AddWithValue("@Repeticiones", repeticiones);
                        command.Parameters.AddWithValue("@SerieID", serieID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
