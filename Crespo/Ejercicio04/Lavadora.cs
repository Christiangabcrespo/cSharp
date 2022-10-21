using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Lavadora: Electrodomestico
    {
        public int carga = 5;

        public Lavadora()
        {

        }

        public Lavadora(double precio, int peso, int carga, char consumodef, string colordef) : base()
        {
            precioBase = precio;
            this.peso = peso;
            this.carga = carga;
            consumoDeafault = consumodef;
            colorDefault = colordef;
        }

        //public Lavadora(int carga) : base()
        //{
        //    peso = carga;
        //}


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
