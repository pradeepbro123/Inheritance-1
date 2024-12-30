using System;

class Vehicle
{
    protected string brand;
    protected string model;
    protected int year;

    public Vehicle(string brand, string model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Vehicle:");
        Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
    }
}

class Car : Vehicle
{
    public Car(string brand, string model, int year) : base(brand, model, year)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"Car:");
        Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model, int year) : base(brand, model, year)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"Motorcycle:");
        Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the vehicle details.");

        Console.WriteLine("Enter the brand:");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter the model:");
        string model = Console.ReadLine();

        Console.WriteLine("Enter the year:");
        int year = Convert.ToInt32(Console.ReadLine());

        Vehicle car = new Car(brand, model, year);
        Vehicle motorcycle = new Motorcycle(brand, model, year);

        car.Display();
        motorcycle.Display();

        Console.ReadLine();
    }
}
