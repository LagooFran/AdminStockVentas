using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_guapo
{
    class Cliente
    {
        private string nombre;
        List<Compra> compra = new List<Compra>();

     

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        internal List<Compra> Compra
        {
            get
            {
                return compra;
            }

            set
            {
                compra = value;
            }
        }

        public Cliente(List<Compra> cmp1,  string nombre)
        {
            this.nombre = nombre;
            this.Compra = Compra;
        }
        public Cliente()
        {
            this.nombre = "";
            this.Compra = null;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
