using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_guapo
{
    class Limpiador : Producto
    {
      
        private bool deinteriores;

        public Limpiador(double precio, int codigo, bool deinteriores) : base (precio, codigo)
        {
          
            this.deinteriores = deinteriores;
        }
        public Limpiador()
        {
            
            this.deinteriores = false;
        }

       

        public bool Deinteriores
        {
            get
            {
                return deinteriores;
            }

            set
            {
                deinteriores = value;
            }
        }
        public override string ToString()
        {
            return Convert.ToString( Codigo);
        }
    }
}
