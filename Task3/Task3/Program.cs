using System;

interface Imovable
{
    void Move();
}

class Car : Imovable
{
    public void Move()
    {
        Console.WriteLine("The car is moving.");
    }
}

class Bicycle : Imovable
{
    public void Move()
    {
        Console.WriteLine("The bicycle is moving.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Imovable myCar = new Car();
        Imovable myBicycle = new Bicycle();
        myCar.Move(); // Output: The car is moving.
        myBicycle.Move(); // Output: The bicycle is moving.
    }
}