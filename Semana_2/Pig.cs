using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_2
{
    internal class Pig : AnimalAbstract
    {
        public Pig()
        {
            respirar();
        }

        public override void animalSound()
        {
            
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
