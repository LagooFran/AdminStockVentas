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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void BTN_ingProd2_Click(object sender, EventArgs e)
        {
            Form5 menuVendedor = new Form5();
            this.Hide();
            menuVendedor.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMB_ingProd1.Text == "Jabon")
            {
                CHB_ingProd1.Hide();
                CMB_ingProd3.Show();
                LBL_ingProd7.Show();
            }
            if (CMB_ingProd1.Text == "Limpiador")
            {
                CHB_ingProd1.Show();
                CMB_ingProd3.Hide();
                LBL_ingProd7.Hide();
            }
        }

        private void LBL_ingProd6_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ingProd1_Click(object sender, EventArgs e)
        {
            try
            {
                if(CMB_ingProd2.Text == "2" || CMB_ingProd2.Text == "4" || CMB_ingProd2.Text == "8" || CMB_ingProd2.Text == "6" || CMB_ingProd2.Text == "12")
                {
                    int aux1 = 0;
                    bool check = false;
                    if (CMB_ingProd1.Text == "Jabon")
                    {
                         foreach (Vendedor p in Form4.Vendedores)
                         {
                             if (p.Nombre == Form2.usuarioActual)
                             {
                                aux1 = Convert.ToInt32(TXB_ingProd2.Text);
                            
                                    foreach (Jabon j in p.Jabones)
                                    {
                                    aux1 = Convert.ToInt32(TXB_ingProd2.Text);
                                    for (int i = 0; i < Convert.ToInt32(CMB_ingProd2.Text); i++)
                                    {
                                        if (j.Codigo == aux1) { throw new Exception(); }
                                        else { aux1++; }
                                    }                                    
                                    }
                                    check = true;
                                }

                                if (check == true) {
                                    aux1 = Convert.ToInt32(TXB_ingProd2.Text);
                                    for (int i = 0; i < Convert.ToInt32(CMB_ingProd2.Text); i++)
                                    {
                                        Jabon jb1 = new Jabon(Convert.ToDouble(TXB_ingProd1.Text), aux1, CMB_ingProd3.Text);
                                        p.Jabones.Add(jb1);
                                        aux1++;
                                    }
                                }
                            }

                        }
                               
                    }
                
                if (CMB_ingProd2.Text == "1")
                {
                    if (CMB_ingProd1.Text == "Jabon")
                    {
                        foreach (Vendedor p in Form4.Vendedores)
                        {
                            if (p.Nombre == Form2.usuarioActual)
                            {
                                foreach (Jabon j in p.Jabones)
                                {
                                    if (j.Codigo == Convert.ToInt32(TXB_ingProd2.Text)) { throw new Exception(); }
                                }
                                Jabon jb1 = new Jabon(Convert.ToDouble(TXB_ingProd1.Text), Convert.ToInt32(TXB_ingProd2.Text), CMB_ingProd3.Text);
                                p.Jabones.Add(jb1);
                            }
                        }
                    }

                }

                if (CMB_ingProd2.Text == "2" || CMB_ingProd2.Text == "4" || CMB_ingProd2.Text == "8" || CMB_ingProd2.Text == "6" || CMB_ingProd2.Text == "12")
                {
                    int aux1 = 0;
                    bool check = false;
                    if (CMB_ingProd1.Text =="Limpiador")
                    {
                        foreach (Vendedor p in Form4.Vendedores)
                        {
                            if (p.Nombre == Form2.usuarioActual)
                            {
                                aux1 = Convert.ToInt32(TXB_ingProd2.Text);

                                foreach (Limpiador l in p.Limpiadores)
                                {
                                    aux1 = Convert.ToInt32(TXB_ingProd2.Text);
                                    for (int i = 0; i < Convert.ToInt32(CMB_ingProd2.Text); i++)
                                    {
                                        if (l.Codigo == aux1) { throw new Exception(); }
                                        else { aux1++; }
                                    }
                                }
                                check = true;
                            }

                            if (check == true)
                            {
                                aux1 = Convert.ToInt32(TXB_ingProd2.Text);
                                for (int i = 0; i < Convert.ToInt32(CMB_ingProd2.Text); i++)
                                {
                                    Limpiador lmp1 = new Limpiador(Convert.ToDouble(TXB_ingProd1.Text), aux1, CHB_ingProd1.Checked);
                                    p.Limpiadores.Add(lmp1);
                                    aux1++;
                                }
                            }
                        }

                        }

                    }
                
                if (CMB_ingProd2.Text == "1")
                {
                    if (CMB_ingProd1.Text == "Limpiador")
                    {
                        foreach (Vendedor p in Form4.Vendedores)
                        {
                            if (p.Nombre == Form2.usuarioActual)
                            {
                                foreach (Limpiador l in p.Limpiadores)
                                {
                                    if (l.Codigo == Convert.ToInt32(TXB_ingProd2.Text)) { throw new Exception(); }
                                }
                                Limpiador lmp1 = new Limpiador(Convert.ToDouble(TXB_ingProd1.Text), Convert.ToInt32(TXB_ingProd2.Text), CHB_ingProd1.Checked);
                                p.Limpiadores.Add(lmp1);
                            }
                        }
                    }

                }

                Form5 menuVendedor = new Form5();
                this.Hide();
                menuVendedor.Show();
            }catch (Exception ex) { MessageBox.Show("Datos incorrectos (Los codigos de producto NO pueden ser iguales dentro del mismo tipo)"); }



        }
    }
}