using SistemaBibliotecario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecario.Controlador
{
    public class TUsuario
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>();

        public static void Agregar(Usuario usuario)
        {
            ListaUsuarios.Add(usuario);
        }

        public static void Editar(int pos, Usuario usuario)
        {
            if (pos >= 0 && pos < ListaUsuarios.Count)
            {
                ListaUsuarios[pos] = usuario;
            }
        }

        public static void Eliminar(int pos)
        {
            if (pos >= 0 && pos < ListaUsuarios.Count)
            {
                ListaUsuarios.RemoveAt(pos);
            }
        }

        public static Usuario GetUsuario(int pos)
        {
            if (pos >= 0 && pos < ListaUsuarios.Count)
            {
                return ListaUsuarios[pos];
            }

            return null;
        }

        public static int Buscar(int id)
        {
            for (int i = 0; i < ListaUsuarios.Count; i++)
            {
                if (ListaUsuarios[i].IdUsuario == id)
                {
                    return i;
                }
            }

            return -1;
        }
    }

}
