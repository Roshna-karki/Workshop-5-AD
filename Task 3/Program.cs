namespace Task3
{
    class Program
    {
        static void Main()
        {
            Printer printer = new Printer();

            printer.Print("hy! how you doing?");
            printer.Print(123456);
            printer.Print("Web", 5);


            Console.WriteLine("\n \n These are the infos of the Nepali and English teacher.");
            NepaliTeacher nepali = new NepaliTeacher();
            EnglishTeacher english = new EnglishTeacher();

            nepali.Name = "Harihal";
            Console.WriteLine("Nepali Teacher:" + nepali.Name);
            nepali.Teaching();
            nepali.SalaryInfo();

            Console.WriteLine();

            english.Name = "Ritz";
            Console.WriteLine("English Teacher:" + english.Name);
            english.Teaching();
            english.SalaryInfo();
        }
    }
}