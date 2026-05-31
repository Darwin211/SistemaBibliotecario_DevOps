using SistemaBibliotecario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecario.Controlador
{
    public class TLibro
    {
        public static List<Libro> ListaLibros = new List<Libro>();

        public static void Agregar(Libro libro)
        {
            ListaLibros.Add(libro);
        }

        public static void Editar(int pos, Libro libro)
        {
            if (pos >= 0 && pos < ListaLibros.Count)
            {
                ListaLibros[pos] = libro;
            }
        }

        public static void Eliminar(int pos)
        {
            if (pos >= 0 && pos < ListaLibros.Count)
            {
                ListaLibros.RemoveAt(pos);
            }
        }

        public static Libro GetLibro(int pos)
        {
            if (pos >= 0 && pos < ListaLibros.Count)
            {
                return ListaLibros[pos];
            }

            return null;
        }

        public static int Buscar(int id)
        {
            for (int i = 0; i < ListaLibros.Count; i++)
            {
                if (ListaLibros[i].Id == id)
                {
                    return i;
                }
            }

            return -1;
        }
    
}
}
