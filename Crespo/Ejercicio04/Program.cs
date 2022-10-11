using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[11];
            Electrodomestico electro1 = new Electrodomestico(1500, 20, 'A', "Negro" );
            electro1 = new Television(50, false);


            Electrodomestico electro2 = new Electrodomestico(2000, 30, 'C', "Rojo");

            Electrodomestico electro3 = new Electrodomestico(750, 15, 'D', "Blanco");
            electro3 = new Television(32, true);

            Electrodomestico electro4 = new Electrodomestico(15000, 50, 'C', "Azul");
            electro4 = new Lavadora(15000, 50);

            Electrodomestico electro5 = new Electrodomestico(1250, 10, 'B', "Naranja");
            electro5 = new Television(36, false);

            Electrodomestico electro6 = new Electrodomestico(5780, 5, 'F', "Verde");
            electro6 = new Lavadora(5780, 5);

            Electrodomestico electro7 = new Electrodomestico(574.50, 90, 'E', "Violeta");
            electro7 = new Television(50, true);

            Electrodomestico electro8 = new Electrodomestico(1450.50, 45, 'C', "Fucsia");
            electro8 = new Lavadora(1450.50, 45);

            Electrodomestico electro9 = new Electrodomestico(8500, 68, 'D', "Rosa");
            electro9 = new Television(37, false);

            Electrodomestico electro10 = new Electrodomestico(9999, 85, 'A', "Amarillo");
            electro10 = new Lavadora(9999, 85);

            Electrodomestico electro11 = new Television(5676.27, 56);
            electrodomesticos[0] = electro1;
            electrodomesticos[1] = electro2;
            electrodomesticos[2] = electro3;
            electrodomesticos[3] = electro4;
            electrodomesticos[4] = electro5;
            electrodomesticos[5] = electro6;
            electrodomesticos[6] = electro7;
            electrodomesticos[7] = electro8;
            electrodomesticos[8] = electro9;
            electrodomesticos[9] = electro10;
            electrodomesticos[10] = electro11;


            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                electrodomesticos[i].precioBase = electrodomesticos[i].precioFinal();
            }

            double sumaElectrodomesticos = 0;

            //Mostrar Televistores

            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                if (electrodomesticos[i].GetType() == typeof(Television))
                {
                    var aux=  (Television) electrodomesticos[i];
                    aux.PrecioFinal();
                    electrodomesticos[i].precioFinal();
                    sumaElectrodomesticos += electrodomesticos[i].precioBase;
                    Console.WriteLine(electrodomesticos[i].precioBase);
                }
            }

            Console.WriteLine("Lavadoras");

            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                if (electrodomesticos[i].GetType() == typeof(Lavadora))
                {
                    Console.WriteLine(electrodomesticos[i].precioBase);
                    sumaElectrodomesticos += electrodomesticos[i].precioBase;
                }
            }

            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                if (electrodomesticos[i].GetType() == typeof(Electrodomestico))
                {
                    Console.WriteLine(electrodomesticos[i].precioBase);
                    sumaElectrodomesticos += electrodomesticos[i].precioBase;
                }
            }

            Console.ReadLine();
        }
    }
}
