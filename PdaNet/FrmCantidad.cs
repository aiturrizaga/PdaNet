using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PdaNet
{
    public partial class FrmCantidad : Form
    {
        private Form frmParent;
        private ProductoLaboratorio producto;
        private Chequeador chequeador;
        FrmLectora frmLectora = new FrmLectora();
        public static string numero;

        public FrmCantidad()
        {
            this.InitializeComponent();
            this.pnlAnaquel.Visible = false;
            this.txtEntero.SelectAll();
            this.txtEntero.Focus();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int longTxtEntero;
            longTxtEntero = this.txtEntero.Text.Trim().Length;

            if (!this.txtFraccion.Enabled)
            {

                if (longTxtEntero > 2)
                {
                    DialogResult dialogresult = MessageBox.Show("Cantidad: " + this.txtEntero.Text.Trim() + "  Estas Seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

                    if (dialogresult == DialogResult.Yes)
                    {
                        this.guardarDatos();
                    }
                }
                else
                {
                    this.guardarDatos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnResetEntero_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("¿Estás seguro resetear la cantidad de enteros?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.Yes)
            {
                this.producto.setCaEntero(0);
                this.chequeador.guardar(this.producto);
                this.lblEnteroActual.Text = "0";
                this.txtEntero.Text = "0";
                this.txtEntero.SelectAll();
                this.txtEntero.Focus();
            }
        }

        private void btnResetFraccion_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("¿Estás seguro resetear la cantidad de fraccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.Yes)
            {
                this.producto.setCaFraccion(0);
                this.chequeador.guardar(this.producto);
                this.lblFraccionActual.Text = "0";
                this.txtFraccion.Text = "0";
                this.txtFraccion.SelectAll();
                this.txtFraccion.Focus();
            }
        }

        public void ejecutar()
        {
            this.lblCodigoValor.Text = this.producto.getCoProducto();
            this.lblDeProducto.Text = this.producto.getDeProducto();
            this.lblUnidadValue.Text = this.producto.getDeUnidad();
            this.lblUnidadFraccionValue.Text = this.producto.getDeUnidadFraccion();
            this.lblLaboratorioValue.Text = this.producto.getDeLaboratorio();
            this.lblEnteroActual.Text = this.producto.getCaEntero().ToString();
            this.lblFraccionActual.Text = this.producto.getCaFraccion().ToString();
            if (this.producto.getNuAnaquel() != null)
            {
                this.txtNunAnaquel.Text = this.producto.getNuAnaquel();
            }
            else
            {
                this.txtNunAnaquel.Text = this.chequeador.getNumAnaquel();
            }
            this.txtEntero.Text = "1";
            this.txtFraccion.Text = "0";
            this.txtEntero.SelectAll();
            if (this.producto.getInProdFraccionado().Equals("S"))
            {
                this.txtEntero.Text = "0";
                this.txtEntero.SelectAll();
                this.txtFraccion.Enabled = true;
                this.btnResetFraccion.Enabled = true;
            }
        }

        private void FrmCantidad_Load(object sender, EventArgs e)
        {
        }

        private void FrmCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                RPQuery rp = new RPQuery();
                string[] nuAnaquelConcat = rp.getNuAnaquelConcatInventario(this.producto).Split(',');
                this.lstAnaquel.DataSource = nuAnaquelConcat;

                this.lblAnaquel.Location = new System.Drawing.Point(8, 34);
                this.txtNunAnaquel.Location = new System.Drawing.Point(8, 60);
                this.lblAnaquel.BackColor = System.Drawing.Color.White;
                this.lblAnaquel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
                this.pnlAnaquel.Controls.Add(this.lblAnaquel);
                this.pnlAnaquel.Controls.Add(this.txtNunAnaquel);

                this.pnlAnaquel.Visible = true;
                this.pnlAnaquel.BringToFront();
            }
        }

        private void lstAnaquel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txtSelected = this.lstAnaquel.SelectedItem.ToString();
            this.txtNunAnaquel.Text = txtSelected;
        }

        public ProductoLaboratorio getProductoLaboratorio()
        {
            return this.producto;
        }

        private void guardarDatos()
        {
            if (!this.validarDatos())
            {
                MessageBox.Show("Valores incorrectos");
            }
            else if (int.Parse(this.txtFraccion.Text) >= this.producto.getVaFraccion() && this.producto.getVaFraccion() != 0)
            {
                MessageBox.Show("La U.Fracción debe ser menor que la fraccíón del producto");
            }
            else if (this.txtNunAnaquel.Text.Length != 0)
            {
                int caEntero = this.producto.getCaEntero() + int.Parse(this.txtEntero.Text);
                int caFraccion = 0;
                if (this.producto.getInProdFraccionado().Equals("S"))
                {
                    caFraccion = this.producto.getCaFraccion() + int.Parse(this.txtFraccion.Text);
                    this.producto.setCaFraccion(caFraccion);
                }
                this.producto.setCaEntero(caEntero);
                this.producto.setNuAnaquel(this.txtNunAnaquel.Text);
                this.chequeador.guardar(this.producto);
                base.Close();
            }
            else
            {
                MessageBox.Show("Ingrese el anaquel");
            }
        }

        public void setChequeador(Chequeador chequeador)
        {
            this.chequeador = chequeador;
        }

        public void setFrmParent(Form frmParent)
        {
            this.frmParent = frmParent;
        }

        public void setProductoLaboratorio(ProductoLaboratorio producto)
        {
            this.producto = producto;
        }

        /*
        private void txtEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            int longTxtEntero;

            if (e.KeyChar == '\r')
            {
                longTxtEntero = this.txtEntero.Text.Trim().Length;

                if (!this.txtFraccion.Enabled)
                {

                    if (longTxtEntero > 2)
                    {
                        DialogResult dialogresult = MessageBox.Show("Seguro de Ingresar Cantidad: " + this.txtEntero.Text.Trim(), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

                        if (dialogresult == DialogResult.Yes)
                        {
                            this.guardarDatos();
                        }
                    }
                    else
                    {
                        this.guardarDatos();
                    }
                }
                else
                {
                    this.txtFraccion.SelectAll();
                    this.txtFraccion.Focus();
                }
            } else
            // Validación para ingresar solo números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }*/
        /*
        private void txtFraccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.guardarDatos();
            } else
            // Validación para ingresar solo números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }*/

        /*
        private void txtNunAnaquel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.guardarDatos();
            } else
            // Validación para ingresar solo números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }*/

        private bool validarDatos()
        {
            bool flag;
            try
            {
                int num = 0;
                if (this.txtEntero.Text.Trim().Length != 0)
                {
                    num = int.Parse(this.txtEntero.Text);
                    if (this.producto.getInProdFraccionado().Equals("S"))
                    {
                        if (this.txtFraccion.Text.Trim().Length != 0)
                        {
                            num = int.Parse(this.txtFraccion.Text);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception exception1)
            {
                exception1.ToString();
                flag = false;
            }
            return flag;
        }

        private void btnCancelarAnaquel_Click(object sender, EventArgs e)
        {
            closePanelUpdate();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtNunAnaquel.Text.Length != 0)
            {
                this.producto.setNuAnaquel(this.txtNunAnaquel.Text);
                this.chequeador.updateAnaquelConcat(this.producto, this.lstAnaquel.GetItemText(this.lstAnaquel.SelectedItem));
                MessageBox.Show("Anaquel actualizado");
                closePanelUpdate();
            }
            else
            {
                MessageBox.Show("Ingrese el anaquel");
            }
        }

        public void closePanelUpdate()
        {
            this.pnlCabezera.Controls.Add(this.lblAnaquel);
            this.pnlCabezera.Controls.Add(this.txtNunAnaquel);

            this.txtNunAnaquel.Location = new System.Drawing.Point(248, 25);
            this.lblAnaquel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.lblAnaquel.ForeColor = System.Drawing.Color.White;
            this.lblAnaquel.Location = new System.Drawing.Point(248, 8);
            this.pnlAnaquel.Visible = false;
            this.pnlAnaquel.SendToBack();
        }

    }
}