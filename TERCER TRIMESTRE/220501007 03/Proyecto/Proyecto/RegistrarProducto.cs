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
    public partial class RegistrarProducto : Form
    {
        public RegistrarProducto()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produccion Ven = new Produccion();
            Ven.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de que desea Salir?");
            Produccion Ven = new Produccion();
            Ven.Show();
            Hide();
        }
    }
}
