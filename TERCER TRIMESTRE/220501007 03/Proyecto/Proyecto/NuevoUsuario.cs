using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de que desea Salir?");
            Gerente gr = new Gerente();
            gr.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gerente gr = new Gerente();
            gr.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
