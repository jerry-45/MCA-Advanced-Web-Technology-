//A simple program that demonstrates hierarchical inhertance in C#

using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

//Derived class 1
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

//Derived class 2
class Cat : Animal 
{
    public void Meow() 
    {
        Console.WriteLine("The cat is meowing.");
    }
}

//Main class
class Program
{
    static void Main(string[] args)
    {
        //Creating the instance of the derived class
        Dog dog = new Dog();
        Cat cat = new Cat();

        //Accessing the methods of the base class
        dog.Eat();
        cat.Eat();

        //Accessing the methods of the derived classes
        dog.Bark();
        cat.Meow();
    }
}