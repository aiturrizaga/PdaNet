namespace PdaNet
{
    partial class FrmCantidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblDeProducto = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblUnidadValue = new System.Windows.Forms.Label();
            this.lblUnidadFraccion = new System.Windows.Forms.Label();
            this.lblUnidadFraccionValue = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblLaboratorioValue = new System.Windows.Forms.Label();
            this.btnResetEntero = new System.Windows.Forms.Button();
            this.btnResetFraccion = new System.Windows.Forms.Button();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.txtFraccion = new System.Windows.Forms.TextBox();
            this.lblFraccionActual = new System.Windows.Forms.Label();
            this.lblCodigoValor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEnteroActual = new System.Windows.Forms.Label();
            this.lblAnaquel = new System.Windows.Forms.Label();
            this.txtNunAnaquel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(8, 243);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 40);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(187, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.Blue;
            this.lblProducto.Location = new System.Drawing.Point(8, 14);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(79, 20);
            this.lblProducto.Text = "Producto:";
            // 
            // lblDeProducto
            // 
            this.lblDeProducto.Location = new System.Drawing.Point(78, 13);
            this.lblDeProducto.Name = "lblDeProducto";
            this.lblDeProducto.Size = new System.Drawing.Size(224, 40);
            this.lblDeProducto.Text = "Plidan Tab. 10 Unidades";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnidad.ForeColor = System.Drawing.Color.Blue;
            this.lblUnidad.Location = new System.Drawing.Point(8, 115);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(79, 16);
            this.lblUnidad.Text = "U. Entero:";
            // 
            // lblUnidadValue
            // 
            this.lblUnidadValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblUnidadValue.Location = new System.Drawing.Point(93, 114);
            this.lblUnidadValue.Name = "lblUnidadValue";
            this.lblUnidadValue.Size = new System.Drawing.Size(131, 16);
            this.lblUnidadValue.Text = "10";
            // 
            // lblUnidadFraccion
            // 
            this.lblUnidadFraccion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnidadFraccion.ForeColor = System.Drawing.Color.Blue;
            this.lblUnidadFraccion.Location = new System.Drawing.Point(8, 171);
            this.lblUnidadFraccion.Name = "lblUnidadFraccion";
            this.lblUnidadFraccion.Size = new System.Drawing.Size(92, 19);
            this.lblUnidadFraccion.Text = "U.Fracción:";
            // 
            // lblUnidadFraccionValue
            // 
            this.lblUnidadFraccionValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblUnidadFraccionValue.Location = new System.Drawing.Point(96, 169);
            this.lblUnidadFraccionValue.Name = "lblUnidadFraccionValue";
            this.lblUnidadFraccionValue.Size = new System.Drawing.Size(107, 16);
            this.lblUnidadFraccionValue.Text = "0";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLaboratorio.ForeColor = System.Drawing.Color.Blue;
            this.lblLaboratorio.Location = new System.Drawing.Point(8, 77);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(92, 16);
            this.lblLaboratorio.Text = "Lab:";
            // 
            // lblLaboratorioValue
            // 
            this.lblLaboratorioValue.Location = new System.Drawing.Point(63, 77);
            this.lblLaboratorioValue.Name = "lblLaboratorioValue";
            this.lblLaboratorioValue.Size = new System.Drawing.Size(171, 38);
            this.lblLaboratorioValue.Text = "Farmindustria";
            // 
            // btnResetEntero
            // 
            this.btnResetEntero.Location = new System.Drawing.Point(235, 135);
            this.btnResetEntero.Name = "btnResetEntero";
            this.btnResetEntero.Size = new System.Drawing.Size(72, 32);
            this.btnResetEntero.TabIndex = 7;
            this.btnResetEntero.Text = "Reset";
            this.btnResetEntero.Click += new System.EventHandler(this.btnResetEntero_Click);
            // 
            // btnResetFraccion
            // 
            this.btnResetFraccion.Enabled = false;
            this.btnResetFraccion.Location = new System.Drawing.Point(235, 192);
            this.btnResetFraccion.Name = "btnResetFraccion";
            this.btnResetFraccion.Size = new System.Drawing.Size(72, 31);
            this.btnResetFraccion.TabIndex = 6;
            this.btnResetFraccion.Text = "Reset";
            this.btnResetFraccion.Click += new System.EventHandler(this.btnResetFraccion_Click);
            // 
            // txtEntero
            // 
            this.txtEntero.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.txtEntero.Location = new System.Drawing.Point(8, 134);
            this.txtEntero.MaxLength = 0;
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(92, 32);
            this.txtEntero.TabIndex = 5;
            this.txtEntero.Text = "15000";
            this.txtEntero.WordWrap = false;
            this.txtEntero.MaxLength = 7;
            this.txtEntero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero_KeyPress);
            // 
            // txtFraccion
            // 
            this.txtFraccion.Enabled = false;
            this.txtFraccion.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.txtFraccion.Location = new System.Drawing.Point(8, 191);
            this.txtFraccion.MaxLength = 0;
            this.txtFraccion.Name = "txtFraccion";
            this.txtFraccion.Size = new System.Drawing.Size(92, 32);
            this.txtFraccion.TabIndex = 4;
            this.txtFraccion.Text = "15000";
            this.txtFraccion.WordWrap = false;
            this.txtFraccion.MaxLength = 7;
            this.txtFraccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFraccion_KeyPress);
            // 
            // lblFraccionActual
            // 
            this.lblFraccionActual.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblFraccionActual.Location = new System.Drawing.Point(128, 204);
            this.lblFraccionActual.Name = "lblFraccionActual";
            this.lblFraccionActual.Size = new System.Drawing.Size(72, 16);
            this.lblFraccionActual.Text = "15000";
            this.lblFraccionActual.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCodigoValor
            // 
            this.lblCodigoValor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblCodigoValor.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoValor.Location = new System.Drawing.Point(60, 53);
            this.lblCodigoValor.Name = "lblCodigoValor";
            this.lblCodigoValor.Size = new System.Drawing.Size(173, 16);
            this.lblCodigoValor.Text = "104039";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.Color.Blue;
            this.lblCodigo.Location = new System.Drawing.Point(8, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 19);
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblEnteroActual
            // 
            this.lblEnteroActual.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblEnteroActual.Location = new System.Drawing.Point(128, 148);
            this.lblEnteroActual.Name = "lblEnteroActual";
            this.lblEnteroActual.Size = new System.Drawing.Size(72, 16);
            this.lblEnteroActual.Text = "15000";
            this.lblEnteroActual.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnaquel
            // 
            this.lblAnaquel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnaquel.ForeColor = System.Drawing.Color.Blue;
            this.lblAnaquel.Location = new System.Drawing.Point(235, 59);
            this.lblAnaquel.Name = "lblAnaquel";
            this.lblAnaquel.Size = new System.Drawing.Size(82, 20);
            this.lblAnaquel.Text = "Anaquel:";
            // 
            // txtNunAnaquel
            // 
            this.txtNunAnaquel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.txtNunAnaquel.Location = new System.Drawing.Point(241, 85);
            this.txtNunAnaquel.Name = "txtNunAnaquel";
            this.txtNunAnaquel.Size = new System.Drawing.Size(62, 32);
            this.txtNunAnaquel.TabIndex = 18;
            this.txtNunAnaquel.MaxLength = 3;
            this.txtNunAnaquel.Text = "1";
            this.txtNunAnaquel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNunAnaquel_KeyPress);
            // 
            // FrmCantidad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 314);
            this.Controls.Add(this.txtNunAnaquel);
            this.Controls.Add(this.lblAnaquel);
            this.Controls.Add(this.lblEnteroActual);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCodigoValor);
            this.Controls.Add(this.lblFraccionActual);
            this.Controls.Add(this.txtFraccion);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.btnResetFraccion);
            this.Controls.Add(this.btnResetEntero);
            this.Controls.Add(this.lblLaboratorioValue);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblUnidadFraccionValue);
            this.Controls.Add(this.lblUnidadFraccion);
            this.Controls.Add(this.lblUnidadValue);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblDeProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCantidad";
            this.Text = "Registrar inventario";
            this.Load += new System.EventHandler(this.FrmCantidad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblDeProducto;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblUnidadValue;
        private System.Windows.Forms.Label lblUnidadFraccion;
        private System.Windows.Forms.Label lblUnidadFraccionValue;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label lblLaboratorioValue;
        private System.Windows.Forms.Button btnResetEntero;
        private System.Windows.Forms.Button btnResetFraccion;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.TextBox txtFraccion;
        private System.Windows.Forms.Label lblFraccionActual;
        private System.Windows.Forms.Label lblCodigoValor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEnteroActual;
        private System.Windows.Forms.Label lblAnaquel;
        public System.Windows.Forms.TextBox txtNunAnaquel;
    }
}