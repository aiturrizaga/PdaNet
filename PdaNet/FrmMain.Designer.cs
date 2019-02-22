namespace PdaNet
{
    partial class FrmMain
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
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Button();
            this.lblF12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Teal;
            this.btnInventario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnInventario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInventario.Location = new System.Drawing.Point(62, 57);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(194, 50);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(62, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportar.Location = new System.Drawing.Point(62, 122);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(194, 50);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar datos";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(22, 138);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(110, 70);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar Datos";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.Text = "Estado PDA:";
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.Red;
            this.btnEstado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnEstado.ForeColor = System.Drawing.Color.White;
            this.btnEstado.Location = new System.Drawing.Point(102, 11);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(204, 28);
            this.btnEstado.TabIndex = 6;
            this.btnEstado.Text = "Desconfigurado";
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // lblF12
            // 
            this.lblF12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblF12.Location = new System.Drawing.Point(6, 248);
            this.lblF12.Name = "lblF12";
            this.lblF12.Size = new System.Drawing.Size(198, 20);
            this.lblF12.Text = "[F12] Formatear inventario";
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 288);
            this.ControlBox = false;
            this.Controls.Add(this.lblF12);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInventario);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "PdaNet";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyEvent);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label lblF12;
    }
}