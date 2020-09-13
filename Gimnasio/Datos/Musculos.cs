using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Musculos
    {
        private static readonly String con = @"Data Source=(local);Initial Catalog=Gimnasio;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(con);

        public static DataSet obtenerMusculos()
        {
            conexion.Open();
            DataSet DS = new DataSet();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from Musculos";
            command.Connection = conexion;
            SqlDataAdapter DP = new SqlDataAdapter(command);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }
    }
}
