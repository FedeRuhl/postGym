using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;
namespace Gimnasio.Datos
{
    public static class Ejercicios
    {
        private static readonly String path = Application.StartupPath + "\\BD\\Gimnasio.db";
        private static readonly String con = $"Data Source={path};Version=3";
        //private static readonly SQLiteConnection conexion = new SQLiteConnection(con);
        public static DataSet obtenerEjercicios()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Select * from Ejercicios order by nombre";
                    using (DataSet DS = new DataSet())
                    {
                        SQLiteDataAdapter DP = new SQLiteDataAdapter(command);
                        DP.Fill(DS);
                        return DS;
                    }
                }
            }
        }

        public static void insertarEjercicio(String nombre)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "insert into Ejercicios (Nombre) values (@Nombre)";
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void actualizarEjercicio(int ejercicioID, string nombre)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "PRAGMA foreign_keys = ON; update Ejercicios set Nombre = @Nombre where ID = @EjercicioID";
                        command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void eliminarEjercicio(int ejercicioID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "PRAGMA foreign_keys = ON; delete from Ejercicios where id = @EjercicioID";
                    command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataSet obtenerEjerciciosSegunDia(int diaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Select ID, Ejercicio from VRutinaEjercicios where DiaID = @DiaID order by Ejercicio";
                    using (DataSet DS = new DataSet())
                    {
                        command.Parameters.AddWithValue("@DiaID", diaID);
                        SQLiteDataAdapter DP = new SQLiteDataAdapter(command);
                        DP.Fill(DS);
                        return DS;
                    }
                }
            }
        }
    }
}
