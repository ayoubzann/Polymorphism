﻿namespace Polymorphism
{
    class Animal  // Base class (parent) 
    {
        public void animalSound()                                   // Method animalSound outputs to console "The animal makes a sound"
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public void animalSound()                                   // Method animalSound outputs to console "The pig says: wee wee"
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public void animalSound()                                   // Method animalSound outputs to console "The dog says: bow wow"
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();   // Animal object outputs animalSound-method to console
            myPig.animalSound();      // Pig object outputs animalSound-method to console
            myDog.animalSound();      // Dog object outputs animalSound-method to console
        }
    }
}