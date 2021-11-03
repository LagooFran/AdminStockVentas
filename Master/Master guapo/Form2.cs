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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string usuarioActual;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LBL_login1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_login1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (Personal p in Form1.Usuarios)
            {
                if (TXB_login1.Text == p.Nombre)
                {
                    if (TXB_login2.Text == p.Contraseña)
                    {
                        if (p.Admin == true)
                        {
                            Form3 menuadmin = new Form3();
                            menuadmin.Show();
                            this.Hide();
                            break;
                        }
                        else
                        {
                            usuarioActual = TXB_login1.Text;
                            Form5 menuVendedor = new Form5();
                            menuVendedor.Show();
                            this.Hide();
                            break;
                        }
                    } else { cont++; }
                } else { cont++; }
            }
            if(cont == Form1.Usuarios.Count)
                MessageBox.Show("Usuario incorrecto");
        }

    }
}

