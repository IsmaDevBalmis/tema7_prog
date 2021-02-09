using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Circulo
    {

        private float radio;

        public Circulo(in float radio)
        {
            this.radio = radio;
        }

        public float GetRadio()
        {
            return radio;
        }

        public void SetRadio(in float radio)
        {
            this.radio = radio;
        }

       

    }

}
