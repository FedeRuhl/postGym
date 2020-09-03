using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gimnasio
{
    public static class BD
    {
        private static String con = @"Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True";
        private static SqlConnection conexion = new SqlConnection(con);
        public static DataSet Consultar(string consulta)
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(consulta, conexion);
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
            String consulta = "insert into rutinas default values select scope_identity ()";
            Consultar(consulta);
        }

        public static void insertarDiasRutina(String rutinaID, String DiaID)
        {
            String consulta = "insert into DiasRutina (rutinaID, DiaID) values (" + rutinaID
                + ", " + DiaID + ")";
            Consultar(consulta);
        }

        public static void insertarEjerciciosRutina(String rutinaID, String ejercicioID)
        {
            String consulta = "insert into EjerciciosRutina (rutinaID, ejercicioID) values" +
                " (" + rutinaID + ", " + ejercicioID + ")";
            Consultar(consulta);
        }
        public static void insertarMusculosRutina(String rutinaID, String musculoID)
        {
            String consulta = "insert into MusculosRutina (rutinaID, musculoID) values" +
                " (" + rutinaID + ", " + musculoID + ")";
            Consultar(consulta);
        }

    }
}
