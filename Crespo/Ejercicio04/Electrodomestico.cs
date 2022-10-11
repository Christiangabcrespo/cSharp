using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Electrodomestico
    {
        //Constantes

        public string colorDefault { get; set; }= "blanco";


        public char consumoDeafault { get; set; } = 'F';


        public double precioDeafault { get; set; } = 100;


        public double pesoDefault { get; set; } = 5;

        //Atributos

        public double precioBase;


        public string color;


        public char consumoEnergetico;


        public double peso;

 

        public void comprobarColor(string color)
        {

            //Colores disponibles
            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
            bool encontrado = false;

            for (int i = 0; i < colores.Length && !encontrado; i++)
            {

                if (colores[i].Equals(color))
                {
                    encontrado = true;
                }

            }

            if (encontrado)
            {
                this.color = color;
            }
            else
            {
                this.color = colorDefault;
            }


        }


        public void comprobarConsumoEnergetico(char consumoEnergetico)
        {

            if (consumoEnergetico >= 65 && consumoEnergetico <= 70)
            {
                this.consumoEnergetico = consumoEnergetico;
            }
            else
            {
                this.consumoEnergetico = consumoDeafault;
            }

        }

        //Métodos publicos
        public double precioFinal()
        {
            double plus = 0;
            switch (consumoEnergetico)
            {
                case 'A':
                    plus += 100;
                    break;
                case 'B':
                    plus += 80;
                    break;
                case 'C':
                    plus += 60;
                    break;
                case 'D':
                    plus += 50;
                    break;
                case 'E':
                    plus += 30;
                    break;
                case 'F':
                    plus += 10;
                    break;
            }

            if (peso >= 0 && peso < 19)
            {
                plus += 10;
            }
            else if (peso >= 20 && peso < 49)
            {
                plus += 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                plus += 80;
            }
            else if (peso >= 80)
            {
                plus += 100;
            }

            return precioBase+= plus;
        }

        //Constructores


        public Electrodomestico()
        {
        }


        public Electrodomestico(double precioBase, double peso, char consumodef, string colordef)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.consumoDeafault = consumodef;
            this.colorDefault = colordef;
        }

    }
}

