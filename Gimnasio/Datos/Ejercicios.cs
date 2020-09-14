using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Gimnasio.Datos
{
    public static class Ejercicios
    {
        private static readonly String con = @"Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(con);
        public static DataSet obtenerEjercicios()
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from Ejercicios order by nombre";
            command.Connection = conexion;
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }

        public static void insertarEjercicio(String nombre)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "insert into Ejercicios (Nombre) values (@Nombre)";
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public static void actualizarEjercicio(int ejercicioID, string nombre)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "update Ejercicios set Nombre = @Nombre where ID = @EjercicioID";
                command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }

        public static void eliminarEjercicio(int ejercicioID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "delete from Ejercicios where id = @EjercicioID";
            command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static DataSet obtenerEjerciciosSegunDia(int diaID)
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select ID, Ejercicio from VRutinaEjercicios where DiaID = @DiaID order by Ejercicio";
            command.Parameters.AddWithValue("@DiaID", diaID);
            command.Connection = conexion;
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }
    }
}
