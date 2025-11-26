class Program
{
    static void Main()
    {
        Car car = new Car
        {
            Brand = "Hyundai",
            Speed = 140,
            Seats = 5
        };

        Motorcycle bike = new Motorcycle
        {
            Brand = "Classic Himalyan",
            Speed = 100,
            HasCarrier = true
        };

        // Base class methods – reuse
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();
    }
}