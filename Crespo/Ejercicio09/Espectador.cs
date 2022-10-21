﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Espectador
    {
        /*Atributos*/
        private String nombre;
        private int edad;
        private double dinero;

        /*Constructores*/
        public Espectador(String nombre, int edad, double dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }

        /*Metodos*/
        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public double getDinero()
        {
            return dinero;
        }

        public void setDinero(double dinero)
        {
            this.dinero = dinero;
        }

        /**
         * Pagamos la entrada del cine
         *
         * @param precio
         */
        public void pagar(double precio)
        {
            dinero -= precio;
        }

        /**
         * Indicamos si el espectador tiene edad para ver la pelicula (en el video
         * estaba en la clase pelicula tiene mas sentido que sea un metodo del
         * espectador)
         *
         * @param edadMinima
         * @return
         */
        public bool tieneEdad(int edadMinima)
        {
            return edad >= edadMinima;
        }

        /**
         * Indicamos si el espectador tiene dinero (en el video estaba en la clase
         * cine tiene mas sentido que sea un metodo del espectador)
         *
         * @param precioEntrada
         * @return
         */
        public bool tieneDinero(double precioEntrada)
        {
            return dinero >= precioEntrada;
        }

    }
}