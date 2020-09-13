using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class DetallesPersonas
    {
        private static readonly String con = @"Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(con);
        public static int insertarDetallesPersona(double peso, String fecha, int personaID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into DetallesPersonas (Peso, Fecha, PersonaID)" +
                " values (@Peso, @Fecha, @PersonaID); " +
                "select SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@Peso", peso);
            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.AddWithValue("@PersonaID", personaID);
            int id = Convert.ToInt32(command.ExecuteScalar());
            conexion.Close();
            return id;
        }

        public static void actualizarPesoPersona(int detallesID, double peso)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "update DetallesPersonas set Peso = @Peso where ID = @DetallesID";
                command.Parameters.AddWithValue("@Peso", peso);
                command.Parameters.AddWithValue("@DetallesID", detallesID);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public static void eliminarDetallesPersona(int ID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "delete from DetallesPersonas where id = @ID";
            command.Parameters.AddWithValue("@ID", ID);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static void insertarFoto(int detallesPersonaID, byte[] foto)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into Fotos (DetallesPersonaID, Foto) values (@DetallesPersonaID, @Foto)";
            command.Parameters.AddWithValue("@DetallesPersonaID", detallesPersonaID);
            command.Parameters.AddWithValue("@Foto", foto);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static bool eliminarFoto(int fotoID, int detallesPersonaID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "delete from Fotos where ID = @FotoID; Select count(*) from Fotos where DetallesPersonaID = @DetallesPersonaID";
            command.Parameters.AddWithValue("@FotoID", fotoID);
            command.Parameters.AddWithValue("@DetallesPersonaID", detallesPersonaID);
            int cantidadTuplasFotos = Convert.ToInt32(command.ExecuteScalar());
            conexion.Close();

            if (cantidadTuplasFotos == 0)
                return true;
            else
                return false;
        }

        public static DataSet obtenerDetalles(String fecha)
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from VPersonas where Fecha = @Fecha";
            command.Connection = conexion;
            command.Parameters.AddWithValue("@Fecha", fecha);
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }

        public static DataSet obtenerFechasDetalles()
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select fecha from DetallesPersonas group by fecha";
            command.Connection = conexion;
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }
    }
}
