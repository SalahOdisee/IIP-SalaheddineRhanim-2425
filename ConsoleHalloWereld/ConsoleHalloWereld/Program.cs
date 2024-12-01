namespace ConsoleHalloWereld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hoe heet je:");
            string naam = Console.ReadLine();
            Console.WriteLine($"Aangename kennismaking, {(naam == "Salah eddine" ? "Salah eddine" : "onbekend")}");
            Console.WriteLine("druk op een toest om verder te gaan...");
            Console.ReadKey();

        }
    }
}
