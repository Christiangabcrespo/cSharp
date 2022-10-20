using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Television: Electrodomestico
    {
        double resolucion = 20;

        bool sintonizadorTDT = false;

        public Television()
        {
        }

        public Television(double precio, double peso)
        {
            this.precioBase = precio;
            this.peso = peso;
        }

        public Television(double resolucion, bool sintonizadorTDT, double precioBase, double peso, char consumodef, string colordef) : base(precioBase, peso, consumodef, colordef)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public double getResolucion()
        {
            return resolucion;
        }

        public bool getSintonizadorTDT()
        {
            return sintonizadorTDT;
        }

        public void PrecioFinal()
        {
            if (resolucion > 40)
            {
                precioBase = (precioBase * 0.3) + precioBase;
            }

            if (sintonizadorTDT == true)
            {
                this.precioBase += 502;
            }
        }
    }
}
