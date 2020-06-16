using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

  /*new frmCadastro().ShowDialog();
    ListaUsuarios newMDIChild = new ListaUsuarios();
    newMDIChild.MdiParent = this;
    newMDIChild.Show();*/

namespace EstudoTaskool
{
    public partial class frmLogin : Form
    {
        private object administardorButton;

        public frmLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | Taskool";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //para bloquear o Ctrl C + Ctrl V
            tbxUsuario.ShortcutsEnabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (administardorButton.Trim().Length != 1)
            {
                MessageBox.Show("Bem Vindo", "UsuarioComum");
                new TelaUsuario().ShowDialog();

            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Bem Vindo", "Adm");
                new TelaAdm().ShowDialog();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbxUsuario_Enter(object sender, EventArgs e)
        {

        }

        private bool isCapsLockActive()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }

        private void tbxUsuario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            //para funcionar esse processo precisa alterar a configura
            System.Diagnostics.Process.Start("osk.exe");
            tbxUsuario.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}