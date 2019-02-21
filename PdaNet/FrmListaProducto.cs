using System;

using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PdaNet
{
    public partial class FrmListaProducto : Form
    {
        private Chequeador chequeador;
        private ArrayList listaProductos;
        private Form frmParent;
        private bool abrirOtraVentana = false;

        public FrmListaProducto()
        {
            this.InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.gridProductos.DataSource = (this.buscarProductos(this.txtCodigo.Text));
            this.txtCodigo.Text = string.Empty;
            this.txtCodigo.Focus();
        }

        private DataTable buscarProductos(string codigo)
        {
            DataTable table = new DataTable("Productos");
            DataColumn column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "deProducto",
                AutoIncrement = false,
                Caption = "Producto",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "deUnidad",
                AutoIncrement = false,
                Caption = "Unidad",
                ReadOnly = false,
                Unique = false
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "deLaboratorio",
                AutoIncrement = false,
                Caption = "Laboratorio",
                ReadOnly = false,
                Unique = false
            };
            table.Columns.Add(column);
            if (codigo.Length > 2)
            {
                this.chequeador.setOrden(3);
                this.listaProductos = this.chequeador.obtenerLista(codigo);
                bool flag = this.listaProductos.Count <= 0;
                if (flag)
                {
                    MessageBox.Show("Producto no encontrado");
                }
                else
                {
                    IEnumerator enumerator = this.listaProductos.GetEnumerator();
                    try
                    {
                        while (true)
                        {
                            flag = enumerator.MoveNext();
                            if (!flag)
                            {
                                break;
                            }
                            ProductoLaboratorio current = (ProductoLaboratorio)enumerator.Current;
                            DataRow row = table.NewRow();
                            row["deProducto"] = current.getDeProducto();
                            row["deUnidad"] = current.getDeUnidad();
                            row["deLaboratorio"] = current.getDeLaboratorio();
                            table.Rows.Add(row);
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
            }
            else
            {
                MessageBox.Show("ingrese 3 caracteres");
                return table;
            }
            return table;
        }

        private void cerrarVentana()
        {
            base.Dispose(true);
        }

        private void grid_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(this.listaProductos, null))
            {
                DataGrid grid = (DataGrid)sender;
                ProductoLaboratorio producto = (ProductoLaboratorio)this.listaProductos[grid.CurrentRowIndex];
                this.chequeador.setFrmParent(this);
                this.chequeador.procesarProducto(producto);
            }
        }

        private void gridProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ReferenceEquals(this.listaProductos, null))
            {
                DataGrid grid = (DataGrid)sender;
                this.txtCodigo.Focus();
                if (grid.CurrentRowIndex != -1)
                {
                    ProductoLaboratorio producto = (ProductoLaboratorio)this.listaProductos[grid.CurrentRowIndex];
                    this.chequeador.setFrmParent(this);
                    this.chequeador.procesarProducto(producto);
                    this.abrirOtraVentana = true;
                }
            }
        }

        private void ListaProductos_Activated(object sender, EventArgs e)
        {
            this.txtCodigo.Focus();
        }

        private void ListaProductos_Deactivate(object sender, EventArgs e)
        {
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            this.txtCodigo.Text = string.Empty;
            this.txtCodigo.Focus();
        }

        private void Row_Changed(object ob, DataRowChangeEventArgs e)
        {
            DataTable table = (DataTable)ob;
        }

        public void setChequeador(Chequeador chequeador)
        {
            this.chequeador = chequeador;
        }

        public void setFrmParent(Form parent)
        {
            this.frmParent = parent;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.gridProductos.DataSource = this.buscarProductos(this.txtCodigo.Text);
                this.txtCodigo.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}