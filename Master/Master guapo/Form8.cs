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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        double auxprecio = 0;
        List<Producto> productos = new List<Producto>();
        List<Jabon> jabones = new List<Jabon>();
        List<Limpiador> limpiadores = new List<Limpiador>();
        Venta vent1 = new Venta();
        private void BTN_menuVenta1_Click(object sender, EventArgs e)
        {
            List<Compra> cmp = new List<Compra>();
            Cliente client1 = new Cliente(cmp, TXB_menuVenta1.Text);
            Form1.Clientes.Add(client1);
            CMBX_menuVentas1.DataSource = null;
            CMBX_menuVentas1.DataSource = Form1.Clientes;
            TXB_menuVenta1.Text = "";
        }

        private void BTN_menuVenta3_Click(object sender, EventArgs e)
        {
            foreach (Vendedor p in Form4.Vendedores)
            {
                if (p.Nombre == Form2.usuarioActual)
                {
                    CMBX_menuVentas1.DataSource = null;
                    DGV_menuVenta1.DataSource = p.Jabones;
                }
            }

            foreach (Vendedor p in Form4.Vendedores)
            {
                if (p.Nombre == Form2.usuarioActual)
                {
                    CMBX_menuVentas1.DataSource = null;
                    DGV_menuVenta2.DataSource = p.Limpiadores;
                }
            }

        }

        private void CMBX_menuVenta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBX_menuVenta2.Text == "Jabon")
            {
                foreach (Vendedor p in Form4.Vendedores)
                {
                    if (p.Nombre == Form2.usuarioActual)
                    {
                        CMBX_menuVenta3.DataSource = p.Jabones;
                    }
                }
            }
                if (CMBX_menuVenta2.Text == "Limpiador")
            {
                foreach (Vendedor p in Form4.Vendedores)
                {
                    if (p.Nombre == Form2.usuarioActual)
                    {
                        CMBX_menuVenta3.DataSource = p.Limpiadores;
                    }
                }
            }
        }

        private void BTN_menuVenta6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 menuVentas = new Form5();
            menuVentas.Show();
        }

        private void BTN_menuVenta4_Click(object sender, EventArgs e)
        {
            int indexJ = 0;
            int indexP = 0;
            int indexL = 0;
            try
            {
                if (CMBX_menuVenta2.Text == "Jabon")
                {
                    foreach (Vendedor p in Form4.Vendedores)
                    {
                        indexP++;
                        if (p.Nombre == Form2.usuarioActual)
                        {
                            foreach (Jabon j in p.Jabones)
                            {
                                indexJ++;
                                if (j.Codigo == Convert.ToInt32(CMBX_menuVenta3.Text))
                                {
                                    Jabon jabon = new Jabon(j.Precio, j.Codigo, j.Aroma);
                                    productos.Add(jabon);
                                    jabones.Add(jabon);
                                    auxprecio = auxprecio + jabon.Precio;
                                    break;
                                }
                            }
                        }
                    }
                    Form4.Vendedores[indexP - 1].Jabones.RemoveAt(indexJ - 1);
                    DGV_menuVenta1.DataSource = null;
                    DGV_menuVenta1.DataSource = Form4.Vendedores[indexP - 1].Jabones;
                }
                if (CMBX_menuVenta2.Text == "Limpiador")
                {
                    foreach (Vendedor p in Form4.Vendedores)
                    {
                        indexP++;
                        if (p.Nombre == Form2.usuarioActual)
                        {
                            foreach (Limpiador l in p.Limpiadores)
                            {
                                indexL++;
                                if (l.Codigo == Convert.ToInt32(CMBX_menuVenta3.Text))
                                {
                                    Limpiador limpiador = new Limpiador(l.Precio, l.Codigo, l.Deinteriores);
                                    productos.Add(limpiador);
                                    limpiadores.Add(limpiador);
                                    auxprecio = auxprecio + limpiador.Precio;
                                    break;
                                }
                            }
                        }
                    }
                    Form4.Vendedores[indexP - 1].Limpiadores.RemoveAt(indexL - 1);
                    DGV_menuVenta2.DataSource = null;
                    DGV_menuVenta2.DataSource = Form4.Vendedores[indexP - 1].Limpiadores;
                }
                vent1.Producto = productos;
                CMBX_menuVenta2.DataSource = null;
                CMBX_menuVenta2.Text = "";
                CMBX_menuVenta3.DataSource = null;
                LBL_menuVenta6.Text = "Total venta:" + auxprecio;
                DGV_menuVenta3.DataSource = null;
                DGV_menuVenta3.DataSource = productos;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nada que borrar en la lista!");
            }
        }

        private void BTN_menuVenta5_Click(object sender, EventArgs e)
        {
            try { 
            if(CMBX_menuVentas1.Text == "") { throw new Exception(); }
            vent1.PrecioFinal = auxprecio;
            foreach (Vendedor p in Form4.Vendedores)
            {
                if (p.Nombre == Form2.usuarioActual)
                {
                    p.Ventas.Add(vent1);
                    Compra cmp1 = new Compra(auxprecio, productos);
                    foreach (Cliente c in Form1.Clientes)
                    {
                        if (c.Nombre == CMBX_menuVentas1.Text)
                        {
                            c.Compra.Add(cmp1);

                        }
                    }
                }
            }
            MessageBox.Show("Venta realizada con exito!");
            vent1 = null;
            productos.Clear();
            limpiadores.Clear();
            jabones.Clear();
            DGV_menuVenta3.DataSource = null;
            DGV_menuVenta3.DataSource = productos;
            auxprecio = 0;
            LBL_menuVenta6.Text = "Total venta:" + auxprecio;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos incorrectos");
            }


        }

    private void BTN_menuVenta7_Click(object sender, EventArgs e)
        {
            try { 
            int indexJ = 0;
            int indexP = 0;
            int indexL = 0;
            bool auxl = false;
            bool auxj = false;

            foreach (Vendedor p in Form4.Vendedores)
            {
                indexP++;

                if (p.Nombre == Form2.usuarioActual)
                {
                    foreach (Jabon j in jabones)
                    {
                        auxj = true;
                        indexJ++;
                        p.Jabones.Add(j);
                        productos.Remove(j);

                    }

                    foreach (Limpiador l in limpiadores)
                    {
                        auxl = true;
                        indexL++;
                        p.Limpiadores.Add(l);
                        productos.Remove(l);
                    }

                    if (auxj == true){
                        DGV_menuVenta1.DataSource = null;
                        DGV_menuVenta1.DataSource = Form4.Vendedores[indexP - 1].Jabones;
                        DGV_menuVenta3.DataSource = null;
                        DGV_menuVenta3.DataSource = productos;
                        auxprecio = 0;
                        LBL_menuVenta6.Text = "Total venta:" + auxprecio;
                    }
                    if(auxl == true){
                        DGV_menuVenta2.DataSource = null;
                        DGV_menuVenta2.DataSource = Form4.Vendedores[indexP - 1].Limpiadores;
                        DGV_menuVenta3.DataSource = null;
                        DGV_menuVenta3.DataSource = productos;
                        auxprecio = 0;
                        LBL_menuVenta6.Text = "Total venta:" + auxprecio;
                    }
               
                }
            }

                limpiadores.Clear();
                jabones.Clear();
        }catch (Exception ex)
            {
                MessageBox.Show("Error venta");
            }
        }

        private void BTN_menuVenta2_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
