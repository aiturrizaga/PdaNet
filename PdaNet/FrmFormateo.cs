using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PdaNet
{
    public partial class FrmFormateo : Form
    {

        public FrmFormateo()
        {
            InitializeComponent();
        }

        private void FrmFormateo_KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                DialogResult dialogresult = MessageBox.Show("¿Estás seguro de restablecer el PDA?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (dialogresult == DialogResult.Yes)
                {
                    // Borrar los archivos de configuración del PDA
                    Chequeador chequeador = new Chequeador();
                    if (chequeador.deleteConfigPda())
                    {
                        MessageBox.Show("PDA restablecido exitosamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        base.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo restablecer el PDA", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    base.Close();
                }
            }
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