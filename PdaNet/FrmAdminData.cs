using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PdaNet
{
    public partial class FrmAdminData : Form
    {
        private Form frmParent;
        private Chequeador chequeador;

        public FrmAdminData()
        {
            this.InitializeComponent();
        }

        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            this.lblEstado.Text = "Procesando . . .";
            base.Enabled = false;
            this.chequeador.crearBD();
            base.Enabled = true;
            this.lblEstado.Text = "";
        }

        private void btnInicializarConteo_Click(object sender, EventArgs e)
        {
            this.lblEstado.Text = "Procesando . . .";
            base.Enabled = false;
            this.chequeador.deleteAllProductoInventario();
            base.Enabled = true;
            this.lblEstado.Text = "";
        }

        private void btnLoadCodBarra_Click(object sender, EventArgs e)
        {
            this.lblEstado.Text = "Procesando . . .";
            base.Enabled = false;
            this.chequeador.crearProductoBarra();
            base.Enabled = true;
            this.lblEstado.Text = "";
        }

        private void btnLoadProducto_Click(object sender, EventArgs e)
        {
            this.lblEstado.Text = "Procesando . . .";
            base.Enabled = false;
            this.chequeador.crearProductos();
            base.Enabled = true;
            this.lblEstado.Text = "";
        }

        private void FrmAdminData_Load(object sender, EventArgs e)
        {
        }

        public void setChequeador(Chequeador chequeador)
        {
            this.chequeador = chequeador;
        }

        public void setFrmParent(Form frm)
        {
            this.frmParent = frm;
        }
    }
}