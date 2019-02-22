using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PdaNet
{
    public partial class FrmMain : Form
    {
        Chequeador chequeador;

        public FrmMain()
        {
            this.InitializeComponent();
            this.chequeador = new Chequeador();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (!this.chequeador.existeBD())
            {
                MessageBox.Show("PDA No configurado", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("¿Estás seguro de exportar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialogresult == DialogResult.Yes)
                {
                    this.chequeador.exportar();
                    Application.Exit();
                }
                
            }
            actualizarEstado();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FrmAdminData data = new FrmAdminData();
            data.setFrmParent(this);
            data.setChequeador(this.chequeador);
            data.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (!this.chequeador.existeBD())
            {
                MessageBox.Show("PDA no configurado!", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (Configuracion.lectoraTipo.Equals("S"))
            {
                FrmLectora lectora = new FrmLectora();
                lectora.setFrmParent(this);
                lectora.setChequeador(this.chequeador);
                lectora.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.actualizarEstado();

            this.Text = this.Text + " " + this.obtenerVersion() + " - " + this.chequeador.getUserNameFromFile();
            if (Directory.Exists(@"\Flash Disk"))
            {
                Configuracion.lectoraTipo = "P";
                //Configuracion.directorio = @"\Flash Disk\";
            }
            else
            {
                Configuracion.lectoraTipo = "S";
                //Configuracion.directorio = @"\Application\";
            }
        }

        private void FrmMain_KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                FrmFormateo frmFormateo = new FrmFormateo();
                frmFormateo.Show();
            }
        }

        public string obtenerVersion()
        {
            AssemblyName name = Assembly.GetExecutingAssembly().GetName();
            string[] strArray = new string[] { "v", Configuracion.version };
            return string.Concat(strArray);
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            actualizarEstado();
        }

        public void actualizarEstado()
        {
            if (this.chequeador.validaBDexist())
            {
                this.btnEstado.BackColor = System.Drawing.Color.Green;
                this.btnEstado.Text = "Configurado";
                this.btnInventario.Enabled = true;
                this.btnExportar.Enabled = true;
            }
            else if (this.chequeador.validaArchivoDifExist())
            {
                this.btnEstado.BackColor = System.Drawing.Color.Blue;
                this.btnEstado.Text = "Pendiente Carga";
                this.btnInventario.Enabled = false;
                this.btnExportar.Enabled = false;
            }
            else
            {
                this.btnEstado.BackColor = System.Drawing.Color.Red;
                this.btnEstado.Text = "Desconfigurado";
                this.btnInventario.Enabled = false;
                this.btnExportar.Enabled = false;
            }
        }
        
    }
}