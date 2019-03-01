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
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCabezera = new System.Windows.Forms.Panel();
            this.pnlAnaquel = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelarAnaquel = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lstAnaquel = new System.Windows.Forms.ListBox();
            this.pnlCabezera.SuspendLayout();
            this.pnlAnaquel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Location = new System.Drawing.Point(8, 250);
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
            this.btnCancelar.Location = new System.Drawing.Point(187, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(8, 70);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(74, 20);
            this.lblProducto.Text = "Producto:";
            // 
            // lblDeProducto
            // 
            this.lblDeProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.lblDeProducto.ForeColor = System.Drawing.Color.White;
            this.lblDeProducto.Location = new System.Drawing.Point(78, 71);
            this.lblDeProducto.Name = "lblDeProducto";
            this.lblDeProducto.Size = new System.Drawing.Size(225, 32);
            this.lblDeProducto.Text = "Plidan Tab. 10 Unidades";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.lblUnidad.Location = new System.Drawing.Point(8, 117);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(74, 17);
            this.lblUnidad.Text = "U. Entero:";
            // 
            // lblUnidadValue
            // 
            this.lblUnidadValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblUnidadValue.Location = new System.Drawing.Point(88, 117);
            this.lblUnidadValue.Name = "lblUnidadValue";
            this.lblUnidadValue.Size = new System.Drawing.Size(94, 49);
            this.lblUnidadValue.Text = "10";
            // 
            // lblUnidadFraccion
            // 
            this.lblUnidadFraccion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnidadFraccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.lblUnidadFraccion.Location = new System.Drawing.Point(8, 181);
            this.lblUnidadFraccion.Name = "lblUnidadFraccion";
            this.lblUnidadFraccion.Size = new System.Drawing.Size(82, 19);
            this.lblUnidadFraccion.Text = "U.Fracción:";
            // 
            // lblUnidadFraccionValue
            // 
            this.lblUnidadFraccionValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblUnidadFraccionValue.Location = new System.Drawing.Point(88, 181);
            this.lblUnidadFraccionValue.Name = "lblUnidadFraccionValue";
            this.lblUnidadFraccionValue.Size = new System.Drawing.Size(94, 52);
            this.lblUnidadFraccionValue.Text = "0";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblLaboratorio.ForeColor = System.Drawing.Color.White;
            this.lblLaboratorio.Location = new System.Drawing.Point(8, 33);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(43, 21);
            this.lblLaboratorio.Text = "Lab:";
            // 
            // lblLaboratorioValue
            // 
            this.lblLaboratorioValue.ForeColor = System.Drawing.Color.White;
            this.lblLaboratorioValue.Location = new System.Drawing.Point(42, 33);
            this.lblLaboratorioValue.Name = "lblLaboratorioValue";
            this.lblLaboratorioValue.Size = new System.Drawing.Size(200, 38);
            this.lblLaboratorioValue.Text = "Farmindustria";
            // 
            // btnResetEntero
            // 
            this.btnResetEntero.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetEntero.Location = new System.Drawing.Point(238, 143);
            this.btnResetEntero.Name = "btnResetEntero";
            this.btnResetEntero.Size = new System.Drawing.Size(69, 31);
            this.btnResetEntero.TabIndex = 7;
            this.btnResetEntero.Text = "Reset";
            this.btnResetEntero.Click += new System.EventHandler(this.btnResetEntero_Click);
            // 
            // btnResetFraccion
            // 
            this.btnResetFraccion.Enabled = false;
            this.btnResetFraccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetFraccion.Location = new System.Drawing.Point(238, 204);
            this.btnResetFraccion.Name = "btnResetFraccion";
            this.btnResetFraccion.Size = new System.Drawing.Size(69, 33);
            this.btnResetFraccion.TabIndex = 6;
            this.btnResetFraccion.Text = "Reset";
            this.btnResetFraccion.Click += new System.EventHandler(this.btnResetFraccion_Click);
            // 
            // txtEntero
            // 
            this.txtEntero.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.txtEntero.Location = new System.Drawing.Point(8, 141);
            this.txtEntero.MaxLength = 3;
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(63, 32);
            this.txtEntero.TabIndex = 5;
            this.txtEntero.Text = "1500";
            this.txtEntero.WordWrap = false;
            // 
            // txtFraccion
            // 
            this.txtFraccion.Enabled = false;
            this.txtFraccion.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.txtFraccion.Location = new System.Drawing.Point(8, 204);
            this.txtFraccion.MaxLength = 3;
            this.txtFraccion.Name = "txtFraccion";
            this.txtFraccion.Size = new System.Drawing.Size(63, 32);
            this.txtFraccion.TabIndex = 4;
            this.txtFraccion.Text = "1500";
            this.txtFraccion.WordWrap = false;
            // 
            // lblFraccionActual
            // 
            this.lblFraccionActual.BackColor = System.Drawing.Color.LightGray;
            this.lblFraccionActual.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblFraccionActual.Location = new System.Drawing.Point(182, 204);
            this.lblFraccionActual.Name = "lblFraccionActual";
            this.lblFraccionActual.Size = new System.Drawing.Size(50, 33);
            this.lblFraccionActual.Text = "15000";
            this.lblFraccionActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCodigoValor
            // 
            this.lblCodigoValor.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblCodigoValor.ForeColor = System.Drawing.Color.White;
            this.lblCodigoValor.Location = new System.Drawing.Point(43, 6);
            this.lblCodigoValor.Name = "lblCodigoValor";
            this.lblCodigoValor.Size = new System.Drawing.Size(85, 20);
            this.lblCodigoValor.Text = "104039";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(8, 8);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.Text = "Cod:";
            // 
            // lblEnteroActual
            // 
            this.lblEnteroActual.BackColor = System.Drawing.Color.LightGray;
            this.lblEnteroActual.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblEnteroActual.Location = new System.Drawing.Point(182, 143);
            this.lblEnteroActual.Name = "lblEnteroActual";
            this.lblEnteroActual.Size = new System.Drawing.Size(50, 31);
            this.lblEnteroActual.Text = "15000";
            this.lblEnteroActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAnaquel
            // 
            this.lblAnaquel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.lblAnaquel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblAnaquel.ForeColor = System.Drawing.Color.White;
            this.lblAnaquel.Location = new System.Drawing.Point(248, 8);
            this.lblAnaquel.Name = "lblAnaquel";
            this.lblAnaquel.Size = new System.Drawing.Size(68, 20);
            this.lblAnaquel.Text = "Anaquel:";
            // 
            // txtNunAnaquel
            // 
            this.txtNunAnaquel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.txtNunAnaquel.Location = new System.Drawing.Point(248, 25);
            this.txtNunAnaquel.MaxLength = 3;
            this.txtNunAnaquel.Name = "txtNunAnaquel";
            this.txtNunAnaquel.Size = new System.Drawing.Size(55, 32);
            this.txtNunAnaquel.TabIndex = 18;
            this.txtNunAnaquel.Text = "1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.label4.Location = new System.Drawing.Point(200, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.Text = "Cant. Anterior:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlCabezera
            // 
            this.pnlCabezera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.pnlCabezera.Controls.Add(this.lblDeProducto);
            this.pnlCabezera.Controls.Add(this.lblCodigoValor);
            this.pnlCabezera.Controls.Add(this.lblCodigo);
            this.pnlCabezera.Controls.Add(this.lblLaboratorioValue);
            this.pnlCabezera.Controls.Add(this.lblLaboratorio);
            this.pnlCabezera.Controls.Add(this.lblProducto);
            this.pnlCabezera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabezera.Name = "pnlCabezera";
            this.pnlCabezera.Size = new System.Drawing.Size(320, 106);
            // 
            // pnlAnaquel
            // 
            this.pnlAnaquel.BackColor = System.Drawing.Color.White;
            this.pnlAnaquel.Controls.Add(this.btnActualizar);
            this.pnlAnaquel.Controls.Add(this.btnCancelarAnaquel);
            this.pnlAnaquel.Controls.Add(this.lblListTitle);
            this.pnlAnaquel.Controls.Add(this.lstAnaquel);
            this.pnlAnaquel.Location = new System.Drawing.Point(0, 106);
            this.pnlAnaquel.Name = "pnlAnaquel";
            this.pnlAnaquel.Size = new System.Drawing.Size(320, 208);
            this.pnlAnaquel.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnActualizar.Location = new System.Drawing.Point(8, 144);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 40);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelarAnaquel
            // 
            this.btnCancelarAnaquel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelarAnaquel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelarAnaquel.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAnaquel.Location = new System.Drawing.Point(187, 144);
            this.btnCancelarAnaquel.Name = "btnCancelarAnaquel";
            this.btnCancelarAnaquel.Size = new System.Drawing.Size(120, 40);
            this.btnCancelarAnaquel.TabIndex = 17;
            this.btnCancelarAnaquel.Text = "Cancelar";
            this.btnCancelarAnaquel.Click += new System.EventHandler(this.btnCancelarAnaquel_Click);
            // 
            // lblListTitle
            // 
            this.lblListTitle.BackColor = System.Drawing.Color.White;
            this.lblListTitle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(29)))));
            this.lblListTitle.Location = new System.Drawing.Point(8, 9);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(299, 20);
            this.lblListTitle.Text = "Lista de anaqueles";
            // 
            // lstAnaquel
            // 
            this.lstAnaquel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.lstAnaquel.Items.Add("1");
            this.lstAnaquel.Items.Add("2");
            this.lstAnaquel.Items.Add("3");
            this.lstAnaquel.Location = new System.Drawing.Point(121, 34);
            this.lstAnaquel.Name = "lstAnaquel";
            this.lstAnaquel.Size = new System.Drawing.Size(186, 94);
            this.lstAnaquel.TabIndex = 18;
            this.lstAnaquel.SelectedIndexChanged += new System.EventHandler(this.lstAnaquel_SelectedIndexChanged);
            // 
            // FrmCantidad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 314);
            this.Controls.Add(this.btnResetFraccion);
            this.Controls.Add(this.lblUnidadFraccionValue);
            this.Controls.Add(this.btnResetEntero);
            this.Controls.Add(this.lblUnidadValue);
            this.Controls.Add(this.lblUnidadFraccion);
            this.Controls.Add(this.lblEnteroActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFraccionActual);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtNunAnaquel);
            this.Controls.Add(this.txtFraccion);
            this.Controls.Add(this.lblAnaquel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlCabezera);
            this.Controls.Add(this.pnlAnaquel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCantidad";
            this.Text = "Registrar inventario";
            this.Load += new System.EventHandler(this.FrmCantidad_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCantidad_KeyUp);
            this.pnlCabezera.ResumeLayout(false);
            this.pnlAnaquel.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCabezera;
        private System.Windows.Forms.Panel pnlAnaquel;
        private System.Windows.Forms.Button btnCancelarAnaquel;
        private System.Windows.Forms.ListBox lstAnaquel;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnActualizar;
    }
}