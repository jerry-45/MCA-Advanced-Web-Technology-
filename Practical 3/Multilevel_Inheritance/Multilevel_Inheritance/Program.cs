//A simple program that demonstrates multi-level inhertance in C#

using System;

//Base class
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
class GermanShepherd : Dog
{
    public void Guard()
    {
        Console.WriteLine("The German Shepherd is guarding.");
    }
}

//Main class
class Program
{
    static void Main(string[] args)
    {
        //Creating an instance of the derived class
        GermanShepherd germanShepherd = new GermanShepherd();


        //Accessing the methods of the base class
        germanShepherd.Eat();

        //Accessing the methods of the intermediate derived class
        germanShepherd.Bark();

        //Accessing the methods of the derived class
        germanShepherd.Guard();
    }
}