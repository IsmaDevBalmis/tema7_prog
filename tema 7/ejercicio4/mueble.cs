using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Mueble
    {
        enum Color
        {
            rojo,
            verde,
            amarillo

        }



        private int peso;
        // Falta poner todo lo relacionado a la estructura de dimensiones.
        private string fabricante;
        private float precio;


        public Mueble(in int peso, in string fabricante, in float precio)
        {
            this.peso = peso;
            this.fabricante = fabricante;
            this.precio = precio;
        }

        public int GetPeso()
        {
            return peso;
        }

        public string GetFabricante()
        {
            return fabricante;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public void SetPeso(in int peso)
        {
            this.peso = peso;
        }

        public void SetFabricante(in string fabricante)
        {
            this.fabricante = fabricante;
        }

        public void SetPrecio(in float precio)
        {
            this.precio = precio;
        }


    }
}
