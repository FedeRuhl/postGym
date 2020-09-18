using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Gimnasio.Datos
{
    public static class Rutinas
    {
        private static readonly String path = Application.StartupPath + "\\Gimnasio.db";
        private static readonly String con = $"Data Source={path};Version=3";
        //private static readonly SQLiteConnection conexion = new SQLiteConnection(con);

        public static int insertarRutina()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into rutinas default values; select last_insert_rowid()";
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    return id;
                }
            }
        }

        public static void insertarDiaRutina(int rutinaID, int DiaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "insert into DiasRutina (RutinaID, DiaID) values (@RutinaID, @DiaID)";
                    command.Parameters.AddWithValue("@RutinaID", rutinaID);
                    command.Parameters.AddWithValue("@DiaID", DiaID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void insertarMusculoRutina(int musculoID, int rutinaID)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "insert into MusculosRutina (RutinaID, MusculoID) values (@RutinaID, @MusculoID)";
                        command.Parameters.AddWithValue("@RutinaID", rutinaID);
                        command.Parameters.AddWithValue("@MusculoID", musculoID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Es probable que el músculo que intentas agregar, ya forma parte de la rutina");
            }
        }

        public static void insertarEjercicioRutina(int ejercicioID, int rutinaID)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(con))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "insert into EjerciciosRutina (RutinaID, EjercicioID) values (@RutinaID, @EjercicioID)";
                        command.Parameters.AddWithValue("@RutinaID", rutinaID);
                        command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Es probable que el ejercicio que intentas agregar, ya forma parte de la rutina");
            }
        }

        public static DataSet obtenerEjerciciosUnionMusculos(int diaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                /*command.CommandText = "Select VRutinaEjercicios.rutinaID from VRutinaEjercicios " +
                                    "where DiaID = @DiaID union " +
                                    "select VRutinaMusculos.rutinaID from VRutinaMusculos " +
                                    "where DiaID = @DiaID";*/
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Select rutinaID from DiasRutina where DiaID = @DiaID";
                    using (DataSet DS = new DataSet())
                    {
                        command.Parameters.AddWithValue("@DiaID", diaID);
                        SQLiteDataAdapter DP = new SQLiteDataAdapter(command);
                        DP.Fill(DS);
                        return DS;
                    }
                }
            }
        }

        public static DataSet obtenerRutinaMusculos(int rutinaID, int diaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select Musculo, ID from VRutinaMusculos where RutinaID = @RutinaID and DiaID = @DiaID";
                    using (DataSet DS = new DataSet())
                    {
                        command.Parameters.AddWithValue("@RutinaID", rutinaID);
                        command.Parameters.AddWithValue("@DiaID", diaID);
                        SQLiteDataAdapter DP = new SQLiteDataAdapter(command);
                        DP.Fill(DS);
                        return DS;
                    }
                }
            }
        }

        public static DataSet obtenerRutinaEjercicios(int rutinaID, int diaID)
        {
            //capaz abria que sacar el order by en esta consulta
            //  order by Ejercicio
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "select Ejercicio, ID from VRutinaEjercicios where RutinaID = @RutinaID and DiaID = @DiaID";
                    using (DataSet DS = new DataSet())
                    {
                        command.Parameters.AddWithValue("@RutinaID", rutinaID);
                        command.Parameters.AddWithValue("@DiaID", diaID);
                        SQLiteDataAdapter DP = new SQLiteDataAdapter(command);
                        DP.Fill(DS);
                        return DS;
                    }
                }
            }
        }

        public static void eliminarMusculoRutina(int musculoID, int rutinaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "delete from MusculosRutina where RutinaID = @RutinaID and MusculoID = @MusculoID";
                    command.Parameters.AddWithValue("@RutinaID", rutinaID);
                    command.Parameters.AddWithValue("@MusculoID", musculoID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void eliminarEjercicioRutina(int ejercicioID, int rutinaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "delete from EjerciciosRutina where RutinaID = @RutinaID and EjercicioID = @EjercicioID";
                    command.Parameters.AddWithValue("@RutinaID", rutinaID);
                    command.Parameters.AddWithValue("@EjercicioID", ejercicioID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void eliminarRutina(int rutinaID)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(con))
            {
                conexion.Open();
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "PRAGMA foreign_keys = ON; delete from Rutinas where id = @RutinaID";
                    command.Parameters.AddWithValue("@RutinaID", rutinaID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
