namespace PdaNet
{
    partial class FrmAdminData
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
            this.btnCrearBD = new System.Windows.Forms.Button();
            this.btnInicializarConteo = new System.Windows.Forms.Button();
            this.btnLoadProducto = new System.Windows.Forms.Button();
            this.btnLoadCodBarra = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearBD
            // 
            this.btnCrearBD.Location = new System.Drawing.Point(22, 16);
            this.btnCrearBD.Name = "btnCrearBD";
            this.btnCrearBD.Size = new System.Drawing.Size(110, 69);
            this.btnCrearBD.TabIndex = 4;
            this.btnCrearBD.Text = "Crear BD";
            this.btnCrearBD.Click += new System.EventHandler(this.btnCrearBD_Click);
            // 
            // btnInicializarConteo
            // 
            this.btnInicializarConteo.Location = new System.Drawing.Point(184, 16);
            this.btnInicializarConteo.Name = "btnInicializarConteo";
            this.btnInicializarConteo.Size = new System.Drawing.Size(110, 69);
            this.btnInicializarConteo.TabIndex = 3;
            this.btnInicializarConteo.Text = "Inicializar Conteo";
            this.btnInicializarConteo.Click += new System.EventHandler(this.btnInicializarConteo_Click);
            // 
            // btnLoadProducto
            // 
            this.btnLoadProducto.Location = new System.Drawing.Point(22, 138);
            this.btnLoadProducto.Name = "btnLoadProducto";
            this.btnLoadProducto.Size = new System.Drawing.Size(110, 69);
            this.btnLoadProducto.TabIndex = 2;
            this.btnLoadProducto.Text = "Reg. Prod.";
            this.btnLoadProducto.Click += new System.EventHandler(this.btnLoadProducto_Click);
            // 
            // btnLoadCodBarra
            // 
            this.btnLoadCodBarra.Location = new System.Drawing.Point(184, 138);
            this.btnLoadCodBarra.Name = "btnLoadCodBarra";
            this.btnLoadCodBarra.Size = new System.Drawing.Size(110, 69);
            this.btnLoadCodBarra.TabIndex = 1;
            this.btnLoadCodBarra.Text = "Reg. Cod. Barra";
            this.btnLoadCodBarra.Click += new System.EventHandler(this.btnLoadCodBarra_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(22, 240);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(272, 24);
            // 
            // FormAdminData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 288);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnLoadCodBarra);
            this.Controls.Add(this.btnLoadProducto);
            this.Controls.Add(this.btnInicializarConteo);
            this.Controls.Add(this.btnCrearBD);
            this.Name = "FormAdminData";
            this.Text = "Admin base de datos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearBD;
        private System.Windows.Forms.Button btnInicializarConteo;
        private System.Windows.Forms.Button btnLoadProducto;
        private System.Windows.Forms.Button btnLoadCodBarra;
        private System.Windows.Forms.Label lblEstado;
    }
}