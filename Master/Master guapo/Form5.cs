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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Cliente c in Form1.Clientes)
            {
                if (c.Nombre == CMB_menuVendedor1.Text)
                {
                    DGV_menuVendedor4.DataSource = c.Compra;
                }
            }
        }

        private void BTN_menuVendedor1_Click(object sender, EventArgs e)
        {
            Form6 ingresoVehiculo = new Form6();
            ingresoVehiculo.Show();
            this.Hide();
        }

        private void BTN_menuVendedor5_Click(object sender, EventArgs e)
        {
            foreach (Vendedor p in Form4.Vendedores)
                if (p.Nombre == Form2.usuarioActual)
                {
                    DGV_menuVendedor1.DataSource = p.Vehiculos;
                }


            foreach (Vendedor p in Form4.Vendedores)
            {
                if (p.Nombre == Form2.usuarioActual)
                {
                    DGV_menuVendedor2.DataSource = p.Jabones;
                }
            }

            foreach (Vendedor p in Form4.Vendedores)
            {
                if (p.Nombre == Form2.usuarioActual)
                {
                    DGV_menuVendedor3.DataSource = p.Limpiadores;
                }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            this.Hide();
            login.Show();
        }

        private void BTN_menuVendedor2_Click(object sender, EventArgs e)
        {
            Form7 ingProd = new Form7();
            this.Hide();
            ingProd.Show();
        }

        private void DGV_menuVendedor2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_menuVendedor3_Click(object sender, EventArgs e)
        {
            Form8 menuVenta = new Form8();
            this.Hide();
            menuVenta.Show();
        }

        private void DGV_menuVendedor3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_menuVendedor7_Click(object sender, EventArgs e)
        {
            CMB_menuVendedor1.DataSource = null;
            CMB_menuVendedor1.DataSource = Form1.Clientes;
        }
    }
}
