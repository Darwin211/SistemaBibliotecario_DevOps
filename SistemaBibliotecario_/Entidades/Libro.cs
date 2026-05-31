using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecario.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Autor { get; set; } 

        public string categoria { get; set; }
        public int stock { get; set; }
        public override string ToString()
        {
            return Titulo;
        }
    }

}
