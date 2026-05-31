using SistemaBibliotecario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecario.Controlador
{
    public class TPrestamo
    {
        public static List<Prestamo> ListaPrestamos = new List<Prestamo>();

        public static void Agregar(Prestamo prestamo)
        {
            ListaPrestamos.Add(prestamo);
        }

        public static void Editar(int pos, Prestamo prestamo)
        {
            if (pos >= 0 && pos < ListaPrestamos.Count)
            {
                ListaPrestamos[pos] = prestamo;
            }
        }

        public static void Eliminar(int pos)
        {
            if (pos >= 0 && pos < ListaPrestamos.Count)
            {
                ListaPrestamos.RemoveAt(pos);
            }
        }

        public static Prestamo GetPrestamo(int pos)
        {
            if (pos >= 0 && pos < ListaPrestamos.Count)
            {
                return ListaPrestamos[pos];
            }

            return null;
        }

        public static int Buscar(int id)
        {
            for (int i = 0; i < ListaPrestamos.Count; i++)
            {
                if (ListaPrestamos[i].IdPrestamo == id)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

