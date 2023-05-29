//A simple program that implements abstract classes in C#

using System;

// Abstract base class
abstract class Shape
{
    public abstract void Draw(); // Abstract method
    public void Display()
    {
        Console.WriteLine("Displaying the shape.");
    }
}

// Derived class 1
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

// Derived class 2
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

// Main class
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of the derived classes
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();

        // Calling the abstract method and the non-abstract method
        circle.Draw();
        circle.Display();

        rectangle.Draw();
        rectangle.Display();
    }
}
