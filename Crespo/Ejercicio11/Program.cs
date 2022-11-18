using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{

    class Program
    {
        interface Constantes
        {
            void EntrarPorra();
            void Ganadores();
            void generarResultados();
        }

        public class Jugador 
        {
            public int dineroPorra = 1;
            public int dineroIni = 5;
            public int dineroRecaudado = 0;

            public string nombre;
            public int dinero;
            public int porrasGanadas;
            public string equipo;
            public string ganoPerdio = "";

            public Jugador(string nombre)
            {
                this.nombre = nombre;
                this.dinero = dineroIni;
                this.porrasGanadas = 0;
            }
            public void reiniciarResultados()
            {
                dineroRecaudado = 0;
            }
            public bool tieneDinero()
            {
                if (this.dinero >= dineroPorra)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            static Random random = new Random();
            public void EntrarPorra()
            {
                this.dinero = this.dinero - dineroPorra;
                dineroRecaudado = dineroRecaudado + dineroPorra;

                if (tieneDinero() == true)
                {
                    Console.WriteLine("{0} entro a la porra! quedan: {1}", nombre, dinero);

                    int x = random.Next(0, 2);

                    if (x == 0)
                    {
                        this.equipo = "Local";
                    }
                    else if (x == 1)
                    {
                        this.equipo = "Visitante";
                    }
                }
                else
                {
                    Console.WriteLine("{0} No entro a la porra por falta de dinero, falta {0} dolares", nombre, dinero);
                }
            }
            public void generarResultados()
            {
                int local = 0;
                int visitante = 0;
                var quienGana = 0;

                for (int i = 0; i < 2; i++)
                {
                    local = random.Next(0, 7);
                    visitante = random.Next(0, 7);
                }
                quienGana = local - visitante;

                if (quienGana > 0)
                {
                    if (equipo == "Local")
                    {
                        this.ganoPerdio = "gano";
                    }
                    if (equipo == "Visitante")
                    {
                        this.ganoPerdio = "perdio";
                    }
                }
                else if (quienGana < 0)
                {
                    if (equipo == "Local")
                    {
                        this.ganoPerdio = "perdio";
                    }
                    if (equipo == "Visitante")
                    {
                        this.ganoPerdio = "gano";
                    }
                }
                else if (quienGana == 0)
                {
                    if (equipo == "Local")
                    {
                        this.ganoPerdio = "empate";
                    }
                    if (equipo == "Visitante")
                    {
                        this.ganoPerdio = "empate";
                    }
                }
                Console.WriteLine("local: {0} visitante: {1}", local, visitante);
            }
            public void Ganadores()
            {
                if (this.ganoPerdio == "gano")
                {
                    porrasGanadas++;
                    this.dinero = this.dinero + dineroRecaudado;
                    this.dineroRecaudado = 0;
                    Console.WriteLine("{0} gano la porra ! tiene: {1} dolares", nombre, this.dinero);
                    reiniciarResultados();
                }
                else if (this.ganoPerdio == "perdio")
                {
                    Console.WriteLine("{0} perdio la porra! pero sigue teniendo {1} dolares", nombre, this.dinero);
                }
                else if (this.ganoPerdio == "empate")
                {
                    Console.WriteLine("{0} No gano ni perdio, el bote se acumula! sigue tiniendo {1} dolares", nombre, this.dinero);
                }
            }
        }
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador("Cristian");
            Jugador jugador2 = new Jugador("Ramona");
            Jugador jugador3 = new Jugador("Demetrio");

            Jugador[] jugadores = { jugador1, jugador2, jugador3 };

            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine("----------------------------------------");
                jugador.EntrarPorra();

                Console.WriteLine("{0} aposto :{1}", jugador.nombre, jugador.equipo);
                jugador.generarResultados();
                jugador.Ganadores();

                Console.WriteLine("----------------------------------------");

                jugador.EntrarPorra();
                Console.WriteLine("{0} aposto por: {1}",jugador.nombre, jugador.equipo);
                jugador.generarResultados();
                jugador.Ganadores();

                Console.WriteLine("Gano: {0} Porras", jugador.porrasGanadas);
            }
            Console.ReadKey();
        }
    }
}
