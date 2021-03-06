﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Dias
    {
        private static readonly String path = Application.StartupPath + "\\Gimnasio.db";
        private static readonly String con = $"Data Source={path};Version=3";
        //private static readonly SQLiteConnection conexion = new SQLiteConnection(con);

        public static DataSet obtenerDias()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Select * from Dias";
                    using (DataSet DS = new DataSet())
                    {
                        SQLiteDataAdapter DP = new SQLiteDataAdapter(command);
                        DP.Fill(DS);
                        conexion.Close();
                        return DS;
                    }
                }
            }
        }
    }
}
