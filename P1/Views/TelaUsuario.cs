using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoTaskool
{
    public partial class TelaUsuario : Form
    {
        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaUsuarios newMDIChild = new ListaUsuarios();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaUsuarios newMDIChild = new ListaUsuarios();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
