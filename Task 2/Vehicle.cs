using System;

class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Brand} started.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} stopped.");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car Brand: {Brand}, Speed: {Speed} km/h, Seats: {Seats}");
    }
}

class Motorcycle : Vehicle
{
    public bool HasCarrier { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle Brand: {Brand}, Speed: {Speed} km/h, Has Carrier: {HasCarrier}");
    }
}