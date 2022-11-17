using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        public class Metodos
        {
            public static Random random = new Random();

            public static int generaNumeroAleatorio(int minimo, int maximo)
            {
                int num = random.Next(minimo, maximo);
                return num;
            }
        }

        public class Revolver
        {
            private int posicionBalaActual;
            private int posicionBala;

            public Revolver()
            {
                posicionBalaActual = Metodos.generaNumeroAleatorio(1, 6);
                posicionBala = Metodos.generaNumeroAleatorio(1, 6);
            }

            public bool disparar()
            {
                bool exito = false;

                if (posicionBalaActual == posicionBala)
                {
                    exito = true;
                }
                tambor();

                return exito;

            }

            public void tambor()
            {
                if (posicionBalaActual == 6)
                {
                    posicionBalaActual = 1;
                }
                else
                {
                    posicionBalaActual++;
                }
            }
        }

        public class Jugador
        {

            private int id;
            private string nombre;
            private bool vivo;

            public Jugador(int id)
            {
                this.id = id;
                this.nombre = "Jugador " + id;
                this.vivo = true;
            }
        }
    
       
        static void Main(string[] args)
        {
        }
    }
}
