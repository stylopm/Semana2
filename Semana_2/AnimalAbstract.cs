using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_2
{
    internal abstract class AnimalAbstract
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
       protected void respirar()
        {
            Console.WriteLine("EL animal respira");
        }
    }
}
