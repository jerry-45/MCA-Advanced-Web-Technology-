//A simple program that demonstrates multiple inhertance in C#

using System;

//Interface 1
interface IAnimal
{
    void Eat();
}

//Interface 2
interface IDog
{
    void Bark();
}

//Derived class implementating multiple interfaces
class GermanShepherd : IAnimal, IDog
{
    public void Eat()
    {
        Console.WriteLine("The German Shepherd is eating");
    }

    public void Bark()
    {
        Console.WriteLine("The German Shepherd is barking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Creating an instance of the derived class
        GermanShepherd germanShepherd = new GermanShepherd();

        //Accessing the methods of the implemented interfaces
        germanShepherd.Eat();
        germanShepherd.Bark();
    }
}