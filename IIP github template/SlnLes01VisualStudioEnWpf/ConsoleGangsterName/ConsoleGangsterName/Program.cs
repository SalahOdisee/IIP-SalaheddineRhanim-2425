namespace ConsoleGangsterName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gangstaNameBuilder = @"
***********************
| GANGSTA NAME BUILDER |
***********************
";
            Console.WriteLine(gangstaNameBuilder);
            Console.Write("Give the first name of any Disney character: ");
            string name = Console.ReadLine();
            Console.Write("Give any workbench tool:  ");
            string tool = Console.ReadLine();
            Console.Write("What is your last name: ");
            string LastName = Console.ReadLine();

            string gangstaName = $"{name} 'the {tool}' {LastName}";
            Console.Write("Your gangsta name : ");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(gangstaName);
            
            Console.ResetColor();
        }
        
    }
}
