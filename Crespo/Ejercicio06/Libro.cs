using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Libro
    {
        public string ibsn {get; set;}
        
        public string titulo { get; set; }

        public string autor { get; set; }

        public int numeroPaginas { get; set; }

        public Libro()
        {
        }

        public Libro(string ibsn, string titulo, string autor, int numeroPaginas)
        {
            this.ibsn = ibsn;
            this.titulo = titulo;
            this.autor = autor;
            this.numeroPaginas = numeroPaginas;
        }

        public void mostrarInfo()
        {
            Console.WriteLine("El libro {0} con ibsn {1} fue creado por {2} y tiene {3} paginas.", titulo, ibsn, autor, numeroPaginas);
        }
    }
}
