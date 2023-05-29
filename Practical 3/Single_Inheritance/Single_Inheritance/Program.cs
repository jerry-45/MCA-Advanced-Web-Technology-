//A simple program that demonstrates single inhertance in C#

using System;

//Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

//Derived class
class Dog : Animal 
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

//Main class
class Program
{
    static void Main(string[] args)
    {
        //Creating an instance of the derived class
        Dog dog = new Dog();

        //Accessing the methods of the base class
        dog.Eat();

        //Accessing the methods of the derived class
        dog.Bark();
    }
}