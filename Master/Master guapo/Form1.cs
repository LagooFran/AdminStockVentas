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
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
            //List<Vehiculo> v = null;
            //List<Venta> vl = null;
            //Vendedor vendedor = new Vendedor(v, vl, "vendedor", "vendedor", 123, "vendedor", false);
            //Form4.Vendedores.Add(vendedor);
            //usuarios.Add(vendedor);
        }
       private static List<Stock> listaStock = new List<Stock>();
        private static List<Personal> usuarios = new List<Personal>();
        private static List<Cliente> clientes = new List<Cliente>();
        internal static List<Personal> Usuarios
        {
            get
            {
                return usuarios;
            }

            set
            {
                usuarios = value;
            }
        }

        internal static List<Stock> ListaStock
        {
            get
            {
                return listaStock;
            }

            set
            {
                listaStock = value;
            }
        }

        internal static List<Cliente> Clientes
        {
            get
            {
                return clientes;
            }

            set
            {
                clientes = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Admin administrador = new Admin(TXB_admin1.Text, TXB_admin2.Text, Convert.ToInt32(TXB_admin3.Text), TXB_admin4.Text, true);
                usuarios.Add(administrador);
                this.Hide();
                Form2 login = new Form2();
                List<Jabon> jabones = new List<Jabon>();
                List<Limpiador> limpiadores = new List<Limpiador>();
                Stock stock = new Stock(jabones,limpiadores);
                listaStock.Add(stock);
                login.Show();
                
            }
            catch (Exception ex) { MessageBox.Show("Datos incorrectos"); }
            
        }
    }
}
