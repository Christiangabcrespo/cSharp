using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Serie: Entregable
    {
        private string titulo;

        //Ejemeplo abreviado de get/set
        // temporadas {get;set;} // temporadas {get;set;} = algun valor
        private int temporadas = 3;

        private bool entregado = false;

        private string genero;

        private string creador;

        public string Titulo { get { return titulo; } }

        public int Temporadas { get { return temporadas; } }

        public bool Entregado { get { return entregado; } }

        public string Genero { get { return genero; } }

        public string Creador { get { return creador; } }

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = titulo;
        }

        public Serie(string titulo, string creador, int temporadas, string genero)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.temporadas = temporadas;
            this.genero = genero;
        }

        public void MostrarInfoSerie()
        {
            Console.WriteLine("{0} fue creado por {1} tiene {2} temporadas y pertenece al genero {3}", titulo, creador, temporadas, genero);
        }

        public void entregar()
        {
            entregado = true;
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
            var serie = (Serie)e;

            if (serie.Temporadas > 3)
            {
                MostrarInfoSerie();
            }
        }
    }
}
