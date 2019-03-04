using System;

using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace PdaNet
{
    public class Chequeador
    {
        private RPQuery rp = new RPQuery();
        private int orden;
        private Form frmParent;
        public string anaquel;

        public void crearBD()
        {
            try
            {
                if (this.existeBD())
                {
                    MessageBox.Show("Ya se importaron los datos.");
                }
                else
                {
                    this.rp.crearBD();
                    MessageBox.Show("Proceso correcto.");
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }

        public void crearProductoBarra()
        {
            try
            {
                if (!this.existeBD())
                {
                    MessageBox.Show("BD no existe.");
                }
                else
                {
                    this.rp.deleteAllProductoBarra();
                    new ResultsExtractor().getProductoBarra();
                    MessageBox.Show("Proceso correcto.");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("productoBarra.txt no encontrado");
            }
        }

        public void crearProductos()
        {
            try
            {
                if (!this.existeBD())
                {
                    MessageBox.Show("BD no existe.");
                }
                else
                {
                    this.rp.deleteAllProductos();
                    new ResultsExtractor().getProductos();
                    MessageBox.Show("Proceso correcto.");
                }
            }
            catch (FileNotFoundException exception1)
            {
                exception1.ToString();
                MessageBox.Show("producto.txt no encontrado");
            }
        }

        public void formatearBD()
        {
            try
            {
                if (!this.existeBD())
                {
                    //MessageBox.Show("BD. no existe", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    //File.Delete(@"\My Documents\eckerd.s3db");
                    File.Copy(@"\My Documents\eckerd_bk.s3db", Configuracion.directorio + Configuracion.baseDatos, true);
                }
                else
                {
                    this.rp.deleteAllProductoInventario();
                    MessageBox.Show("Formateo exitoso", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al formatear", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        public void deleteAllProductoInventario()
        {
            try
            {

                if (!this.validaBDexist())
                {
                    Connection.cn = null;
                    //MessageBox.Show("BD. no existe", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    File.Copy(@"\My Documents\eckerd_bk.s3db", Configuracion.directorio + Configuracion.baseDatos, true);
                    File.Delete(@"\My Documents\productoInventario.txt");
                    MessageBox.Show("Formateo exitoso", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    this.rp.deleteAllProductoInventario();
                    MessageBox.Show("Formateo exitoso", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al formatear", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        public bool validaBDexist()
        {
            bool flag = true;
            if (File.Exists(Configuracion.directorio + Configuracion.baseDatos))
            //if (File.Exists(@"C:\eckerd.sdf"))
            {
                flag = true;
            }
            else
            {
                flag = false;

            }
            return flag;
        }

        public bool checkFilePdaNameExist()
        {
            bool flag = true;
            if (File.Exists(Configuracion.directorio + Configuracion.filePdaName))
            {
                flag = true;
            }
            else
            {
                flag = false;

            }
            return flag;
        }

        public bool validaArchivoDifExist()
        {
            bool flag = true;
            if (File.Exists(Configuracion.directorio + Configuracion.archDiferencias))
            {
                flag = true;
            }
            else
            {
                flag = false;

            }
            return flag;
        }

        public bool existeBD()
        {
            bool flag;
            if (File.Exists(Configuracion.directorio + Configuracion.baseDatos))
            {
                flag = true;
            }
            else
            {
                try
                {
                    File.Move(@"\My Documents\eckerd.s3db", Configuracion.directorio + Configuracion.baseDatos);
                    //File.Move(@"C:\eckerd.sdf", @"C:\eckerd.sdf");
                    flag = File.Exists(Configuracion.directorio + Configuracion.baseDatos);
                    //flag = File.Exists(@"C:\eckerd.sdf");
                }
                catch
                {
                    flag = false;
                    return flag;
                }

            }
            return flag;
        }

        public void exportar()
        {
            try
            {
                ArrayList list = this.rp.getProductosInventariados();
                TextWriter writer = new StreamWriter(@"\My Documents\productoInventario.txt");
                bool flag = list.Count <= 0;
                if (!flag)
                {
                    IEnumerator enumerator = list.GetEnumerator();
                    try
                    {
                        while (true)
                        {
                            flag = enumerator.MoveNext();
                            if (!flag)
                            {
                                break;
                            }
                            writer.WriteLine(((ProductoLaboratorio)enumerator.Current).inventario());
                        }
                    }
                    finally
                    {
                        IDisposable objA = enumerator as IDisposable;
                        if (!ReferenceEquals(objA, null))
                        {
                            objA.Dispose();
                        }
                    }
                }
                writer.Close();
                Connection.closeConexion();
                Connection.cn = null;
                File.Delete(@"\My Documents\eckerd.s3db");
                MessageBox.Show("Proceso Finalizado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("No existe archivo por cargar", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        public string getUserNameFromFile()
        {
            string userName = "";
            try
            {
                TextReader reader = new StreamReader(@"\My Documents\PdaUser.txt");
                userName = reader.ReadLine();
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            return "(" + userName + ")";
        }

        public bool deleteConfigPda()
        {
            bool flag = false;
            try
            {
                if (Connection.getConexion() != null)
                {
                    Connection.closeConexion();
                    Connection.cn = null;
                }
                if (File.Exists(Configuracion.directorio + Configuracion.baseDatos))
                {
                    File.Delete(Configuracion.directorio + Configuracion.baseDatos);
                }
                if (File.Exists(Configuracion.directorio + "eckerd_bk.s3db"))
                {
                    File.Delete(Configuracion.directorio + "eckerd_bk.s3db");
                }
                if (File.Exists(Configuracion.directorio + Configuracion.filePdaName))
                {
                    File.Delete(Configuracion.directorio + Configuracion.filePdaName);
                }
                if (File.Exists(Configuracion.directorio + Configuracion.archDiferencias))
                {
                    File.Delete(Configuracion.directorio + Configuracion.archDiferencias);
                }
                flag = true;
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public void guardar(ProductoLaboratorio producto)
        {
            try
            {
                if (producto.isNuevo())
                {
                    this.rp.insertProductoInventario(producto);
                }
                else
                {
                    // Validación para concatenar anaqueles sin que se repita un anaquel que ya existe
                    string[] nuAnaquelConcat = this.rp.getNuAnaquelConcatInventario(producto).Split(',');
                    if (nuAnaquelConcat != null)
                    {
                        for (int i = 0; i < nuAnaquelConcat.Length; i++)
                        {
                            if (nuAnaquelConcat.GetValue(i).Equals(producto.getNuAnaquel()))
                            {
                                producto.setNuAnaquelConcant(string.Join(",", nuAnaquelConcat));
                                break;
                            }
                            else
                            {
                                producto.setNuAnaquelConcant(string.Join(",", nuAnaquelConcat) + "," + producto.getNuAnaquel());
                            }
                        }
                    }
                    else
                    {
                        producto.setNuAnaquelConcant(producto.getNuAnaquel());
                    }
                    this.rp.updateProductoInventario(producto);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar Productos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                Console.WriteLine("Error: " + e);
            }
        }

        public void updateAnaquelConcat(ProductoLaboratorio producto, string oldAnaquel)
        {
            try
            {
                string[] nuAnaquelConcat = this.rp.getNuAnaquelConcatInventario(producto).Split(',');

                if (nuAnaquelConcat != null)
                {
                    for (int i = 0; i < nuAnaquelConcat.Length; i++)
                    {
                        if (nuAnaquelConcat.GetValue(i).Equals(producto.getNuAnaquel()))
                        {
                            string anaquel = string.Join(",", nuAnaquelConcat);
                            anaquel = anaquel.Replace(nuAnaquelConcat.Length == 1 ? oldAnaquel : oldAnaquel + ",", "");
                            producto.setNuAnaquelConcant(anaquel);
                            break;
                        }
                        else
                        {
                            string anaquel = string.Join(",", nuAnaquelConcat);
                            anaquel = anaquel.Replace(oldAnaquel, producto.getNuAnaquel());
                            producto.setNuAnaquelConcant(anaquel);
                        }
                    }
                }
                else
                {
                    producto.setNuAnaquelConcant(producto.getNuAnaquel());
                }
                this.rp.updateProductoInventario(producto);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar el anaquel", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                Console.WriteLine("Error: " + e);
            }
        }

        public void importar()
        {
        }

        public ArrayList obtenerLista(string codigo)
        {
            return this.rp.getProductos(codigo, this.orden);
        }

        public void procesarProducto(ProductoLaboratorio producto)
        {
            this.rp.getDatosProductoInventario(producto);
            FrmCantidad cantidad = new FrmCantidad();
            cantidad.setProductoLaboratorio(producto);
            cantidad.setChequeador(this);
            cantidad.setFrmParent(this.frmParent);
            cantidad.ejecutar();
            cantidad.Show();
        }

        public bool procesarProducto(string codigo)
        {
            ArrayList list = this.rp.getProductos(codigo, this.orden);
            if (list.Count <= 0)
            {
                return false;
            }
            else
            {
                IEnumerator enumerator = list.GetEnumerator();
                try
                {
                    if (enumerator.MoveNext())
                    {
                        ProductoLaboratorio current = (ProductoLaboratorio)enumerator.Current;
                        this.rp.getDatosProductoInventario(current);
                        FrmCantidad cantidad = new FrmCantidad();
                        cantidad.setProductoLaboratorio(current);
                        cantidad.setChequeador(this);
                        cantidad.setFrmParent(this.frmParent);
                        cantidad.ejecutar();
                        cantidad.Show();
                    }
                }
                finally
                {
                    IDisposable objA = enumerator as IDisposable;
                    if (!ReferenceEquals(objA, null))
                    {
                        objA.Dispose();
                    }
                }
            }
            return true;
        }

        public void setFrmParent(Form parent)
        {
            this.frmParent = parent;
        }

        public void setOrden(int orden)
        {
            this.orden = orden;
        }

        public void setNumAnaquel(string anaquel)
        {
            this.anaquel = anaquel;
        }

        public string getNumAnaquel()
        {
            return this.anaquel;
        }

        public int totalProductos()
        {
            int num = 0;
            try
            {
                num = this.rp.getTotalProductosInventariados();
            }
            catch (Exception exception1)
            {
                throw exception1;
            }
            return num;
        }
    }
}
