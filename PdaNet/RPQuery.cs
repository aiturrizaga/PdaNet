using System;

using System.Collections;
using System.Data.SqlServerCe;
using System.Data.SQLite;
using System.Text;

namespace PdaNet
{
    public class RPQuery
    {
        public void crearBD()
        {
            SqlCeEngine engine = new SqlCeEngine("Data Source =" + Configuracion.directorio + Configuracion.baseDatos);
            engine.CreateDatabase();
            engine.Dispose();
            this.crearTablas();
        }

        private void crearTablas()
        {
            SqlCeCommand command = null;
            StringBuilder builder = new StringBuilder();
            builder.Append(" CREATE TABLE ");
            builder.Append(" ProductoBarra ");
            builder.Append(" ( CO_BARRA nvarchar(20)  PRIMARY KEY, ");
            builder.Append("   CO_PRODUCTO nchar(6) ");
            builder.Append("  ) ");
            command = Connection.getConnection().CreateCommand();
            command.CommandText = builder.ToString();
            command.ExecuteNonQuery();
            command.Dispose();
            builder = new StringBuilder();
            builder.Append(" CREATE TABLE ");
            builder.Append(" Producto ");
            builder.Append(" (CO_PRODUCTO nchar(6) PRIMARY KEY, ");
            builder.Append("  DE_PRODUCTO nvarchar(60),\t ");
            builder.Append("  DE_UNIDAD nvarchar(60), ");
            builder.Append("  DE_UNIDAD_FRACCION nvarchar(60), ");
            builder.Append("  IN_PROD_FRACCIONADO nchar(1), ");
            builder.Append("  VA_FRACCION int, ");
            builder.Append("  CO_LABORATORIO nchar(4), ");
            builder.Append("  DE_LABORATORIO nvarchar(60) ");
            builder.Append("  ) ");
            command = Connection.getConnection().CreateCommand();
            command.CommandText = builder.ToString();
            command.ExecuteNonQuery();
            command.Dispose();
            builder = new StringBuilder();
            builder.Append(" CREATE TABLE ");
            builder.Append(" ProductoInventario ");
            builder.Append(" (CO_PRODUCTO nchar(6) PRIMARY KEY, ");
            builder.Append("  CO_LABORATORIO nchar(4), ");
            builder.Append("  IN_PROD_FRACCIONADO nchar(1), ");
            builder.Append("  NU_ANAQUEL nvarchar(2), ");
            builder.Append("  VA_FRACCION int, ");
            builder.Append("  CA_ENTERO int, ");
            builder.Append("  CA_FRACCION int ");
            builder.Append("  ) ");
            command = Connection.getConnection().CreateCommand();
            command.CommandText = builder.ToString();
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void deleteAllProductoBarra()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" delete ");
            builder.Append(" productoBarra ");
            SqlCeCommand command = Connection.getConnection().CreateCommand();
            command.CommandText = builder.ToString();
            command.ExecuteNonQuery();
            command.Dispose();
            command = null;
        }

        // Refactorizado para SQLite
        public void deleteAllProductoInventario()
        {
            string sql = "DELETE FROM ProductoInventario";
            using (SQLiteTransaction sqlTransaction = Connection.getConexion().BeginTransaction())
            {
                SQLiteCommand command = new SQLiteCommand(sql, Connection.getConexion());
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
        }

        public void deleteAllProductos()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" delete ");
            builder.Append(" producto ");
            SqlCeCommand command = Connection.getConnection().CreateCommand();
            command.CommandText = builder.ToString();
            command.ExecuteNonQuery();
            command.Dispose();
            command = null;
        }

        // Refactorizado para SQLite
        public void getDatosProductoInventario(ProductoLaboratorio productoLaboratorio)
        {
            string sql = "SELECT ca_entero, ca_fraccion, nu_anaquel FROM ProductoInventario where co_producto='" + productoLaboratorio.getCoProducto() + "'";
            SQLiteCommand command = new SQLiteCommand(sql, Connection.getConexion());
            SQLiteDataReader reader = command.ExecuteReader();
            while (true)
            {
                if (!reader.Read())
                {
                    reader.Close();
                    reader = null;
                    command.Dispose();
                    command = null;
                    return;
                }
                productoLaboratorio.setCaEntero(reader.GetInt32(0));
                productoLaboratorio.setCaFraccion(reader.GetInt32(1));
                productoLaboratorio.setNuAnaquel((string)reader["nu_anaquel"]);
                productoLaboratorio.setNuevo(false);
            }
        }

        // Refactorizado para SQLite
        public ArrayList getProductos(string codigo, int tipo)
        {
            string sql;
            string body = "SELECT p.co_producto,p.de_producto,p.de_unidad,p.de_unidad_fraccion,p.in_prod_fraccionado,p.va_fraccion,p.co_laboratorio,p.de_laboratorio FROM ";
            string case1 = "Producto p WHERE p.co_producto='" + codigo + "' ";
            string case2 = "Producto p WHERE p.de_producto like '%" + codigo + "%' ";
            string case3 = "productoBarra b,  producto p  where  b.co_barra='" + codigo + "' and  p.co_producto=b.co_producto";

            if (tipo == 1)
            {
                sql = body + case1;
            }
            else if (tipo != 2)
            {
                sql = body + case2;
            }
            else
            {
                sql = body + case3;
            }

            SQLiteCommand command = new SQLiteCommand(sql, Connection.getConexion());
            SQLiteDataReader reader = command.ExecuteReader();
            ArrayList list = new ArrayList();
            while (true)
            {
                if (!reader.Read())
                {
                    reader.Close();
                    reader = null;
                    command.Dispose();
                    command = null;
                    return list;
                }
                ProductoLaboratorio laboratorio = new ProductoLaboratorio();
                laboratorio.setCoProducto((string)reader["co_producto"]);
                laboratorio.setDeProducto((string)reader["de_producto"]);
                laboratorio.setDeUnidad((string)reader["de_unidad"]);
                laboratorio.setDeUnidadFraccion((string)reader["de_unidad_fraccion"]);
                laboratorio.setVaFraccion(int.Parse(reader["va_fraccion"].ToString()));
                laboratorio.setCoLaboratorio((string)reader["co_laboratorio"]);
                laboratorio.setDeLaboratorio((string)reader["de_laboratorio"]);
                laboratorio.setInProdFraccionado((string)reader["in_prod_fraccionado"]);
                list.Add(laboratorio);
            }
        }

        // Refactorizado para SQLite
        public ArrayList getProductosInventariados()
        {
            string sql = "SELECT co_producto,co_laboratorio,in_prod_fraccionado,nu_anaquel,nu_anaquel_concat,va_fraccion,ca_entero,ca_fraccion FROM ProductoInventario";
            SQLiteCommand command = new SQLiteCommand(sql, Connection.getConexion());
            SQLiteDataReader reader = command.ExecuteReader();
            ArrayList list = new ArrayList();
            while (true)
            {
                if (!reader.Read())
                {
                    reader.Close();
                    reader = null;
                    command.Dispose();
                    command = null;
                    return list;
                }
                ProductoLaboratorio laboratorio = new ProductoLaboratorio();
                laboratorio.setCoProducto((string)reader["co_producto"]);
                laboratorio.setCoLaboratorio((string)reader["co_laboratorio"]);
                laboratorio.setInProdFraccionado((string)reader["in_prod_fraccionado"]);
                laboratorio.setNuAnaquel((string)reader["nu_anaquel"]);
                laboratorio.setNuAnaquelConcant((string)reader["nu_anaquel_concat"]);
                laboratorio.setVaFraccion(int.Parse(reader["va_fraccion"].ToString()));
                laboratorio.setCaEntero(int.Parse(reader["ca_entero"].ToString()));
                laboratorio.setCaFraccion(int.Parse(reader["ca_fraccion"].ToString()));
                list.Add(laboratorio);
            }
        }

        // Refactorizado para SQLite
        public int getTotalProductosInventariados()
        {
            string sql = "SELECT count(*) FROM ProductoInventario";
            SQLiteCommand command = new SQLiteCommand(sql, Connection.getConexion());
            SQLiteDataReader reader = command.ExecuteReader();
            int num = 0;
            try
            {
                while (true)
                {
                    if (!reader.Read())
                    {
                        reader.Close();
                        reader = null;
                        command.Dispose();
                        command = null;
                        break;
                    }
                    num = reader.GetInt32(0);
                }
            }
            catch (SQLiteException e)
            {
                throw e;
            }

            return num;
        }

        // Refactorizado para SQLite
        public void insertProductoInventario(ProductoLaboratorio producto)
        {
            string sql = "INSERT INTO ProductoInventario(CO_PRODUCTO, CO_LABORATORIO, IN_PROD_FRACCIONADO, NU_ANAQUEL, NU_ANAQUEL_CONCAT, VA_FRACCION, CA_ENTERO, CA_FRACCION) "
                + "VALUES('" + producto.getCoProducto() + "', '" + producto.getCoLaboratorio() + "', '" + producto.getInProdFraccionado() + "', '" + producto.getNuAnaquel() + "', '" + producto.getNuAnaquel() + "', " + producto.getVaFraccion() + ", " + producto.getCaEntero() + ", " + producto.getCaFraccion() + ")";
            using (SQLiteTransaction sqlTransaction = Connection.getConexion().BeginTransaction())
            {
                SQLiteCommand command = new SQLiteCommand(sql, Connection.getConexion());
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
        }

        // Refactorizado para SQLite
        public void updateProductoInventario(ProductoLaboratorio producto)
        {
            string sql = "UPDATE ProductoInventario SET "
                + "nu_anaquel= '" + producto.getNuAnaquel() + "', "
                + "nu_anaquel_concat= '" + producto.getNuAnaquelConcat() + "', "
                + "ca_entero=" + producto.getCaEntero() + ", "
                + "ca_fraccion=" + producto.getCaFraccion()
                + " WHERE co_producto='" + producto.getCoProducto() + "' ";
            using (SQLiteTransaction sqlTransaction = Connection.getConexion().BeginTransaction())
            {
                SQLiteCommand command = new SQLiteCommand(sql, Connection.getConexion());
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
        }

        public void updateAnaquelConcat(ProductoLaboratorio producto)
        {
            string sql = "UPDATE ProductoInventario SET "
                + "nu_anaquel_concat= '" + producto.getNuAnaquelConcat() + "' "
                + " WHERE co_producto='" + producto.getCoProducto() + "' ";
            using (SQLiteTransaction sqlTransaction = Connection.getConexion().BeginTransaction())
            {
                SQLiteCommand command = new SQLiteCommand(sql, Connection.getConexion());
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
        }

        public string getNuAnaquelConcatInventario(ProductoLaboratorio producto)
        {
            string sql = "SELECT nu_anaquel_concat FROM ProductoInventario WHERE co_producto = '" + producto.getCoProducto() + "'";
            SQLiteCommand command = new SQLiteCommand(sql, Connection.getConexion());
            SQLiteDataReader reader = command.ExecuteReader();
            String nuAnaquelConcat = "";
            try
            {
                while (true)
                {
                    if (!reader.Read())
                    {
                        reader.Close();
                        reader = null;
                        command.Dispose();
                        command = null;
                        break;
                    }
                    nuAnaquelConcat = reader.GetString(0);
                }
            }
            catch (SQLiteException e)
            {
                throw e;
            }

            //return nuAnaquelConcat;
            return nuAnaquelConcat;
        }
    }
}
