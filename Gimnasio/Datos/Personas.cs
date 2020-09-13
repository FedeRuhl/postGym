using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Personas
    {
        private static readonly String con = @"Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(con);
        public static DataSet obtenerPersonas()
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from Personas order by nombre";
            command.Connection = conexion;
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }

        public static void insertarPersona(String nombre, double altura)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "insert into Personas (Nombre, Altura) values (@Nombre, @Altura)";
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Altura", altura);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public static void actualizarPersona(int personaID, string nombre, double altura)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "Update Personas set Nombre = @Nombre, Altura = @Altura where id = @PersonaID";
                command.Parameters.AddWithValue("@PersonaID", personaID);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Altura", altura);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public static void eliminarPersona(int personaID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "delete from Personas where id = @PersonaID";
            command.Parameters.AddWithValue("@PersonaID", personaID);
            command.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
