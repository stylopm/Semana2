using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_2
{
    internal class DogInterface : InterfaceAnimal
    {

        public void animalSound()
        {
            Console.WriteLine("El perro siempre ladra");
        }

        public void run()
        {
            Console.WriteLine("El perro siempre corre con sus patas");
        }
    }
}
