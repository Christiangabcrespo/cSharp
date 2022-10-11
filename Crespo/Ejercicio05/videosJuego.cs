using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class videosJuego: Entregable
    {
        public string titulo { get; set; }

        public int horasEstimadas { get; set; } = 10;

        public bool entregado = false;

        public string genero { get; set; }

        public string compania { get; set; }


        //public string Titulo { get { return titulo; } }

        //public int HorasEstimadas { get { return horasEstimadas; } }

        //public bool Entragado { get { return entregado; } }

        //public string Genero { get { return genero; } }

        //public string Compania { get { return compania; } }

        public videosJuego()
        {
        }

        public videosJuego(string titulo, int horasestimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasestimadas;
        }

        public videosJuego(string titulo, int horasestimadas, string genero, string compania)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasestimadas;
            this.genero = genero;
            this.compania = compania;
        }

        public void MostrarInfoJuego()
        {
            Console.WriteLine("{0} tiene {1} horas estimadas de uso, spertenece al genero {2} y fue desarrollado por {3}", titulo, horasEstimadas, genero, compania);
        }

        public void MostrarInfoJuegoMasHorasEstimadas()
        {
            Console.WriteLine("{0} tiene {1} horas estimadas de uso, spertenece al genero {2} y fue desarrollado por {3}", titulo, horasEstimadas, genero, compania);
        }

        public void entregar()
        {
            this.entregado = true;
        }

        public void devolver()
        {
            entregado = false;
        }

        public bool isEntregado()
        {
            return entregado;
        }

        public void compareTo(Object e)
        {
            var videojuego = (videosJuego) e;

            if (videojuego.horasEstimadas > 10)
            {
                MostrarInfoJuegoMasHorasEstimadas();
            }
        }
    }
}
