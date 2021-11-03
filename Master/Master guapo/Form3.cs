using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_guapo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CMB_menuAdmin1.DataSource = Form1.Usuarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 creacionVendedor = new Form4();
            this.Hide();
            creacionVendedor.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DGV_menuAdmin1.DataSource = Form1.Usuarios;
        }

        private void BTN_menuAdmin5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.Show();
        }

        private void BTN_menuAdmin4_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Personal p in Form1.Usuarios)
            {
                if (CMB_menuAdmin1.Text == p.Nombre)
                {
                   try
                    { 
                        p.Nombre = TXB_menuAdmin1.Text;
                        p.Contraseña = TXB_menuAdmin2.Text;
                        p.Dni = Convert.ToInt32(TXB_menuAdmin3.Text);
                        p.Mail = TXB_menuAdmin4.Text;
                    }
                 catch (Exception ex)
                    {
                        i++; 
                        MessageBox.Show("Datos incorrectos");
                    }
            }
                if (i == 0)
                {
                    MessageBox.Show("Datos modificados correctamente");
                }
            }
        }

        private void LBL_menuAdmin3_Click(object sender, EventArgs e)
        {

        }
    }
}
