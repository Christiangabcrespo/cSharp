using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Pelicula
    {
        /*Atributos*/
        private String titulo;
        private int duracion;
        private int edadMinima;
        private string director;

        /*Constructor*/
        public Pelicula(string titulo, int duracion, int edadMinima, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
        }

        /*Metodos*/
        public string getTitulo()
        {
            return titulo;
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public int getDuracion()
        {
            return duracion;
        }

        public void setDuracion(int duracion)
        {
            this.duracion = duracion;
        }

        public int getEdadMinima()
        {
            return edadMinima;
        }

        public void setEdadMinima(int edadMinima)
        {
            this.edadMinima = edadMinima;
        }

        public string getDirector()
        {
            return director;
        }

        public void setDirector(string director)
        {
            this.director = director;
        }

    }
}
