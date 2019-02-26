using System;
using System.Data.SqlServerCe;

using System.Data.SQLite;

namespace PdaNet
{
    public class Connection
    {
        private static SqlCeConnection instance;
        public static SQLiteConnection cn;

        public static SqlCeConnection getConnection()
        {
            try
            {
                string str = "Data Source =" + Configuracion.directorio + Configuracion.baseDatos;
                //string str = "Data Source = " + @"C:\eckerd.sdf";
                if (instance == null)
                {
                    instance = new SqlCeConnection(str);
                    instance.Open();
                }
                return instance;
            }
            catch (SqlCeException)
            {
            }
            return null;
        }

        public static SQLiteConnection getConexion()
        {
            try
            {
                string dataSource = "Data Source = " + Configuracion.directorio + Configuracion.baseDatos;
                if (cn == null)
                {
                    cn = new SQLiteConnection(dataSource);
                    cn.Open();
                }
                return cn;
            }
            catch (SQLiteException)
            {
            }
            return null;
        }

        public static void closeConexion()
        {
            cn.Dispose();
        }

    }
}
