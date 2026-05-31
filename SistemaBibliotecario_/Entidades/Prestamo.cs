using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecario.Entidades
{

        public class Prestamo
        {
            public int IdPrestamo { get; set; }

            public Libro Libro { get; set; }

            public Usuario Usuario { get; set; }

            public DateTime FechaPrestamo { get; set; }

            public DateTime FechaDevolucion { get; set; }
        }
    }
