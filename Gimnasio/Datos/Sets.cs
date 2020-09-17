using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Sets
    {
        private static readonly String path = Application.StartupPath + "\\BD\\Gimnasio.db";
        private static readonly String con = $"Data Source={path};Version=3";
        //private static readonly SQLiteConnection conexion = new SQLiteConnection(con);
        public static int obtenerSet(String fecha, int personaID)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "Select ID from Sets where PersonaID = @PersonaID and Fecha = @Fecha";
                        command.Parameters.AddWithValue("@PersonaID", personaID);
                        command.Parameters.AddWithValue("@Fecha", fecha);
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        return id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public static int insertarSet(String fecha, int personaID)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "insert into sets (fecha, personaID) values (@Fecha, @PersonaID); " +
                                                "select last_insert_rowid()";
                        command.Parameters.AddWithValue("@Fecha", fecha);
                        command.Parameters.AddWithValue("@PersonaID", personaID);
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        return id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public static Tuple<DateTime, DateTime> obtenerDiasSets()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "select min(Fecha) 'inicio', max(Fecha) 'fin' from Sets";
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            DateTime fechaFicticia = DateTime.Parse("1999/01/01");
                            Tuple<DateTime, DateTime> fechas = Tuple.Create(fechaFicticia, DateTime.Today);

                            if (reader.Read())
                            {
                                if (reader["inicio"] != DBNull.Value && reader["fin"] != DBNull.Value)
                                    fechas = Tuple.Create(Convert.ToDateTime(reader["inicio"]), Convert.ToDateTime(reader["fin"]));
                            }
                            conexion.Close();
                            return fechas;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void eliminarSet(int setID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "PRAGMA foreign_keys = ON; delete from Sets where id = @setID";
                    command.Parameters.AddWithValue("@setID", setID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
