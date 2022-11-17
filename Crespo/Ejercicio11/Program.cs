using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{

    class Program
    {
        interface constantes
        {
            void EntrarPorra();
            void Ganadores();
            void generarResultados();
        }

        public class jugador 
        {
            public int dineroPorra = 1;
            public int dineroIni = 5;
            public int dineroRecaudado = 0;

            public string nombre;
            public int dinero;
            public int porrasGanadas;
            public string equipo;
            public string[] resultados;
            public string GanoPerdio = "";

            public jugador(string nombre)
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

        }
        static void Main(string[] args)
        {
        }
    }
}
