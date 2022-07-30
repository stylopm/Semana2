using System;

namespace Semana_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ejercicios de POO!");
            //MyClass miClase = new MyClass();
            //miClase.color = "Azul";
            //miClase.caracteristicas();


            //Car Ford = new Car("VW");
            //Console.WriteLine(Ford.model);
            //Console.WriteLine(Ford.model);


            //Person myObj = new Person();
            //myObj.Name = "sss";
            //myObj.Age = 30;
            //Console.WriteLine(myObj.Name);
            //Console.WriteLine(myObj.Age);

            //Animal myAnimal = new Animal();  // Create a Animal object
            //Animal myPig = new Pig();  // Create a Pig object
            //Animal myDog = new Dog();  // Create a Dog object

            //myAnimal.animalSound();
            //myPig.animalSound();
            //myDog.animalSound();

            AnimalAbstract myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
            //DogInterface dog = new DogInterface();
            //dog.animalSound();


        }
    }
}
