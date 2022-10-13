using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Raices
    {
        public double a;
        public double b;
        public double c;

        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void ObtenerRaices()
        {
            double x1 = (-b + Math.Sqrt(getDiscriminante())) / (2 * a);
            double x2 = (-b - Math.Sqrt(getDiscriminante())) / (2 * a);
        }

        public void obtenerRaiz()
        {

            double x = (-b) / (2 * a);

            Console.WriteLine("Unica solucion");
            Console.WriteLine(x);

        }

        public double getDiscriminante()
        {
            return Math.Pow(b, 2) - (4*a*c);
        }

        public bool tieneRaices()
        {
            return getDiscriminante() > 0;
        }

        public bool tieneRaiz()
        {
            return getDiscriminante() == 0;
        }

        public void calcular()
        {

            if (tieneRaices())
            {
                obtenerRaiz();
            }
            else if (tieneRaiz())
            {
                obtenerRaiz();
            }
            else
            {
                Console.WriteLine("No tiene soluciones");
            }

        }
    }
}
