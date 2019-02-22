using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PdaNet
{
    public partial class FrmFormateo : Form
    {

        public FrmFormateo()
        {
            InitializeComponent();
        }

        private void btnFormatearPDA_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("¿Estás seguro de formatear los datos contados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.Yes)
            {
                Chequeador chequeador = new Chequeador();
                chequeador.deleteAllProductoInventario();
                base.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}