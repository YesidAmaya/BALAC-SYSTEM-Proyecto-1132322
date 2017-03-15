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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ingresar ing = new Ingresar();
            ing.Show();
            Hide();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void Registrarmp_Click(object sender, EventArgs e)
        {
            RegistrarVenta Reg = new RegistrarVenta();
            Reg.Show();
            Hide();
        }

        private void RegistrarP_Click(object sender, EventArgs e)
        {
            
            RegistrarCliente reC = new RegistrarCliente();
            reC.Show();
            Hide();
        }
    }
}
