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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void BTN_ingresoVehiculo_Click(object sender, EventArgs e)
        {
            Form5 menuUsuario = new Form5();
            menuUsuario.Show();
            this.Hide();
        }

        private void BTN_IngresoVehiculo2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Vendedor p in Form4.Vendedores) {
                if (p.Admin == false)
                {
                    if (Form2.usuarioActual == p.Nombre)
                    {
                        Vehiculo v1 = new Vehiculo(CMB_IngresoVehiculo1.Text, TXB_ingreseoVehiculo1.Text);
                        p.Vehiculos.Add(v1);
                            this.Hide();
                            Form5 menuVendedor = new Form5();
                            menuVendedor.Show();
                    }
                }
              }
           }catch (Exception ex) { MessageBox.Show("Datos incorrectos"); }
        }
    }
}
