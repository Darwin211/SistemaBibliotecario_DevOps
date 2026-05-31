using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecario.Controlador
{
    public class TLogin
    {
        public static bool Validar(string usuario, string clave)
        {
            if (usuario == "admin" && clave == "123")
            {
                return true;
            }

            return false;
        }
    }
}

