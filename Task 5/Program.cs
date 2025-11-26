namespace Task5
{
    class Program
    {
        static void Main()
        {
            ElectronicsStore store = new ElectronicsStore();

            Laptop laptop = new Laptop("Asus", 1200m);
            Smartphone phone = new Smartphone("Xiomi", 800m);

            store.AddDevice(laptop);
            store.AddDevice(phone);

            store.ShowAllDeviceDetails();
        }
    }
}