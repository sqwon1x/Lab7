using System;
using System.Collections.Generic;

// Головна програма
class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("BMW", 120),
            new Bicycle("Trek", 25),
            new Airplane("Boeing", 800)
        };

        foreach (Vehicle v in vehicles)
        {
            v.Move();

            if (v is IRefuelable refuelable)
            {
                refuelable.Refill();
            }

            Console.WriteLine();
        }
    }
}

// Інтерфейс
interface IRefuelable
{
    void Refill();
}