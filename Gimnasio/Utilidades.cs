using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gimnasio
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            string dificil = @"Data Source=DESKTOP-TG5SMR3\SQLEXPRESS;Initial Catalog=Gimnasio;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(dificil);
            conexion.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, conexion);
            DP.Fill(DS);
            conexion.Close();
            return DS;
        }
    }
}
