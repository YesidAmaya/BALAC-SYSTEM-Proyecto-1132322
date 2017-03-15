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
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ingresar ing = new Ingresar();
            ing.Show();
            Hide();
        }

        private void Gerente_Load(object sender, EventArgs e)
        {

        }

        private void AsignarUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario asi = new NuevoUsuario();
            asi.Show();
            Hide();
        }
    }
}
