using System;

// Abstract class Shape
abstract class Shape
{
    public abstract double GetArea(); // this place is empty
}

// Circle class that inherits from Shape
class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    // Override the GetArea method to calculate the area of the circle
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Rectangle class that inherits from Shape
class Rectangle : Shape
{
    private double width { get; set; }
    private double height { get; set; }
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    // Override the GetArea method to calculate the area of the rectangle
    public override double GetArea()
    {
        return width * height;
    }
}

// Main program to demonstrate polymorphism

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);
        Console.WriteLine($"Area of Circle: {circle.GetArea()}"); // Output: Area of Circle: 78.53981633974483
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}"); // Output: Area of Rectangle: 24
    }
}