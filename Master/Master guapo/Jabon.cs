using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_guapo
{
    class Jabon : Producto
    {
        private string aroma;

        public Jabon(double precio, int codigo, string aroma) : base (precio, codigo)
        {

            this.aroma = aroma;
        }
        public Jabon()
        {

            this.aroma = "";
        }
        
        public string Aroma
        {
            get
            {
                return aroma;
            }

            set
            {
                aroma = value;
            }
        }
        public override string ToString()
        {
            return Convert.ToString(Codigo);
        }
    }
}
