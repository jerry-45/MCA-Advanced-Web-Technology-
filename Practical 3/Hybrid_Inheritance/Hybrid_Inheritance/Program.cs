////A simple program that demonstrates hybrid inhertance in C#

using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

// Interface for jumping behavior
interface IJumpable
{
    void Jump();
}

// Derived class 1
class Dog : Animal, IJumpable
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }

    public void Jump()
    {
        Console.WriteLine("The dog is jumping.");
    }
}

// Main class
class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the derived class
        Dog dog = new Dog();

        // Accessing the methods of the base class
        dog.Eat();

        // Accessing the methods of the derived class
        dog.Bark();

        // Accessing the methods from the interface
        dog.Jump();
    }
}
