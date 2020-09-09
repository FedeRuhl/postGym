using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Gimnasio
{
    public static class BD
    {
        private static readonly String con = @"Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(con);
        public static DataSet Consultar(string consulta)
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }

        public static object ObtenerPrimeraCoincidencia(string consulta)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand(consulta, conexion);
            object valor = command.ExecuteScalar();
            conexion.Close();

            return valor;
        }
        public static void insertarRutina()
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into rutinas default values select scope_identity ()";
            command.ExecuteNonQuery();
            conexion.Close();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                return 0;
            }
            
        }

        public static void insertarSerieRepeticiones(int setID, int ejercicioID, int repeticiones, float peso)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into series (SetID, EjercicioID, Repeticiones, Peso) " +
                                    "values (@SetID, @EjercicioID, @Repeticiones, @Peso)";
            command.Parameters.AddWithValue("@SetID", setID);
            command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
            command.Parameters.AddWithValue("@Repeticiones", repeticiones);
            command.Parameters.AddWithValue("@Peso", peso);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static void insertarSerieSegundos(int setID, int ejercicioID, int segundos, float peso)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into series (SetID, EjercicioID, Segundos, Peso) " +
                                    "values (@SetID, @EjercicioID, @Segundos, @Peso)";
            command.Parameters.AddWithValue("@SetID", setID);
            command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
            command.Parameters.AddWithValue("@Segundos", segundos);
            command.Parameters.AddWithValue("@Peso", peso);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public static void insertarDetallesPersona(float peso, String fecha, int personaID)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexion;
            command.CommandText = "insert into DetallesPersonas (Peso, Fecha, PersonaID)" +
                " values (@Peso, @Fecha, @PersonaID)";
            command.Parameters.AddWithValue("@Peso", peso);
            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.AddWithValue("@PersonaID", personaID);
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
    }
}
