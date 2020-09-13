using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Sets
    {
        private static readonly String con = @"Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(con);
        public static int obtenerSet(String fecha, int personaID)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "Select ID from Sets where PersonaID = @PersonaID and Fecha = @Fecha";
                command.Parameters.AddWithValue("@PersonaID", personaID);
                command.Parameters.AddWithValue("@Fecha", fecha);
                int id = Convert.ToInt32(command.ExecuteScalar());
                conexion.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return 0;
            }
        }

        public static int insertarSet(String fecha, int personaID)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "insert into sets (fecha, personaID) values (@Fecha, @PersonaID); " +
                                        "select SCOPE_IDENTITY()";
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@PersonaID", personaID);
                int id = Convert.ToInt32(command.ExecuteScalar());
                conexion.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return 0;
            }
        }

        public static Tuple<DateTime, DateTime> obtenerDiasSets()
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "select min(Fecha) 'inicio', max(Fecha) 'fin' from Sets";
                SqlDataReader reader = command.ExecuteReader();

                Tuple<DateTime, DateTime> fechas = null;

                if (reader.Read())
                {
                    fechas = Tuple.Create(Convert.ToDateTime(reader["inicio"]), Convert.ToDateTime(reader["fin"]));
                    conexion.Close();
                }
                else
                {
                    fechas = Tuple.Create(DateTime.Now, DateTime.Now);
                    conexion.Close();
                }
                return fechas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return null;
            }
        }

        public static void eliminarSet(int setID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "delete from Sets where id = @setID";
            command.Parameters.AddWithValue("@setID", setID);
            command.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
