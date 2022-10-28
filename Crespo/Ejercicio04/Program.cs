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

            double sumaElectrodomesticos = 0;
            double sumaLavadora = 0;
            double sumaTelevision = 0;

            

            // Television 
            Electrodomestico electro1 = new Television(27.56, true, 5000, 24, 'A', "Blanco");
            Electrodomestico electro3 = new Television(5000.50, true, 8000, 30, 'A', "Azul");
            Electrodomestico electro5 = new Television(30.70, true, 10000, 20, 'E', "Rojo");
            Electrodomestico electro7 = new Television(40.50, false, 6000, 45, 'B', "Verde");
            Electrodomestico electro9 = new Television(50.5, true, 5000, 45, 'A', "Rojo");

            // Lavadoras

            Electrodomestico electro2 = new Lavadora(5000, 50, 23, 'F', "Rojo");
            Electrodomestico electro4 = new Lavadora(5000.50, 30, 50, 'D', "Verder");
            Electrodomestico electro6 = new Lavadora(5000, 60, 30, 'F', "Rojo");
            Electrodomestico electro8 = new Lavadora(4500.700, 50, 40, 'C', "Azul");
            Electrodomestico electro10 = new Lavadora(9999, 50, 45, 'A', "Blanco");

            //Electrodomestico electro11 = new Television(5676.27, 56);
       

            Electrodomestico[] electrodomesticos = { electro1, electro2, electro3, electro4, electro5, electro6, electro7, electro8, electro9, electro10 };


            //for (int i = 0; i < electrodomesticos.Length; i++)
            //{
            //    electrodomesticos[i].precioBase += electrodomesticos[i].precioFinal();x
            //}

            //Mostrar Televistores precio

            Console.WriteLine("Television precio final");
            Console.WriteLine("");

            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                if (electrodomesticos[i].GetType() == typeof(Television))
                {
                    var aux=  (Television) electrodomesticos[i];
                    aux.PrecioFinal();
                    electrodomesticos[i].precioFinal();
                    sumaTelevision += electrodomesticos[i].precioBase;
                    Console.WriteLine(electrodomesticos[i].precioBase);
                    sumaElectrodomesticos += electrodomesticos[i].precioBase;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("La suma de las televisiones es " + sumaTelevision);
            Console.WriteLine("");

            //Mostrar Lavadoras precio

            Console.WriteLine("");
            Console.WriteLine("Lavadoras precio final");
            Console.WriteLine("");

            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                if (electrodomesticos[i].GetType() == typeof(Lavadora))
                {
                    Console.WriteLine(electrodomesticos[i].precioBase);
                    sumaLavadora += electrodomesticos[i].precioBase;
                    sumaElectrodomesticos += electrodomesticos[i].precioBase;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("La suma de las lavadoras es de "+ sumaLavadora);
            Console.WriteLine("");

            Console.WriteLine("La suma total de todos los electrodomesticos es: "+ sumaElectrodomesticos);


            //for (int i = 0; i < electrodomesticos.Length; i++)
            //{
            //    if (electrodomesticos[i].GetType() == typeof(Electrodomestico))
            //    {
            //        Console.WriteLine(electrodomesticos[i].precioBase);
            //        sumaElectrodomesticos += electrodomesticos[i].precioBase;
            //    }
            //}

            Console.ReadLine();
        }
    }
}
