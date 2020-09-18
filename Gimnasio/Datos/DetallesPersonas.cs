using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class DetallesPersonas
    {
        private static readonly String path = Application.StartupPath + "\\Gimnasio.db";
        private static readonly String con = $"Data Source={path};Version=3";
        //private static readonly SQLiteConnection conexion = new SQLiteConnection(con);
        public static int insertarDetallesPersona(double peso, String fecha, int personaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into DetallesPersonas (Peso, Fecha, PersonaID)" +
                                            " values (@Peso, @Fecha, @PersonaID); " +
                                            "select last_insert_rowid()";
                    command.Parameters.AddWithValue("@Peso", peso);
                    command.Parameters.AddWithValue("@Fecha", fecha);
                    command.Parameters.AddWithValue("@PersonaID", personaID);
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    return id;
                }
            }
        }

        public static void actualizarPesoPersona(int detallesID, double peso)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "PRAGMA foreign_keys = ON; update DetallesPersonas set Peso = @Peso where ID = @DetallesID";
                        command.Parameters.AddWithValue("@Peso", peso);
                        command.Parameters.AddWithValue("@DetallesID", detallesID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void eliminarDetallesPersona(int ID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "PRAGMA foreign_keys = ON; delete from DetallesPersonas where id = @ID";
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void insertarFoto(int detallesPersonaID, byte[] foto)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into Fotos (DetallesPersonaID, Foto) values (@DetallesPersonaID, @Foto)";
                    command.Parameters.AddWithValue("@DetallesPersonaID", detallesPersonaID);
                    command.Parameters.AddWithValue("@Foto", foto);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool eliminarFoto(int fotoID, int detallesPersonaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "delete from Fotos where ID = @FotoID; Select count(*) from Fotos where DetallesPersonaID = @DetallesPersonaID";
                    command.Parameters.AddWithValue("@FotoID", fotoID);
                    command.Parameters.AddWithValue("@DetallesPersonaID", detallesPersonaID);
                    int cantidadTuplasFotos = Convert.ToInt32(command.ExecuteScalar());
                    if (cantidadTuplasFotos == 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public static DataSet obtenerDetalles(String fecha)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Select * from VPersonas where Date(Fecha) = @Fecha";
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

        public static DataSet obtenerFechasDetalles()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Select Date(Fecha) fecha from DetallesPersonas group by Date(Fecha)";
                    using (DataSet DS = new DataSet())
                    {
                        SQLiteDataAdapter DP = new SQLiteDataAdapter(command);
                        DP.Fill(DS);
                        return DS;
                    }
                }
            }
        }
    }
}
