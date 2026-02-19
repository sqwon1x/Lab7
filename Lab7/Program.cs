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
            new Bicycle("BMX", 25),
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

// Базовий клас
abstract class Vehicle
{
    protected string brand;
    protected int speed;

    public Vehicle(string brand, int speed)
    {
        this.brand = brand;
        this.speed = speed;
    }

    public abstract void Move();
}

// Клас Car
class Car : Vehicle, IRefuelable
{
    public Car(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Car {brand} drives on the road at {speed} km/h.");
    }

    public void Refill()
    {
        Console.WriteLine($"Car {brand} is refueling with gasoline.");
    }
}

// Клас Bicycle
class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Bicycle {brand} pedals at {speed} km/h.");
    }
}