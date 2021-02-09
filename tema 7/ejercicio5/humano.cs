using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Humano
    {

        private string nombre;
        private int edad;
        private char sexo;
        private int inteligencia;
        private int fuerza;
        private int destreza;
        private int energia;

        public Humano(in string nombre,
                      in int edad,
                      in char sexo,
                      in int inteligencia,
                      in int fuerza,
                      in int destreza,
                      in int energia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.inteligencia = inteligencia;
            this.fuerza = fuerza;
            this.destreza = destreza;
            this.energia = energia;


        }


        public string GetNombre()
        {
            return nombre;
        }

        public char GetSexo()
        {
            return sexo;
        }

        public int GetInteligencia()
        {
            return inteligencia;
        }

        public int GetFuerza()
        {
            return fuerza;
        }

        public int GetDestreza()
        {
            return destreza;
        }

        public int GetEnergia()
        {
            return energia;
        }

        public void SetNombre(in string nombre)
        {
            this.nombre = nombre;
        }

        public void SetSexo(in char sexo)
        {
            this.sexo = sexo;
        }

        public void SetInteligencia(in int inteligencia)
        {
            this.inteligencia = inteligencia;
        }

        public void SetFuerza(in int fuerza)
        {
            this.fuerza = fuerza;
        }

        public void SetDestreza(in int destreza)
        {
            this.destreza = destreza;
        }

        public void SetEnergia(in int energia)
        {
            this.energia = energia;
        }


        public void MostrarInformacion()
        {

            Console.WriteLine($"El nombre es {nombre} con la edad {edad}");
            Console.WriteLine($"Su sexo es {sexo}");
            Console.WriteLine($"Su inteligencia es de: {inteligencia}");
            Console.WriteLine($"Su fuerza es de: {fuerza}");
            Console.WriteLine($"Su destreza es de: {destreza}");
            Console.WriteLine($"Su energia es de: {energia}");



        }


    }
}
