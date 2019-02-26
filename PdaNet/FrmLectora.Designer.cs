namespace PdaNet
{
    partial class FrmLectora
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMaestro = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNumAnaquel = new System.Windows.Forms.TextBox();
            this.lblAnaquel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.txtCodigo.Location = new System.Drawing.Point(116, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(179, 32);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(23, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(272, 46);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMaestro
            // 
            this.btnMaestro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnMaestro.Location = new System.Drawing.Point(23, 152);
            this.btnMaestro.Name = "btnMaestro";
            this.btnMaestro.Size = new System.Drawing.Size(134, 49);
            this.btnMaestro.TabIndex = 3;
            this.btnMaestro.Text = "Ver productos";
            this.btnMaestro.Click += new System.EventHandler(this.btnMaestro_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductos.ForeColor = System.Drawing.Color.Blue;
            this.lblProductos.Location = new System.Drawing.Point(23, 126);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(272, 32);
            this.lblProductos.Text = "Productos inventariados:";
            this.lblProductos.ParentChanged += new System.EventHandler(this.lblProductos_ParentChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(188, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 30);
            this.lblTotal.Text = "15000";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.Color.Blue;
            this.lblCodigo.Location = new System.Drawing.Point(116, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(179, 20);
            this.lblCodigo.Text = "Código del producto:";
            // 
            // txtNumAnaquel
            // 
            this.txtNumAnaquel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.txtNumAnaquel.Location = new System.Drawing.Point(23, 32);
            this.txtNumAnaquel.MaxLength = 3;
            this.txtNumAnaquel.Name = "txtNumAnaquel";
            this.txtNumAnaquel.Size = new System.Drawing.Size(59, 32);
            this.txtNumAnaquel.TabIndex = 1;
            this.txtNumAnaquel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAnaquel_KeyPress);
            // 
            // lblAnaquel
            // 
            this.lblAnaquel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnaquel.ForeColor = System.Drawing.Color.Blue;
            this.lblAnaquel.Location = new System.Drawing.Point(23, 9);
            this.lblAnaquel.Name = "lblAnaquel";
            this.lblAnaquel.Size = new System.Drawing.Size(87, 20);
            this.lblAnaquel.Text = "Anaquel:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Regresar";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLectora
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMaestro);
            this.Controls.Add(this.lblAnaquel);
            this.Controls.Add(this.txtNumAnaquel);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLectora";
            this.Text = "Lectora";
            this.Deactivate += new System.EventHandler(this.FrmLectora_Deactivate);
            this.Load += new System.EventHandler(this.FrmLectora_Load);
            this.Activated += new System.EventHandler(this.FrmLectora_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMaestro;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNumAnaquel;
        private System.Windows.Forms.Label lblAnaquel;
        private System.Windows.Forms.Button button1;
    }
}