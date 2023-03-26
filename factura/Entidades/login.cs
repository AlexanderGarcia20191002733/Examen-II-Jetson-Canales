using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class login
    {
        public string CodigoUsuario { get; set; }
        public string Contraseña { get; set; }

        public login()
        {
        }

        public login(string codigoUsuario, string contraseña)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;
        }



    }
}
