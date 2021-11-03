using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_guapo
{
    class Admin : Personal
    {

     

        public Admin(string nombre, string contraseña, int dni, string mail, bool admin) : base (nombre, contraseña, dni, mail, admin)
        {
           
        }
        public Admin()
        {
         
        }


        public override string ToString()
        {
            return Nombre;
        }
    }
}
