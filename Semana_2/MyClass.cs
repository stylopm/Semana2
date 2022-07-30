using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_2
{
    class MyClass
    {
        public string color = "red";        // field
        public int maxSpeed = 200;          // field
        public void caracteristicas()   // method
        {
            Console.WriteLine($"El carro es de color {color} y tiene una velocidad de {maxSpeed}");
        }
    }
}
