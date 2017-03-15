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
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               
                switch (comboBox1.SelectedIndex)
                {

                    case 0:
                        Gerente ger = new Gerente();
                        ger.Show();
                        Hide();
                        break;
                    case 1:
                                               
                        Ventas ven = new Ventas();
                        ven.Show();
                        Hide();
                        break;
                    case 2:
                        Produccion pro = new Produccion();
                        pro.Show();
                        Hide();
                        break;
                  
                }
            }
            catch (Exception E)
            {
                lblmensaje.Visible=true;
            }
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {

        }
    }
}
