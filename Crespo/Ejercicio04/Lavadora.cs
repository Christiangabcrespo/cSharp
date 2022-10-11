using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Lavadora: Electrodomestico
    {
        const int carga = 5;

        public Lavadora()
        {

        }

        public Lavadora(double precio, int peso)
        {
            precioBase = precio;
            this.peso = peso;
        }

        public Lavadora(int carga) : base()
        {
            peso = carga;
        }


        public int getCarga()
        {
            return carga;
        }

        public void PrecioFinal()
        {
            if (carga > 30)
            {
                precioBase += 50;
            }
        }
    }
}
