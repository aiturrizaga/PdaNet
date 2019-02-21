using System;
using System.Drawing;
using System.Windows.Forms;

namespace PdaNet
{
    public partial class FrmLectora : Form
    {
        private Form frmParent;
        private Chequeador chequeador;
        public ProductoLaboratorio producto = new ProductoLaboratorio();

        public FrmLectora()
        {
            this.InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text == String.Empty)
            {
                MessageBox.Show("Ingrese el código del producto");
            }
            else
            {
                this.buscar();
            }
        }

        private void btnMaestro_Click(object sender, EventArgs e)
        {
            FrmListaProducto productos = new FrmListaProducto();
            productos.setChequeador(this.chequeador);
            productos.setFrmParent(this);
            productos.Show();
        }

        private void buscar()
        {
            int orden = -1;
            string anaquel;
            string codProd;
            char[] zero = { '0' };
            codProd = (this.txtCodigo.Text.Length != 6) ? this.txtCodigo.Text.TrimStart(zero) : this.txtCodigo.Text;
            orden = (this.txtCodigo.Text.Length != 6) ? 2 : 1;
            anaquel = this.txtNumAnaquel.Text;
            this.chequeador.setOrden(orden);
            this.chequeador.setNumAnaquel(anaquel);
            this.chequeador.setFrmParent(this);
            if (!this.chequeador.procesarProducto(codProd))
            {
                MessageBox.Show("Producto no encontrado");
            }
            else
            {
                this.txtCodigo.Text = string.Empty;
            }
        }

        private void cerrarVentana()
        {
            base.Dispose(true);
        }

        private void FrmLectora_Activated(object sender, EventArgs e)
        {
            this.txtCodigo.Focus();
            this.lblTotal.Text = this.chequeador.totalProductos().ToString();
        }

        private void FrmLectora_Deactivate(object sender, EventArgs e)
        {
            //this.txtCodigo.Focus();
        }

        private void FrmLectora_Load(object sender, EventArgs e)
        {
            this.txtCodigo.Text = string.Empty;
            this.txtCodigo.Focus();
            this.lblTotal.Text = this.chequeador.totalProductos().ToString();
        }

        private void lblProductos_ParentChanged(object sender, EventArgs e)
        {
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
                if (this.txtCodigo.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese el código del producto");
                }
                else
                {
                    this.buscar();
                }
            }
            else if (e.KeyChar == '\x0003')
            {
                this.Dispose(true);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}