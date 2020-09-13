using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Rutinas
    {
        private static readonly String con = @"Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(con);

        public static int insertarRutina()
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into rutinas default values select scope_identity ()";
            int id = Convert.ToInt32(command.ExecuteScalar());
            conexion.Close();
            return id;
        }

        public static void insertarDiaRutina(int rutinaID, int DiaID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into DiasRutina (RutinaID, DiaID) values (@RutinaID, @DiaID)";
            command.Parameters.AddWithValue("@RutinaID", rutinaID);
            command.Parameters.AddWithValue("@DiaID", DiaID);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static void insertarMusculoRutina(int musculoID, int rutinaID)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "insert into MusculosRutina (RutinaID, MusculoID) values (@RutinaID, @MusculoID)";
                command.Parameters.AddWithValue("@RutinaID", rutinaID);
                command.Parameters.AddWithValue("@MusculoID", musculoID);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Es probable que el músculo que intentas agregar, ya forma parte de la rutina");
                conexion.Close();
            }
        }

        public static void insertarEjercicioRutina(int ejercicioID, int rutinaID)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "insert into EjerciciosRutina (RutinaID, EjercicioID) values (@RutinaID, @EjercicioID)";
                command.Parameters.AddWithValue("@RutinaID", rutinaID);
                command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Es probable que el ejercicio que intentas agregar, ya forma parte de la rutina");
                conexion.Close();
            }
        }

        public static DataSet obtenerEjerciciosUnionMusculos(int diaID)
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select VRutinaEjercicios.rutinaID from VRutinaEjercicios " +
                                    "where DiaID = @DiaID union " +
                                    "select VRutinaMusculos.rutinaID from VRutinaMusculos " +
                                    "where DiaID = @DiaID";
            command.Parameters.AddWithValue("@DiaID", diaID);
            command.Connection = conexion;
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }

        public static DataSet obtenerRutinaMusculos(int rutinaID, int diaID)
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select Musculo, ID from VRutinaMusculos where RutinaID = @RutinaID and DiaID = @DiaID";
            command.Parameters.AddWithValue("@RutinaID", rutinaID);
            command.Parameters.AddWithValue("@DiaID", diaID);
            command.Connection = conexion;
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }

        public static DataSet obtenerRutinaEjercicios(int rutinaID, int diaID)
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select Ejercicio, ID from VRutinaEjercicios where RutinaID = @RutinaID and DiaID = @DiaID";
            command.Parameters.AddWithValue("@RutinaID", rutinaID);
            command.Parameters.AddWithValue("@DiaID", diaID);
            command.Connection = conexion;
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }

        public static void eliminarMusculoRutina(int musculoID, int rutinaID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "delete from MusculosRutina where RutinaID = @RutinaID and MusculoID = @MusculoID";
            command.Parameters.AddWithValue("@RutinaID", rutinaID);
            command.Parameters.AddWithValue("@MusculoID", musculoID);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static void eliminarEjercicioRutina(int ejercicioID, int rutinaID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "delete from EjerciciosRutina where RutinaID = @RutinaID and EjercicioID = @EjercicioID";
            command.Parameters.AddWithValue("@RutinaID", rutinaID);
            command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static void eliminarRutina(int rutinaID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "delete from Rutinas where id = @RutinaID";
            command.Parameters.AddWithValue("@RutinaID", rutinaID);
            command.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
