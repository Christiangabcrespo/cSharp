using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("1111111111", "Dracula", "Bram Stoker", 418);
            Libro libro2 = new Libro("1111111112", "1984", "George Orwell", 326);
            libro1.mostrarInfo();
            libro2.mostrarInfo();

            if (libro1.numeroPaginas > libro2.numeroPaginas)
            {
                Console.WriteLine("El Libro con mas paginas es {0}", libro1.titulo);
            }
            else
            {
                Console.WriteLine("El libro con mas paginas es {0}", libro2.titulo);
            }
            Console.ReadKey();
        }
    }
}
