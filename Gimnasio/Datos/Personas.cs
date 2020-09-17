using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Personas
    {
        private static readonly String path = Application.StartupPath + "\\BD\\Gimnasio.db";
        private static readonly String con = $"Data Source={path};Version=3";
        //private static readonly SQLiteConnection conexion = new SQLiteConnection(con);
        public static DataSet obtenerPersonas()
        {

            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Select * from Personas order by nombre";
                    using (DataSet DS = new DataSet())
                    {
                        SQLiteDataAdapter DP = new SQLiteDataAdapter(command);
                        DP.Fill(DS);
                        return DS;
                    }
                }
            }
        }

        public static void insertarPersona(String nombre, double altura)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "insert into Personas (Nombre, Altura) values (@Nombre, @Altura)";
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Altura", altura);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void actualizarPersona(int personaID, string nombre, double altura)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "PRAGMA foreign_keys = ON; Update Personas set Nombre = @Nombre, Altura = @Altura where id = @PersonaID";
                        command.Parameters.AddWithValue("@PersonaID", personaID);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Altura", altura);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void eliminarPersona(int personaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "PRAGMA foreign_keys = ON; delete from Personas where id = @PersonaID";
                    command.Parameters.AddWithValue("@PersonaID", personaID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
