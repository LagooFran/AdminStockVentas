using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_guapo
{
    class Compra
    {
        private double precioFinal;
        List<Producto> Producto = new List<Producto>();

        public Compra(double precioFinal, List<Producto> producto)
        {
            this.precioFinal = precioFinal;
            Producto = producto;
        }

        public Compra()
        {
            this.precioFinal = 0;
            Producto = null;
        }

        public double PrecioFinal
        {
            get
            {
                return precioFinal;
            }

            set
            {
                precioFinal = value;
            }
        }
        public override string ToString()
        {
            return Convert.ToString(precioFinal);
        }
    }
}
