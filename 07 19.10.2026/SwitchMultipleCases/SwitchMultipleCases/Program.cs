namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple cases!");

            string input = Console.ReadLine();
            switch (input)
            {
                case "intro to C#" or "variables" or "Data Types":
                    Console.WriteLine("Basic");
                    break;
                case "OOP" or "Classes" or "Objects":
                    Console.WriteLine("Intermediate");
                    break;
                case "Asynchronos Programming" or "LINQ" or "Deleggates" :
                    Console.WriteLine("advanced");
                    break;
                default:
                    Console.WriteLine("Unknown Course");
                    break;
            }
        }
    }
}
