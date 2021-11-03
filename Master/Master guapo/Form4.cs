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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private static List<Vendedor> vendedores = new List<Vendedor>();

        internal static List<Vendedor> Vendedores
        {
            get
            {
                return vendedores;
            }

            set
            {
                vendedores = value;
            }
        }

        private void LBL_admin1_Click(object sender, EventArgs e)
        {

        }

        private void TXB_admin3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_admin4_Click(object sender, EventArgs e)
        {

        }

        private void LBL_admin3_Click(object sender, EventArgs e)
        {

        }

        private void LBL_admin2_Click(object sender, EventArgs e)
        {

        }

        private void LBL_admin5_Click(object sender, EventArgs e)
        {

        }

        private void TXB_admin2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXB_admin1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Vehiculo> vehiculo = new List<Vehiculo>();
                List<Venta> ventas = new List<Venta>();
                List<Jabon> jbn = new List<Jabon>();
                List<Limpiador> lmp = new List<Limpiador>();
                Vendedor vendedor = new Vendedor(jbn, lmp, vehiculo, ventas, TXB_cVendedor1.Text, TXB_cVendedor2.Text, Convert.ToInt32(TXB_cVendedor3.Text), TXB_cVendedor4.Text, false);
                Form1.Usuarios.Add(vendedor);
                vendedores.Add(vendedor);
                MessageBox.Show("Usuario creado");
                this.Hide();
                Form3 menuadmin = new Form3();
                menuadmin.Show();
            }catch(Exception ex) { MessageBox.Show("Datos Incorrectos"); }
        }
    }
}
