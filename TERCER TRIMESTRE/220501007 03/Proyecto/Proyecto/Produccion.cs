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
    public partial class Produccion : Form
    {
        public Produccion()
        {
            InitializeComponent();
        }

        private void Exitproduccion_Click(object sender, EventArgs e)
        {
            Ingresar ing = new Ingresar();
            ing.Show();
            Hide();
        }

        private void Produccion_Load(object sender, EventArgs e)
        {

        }

        private void Registrarmp_Click(object sender, EventArgs e)
        {
            RegistrarMarteriaP Res = new RegistrarMarteriaP();
            Res.Show();
            Hide();
        }

        private void RegistrarP_Click(object sender, EventArgs e)
        {
            RegistrarProducto reP = new RegistrarProducto();
            reP.Show();
            Hide();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            ListarPcto lis = new ListarPcto();
            lis.Show();
            Hide();
        }
    }
}
