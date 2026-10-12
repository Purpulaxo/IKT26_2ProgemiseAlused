using System.Security.Cryptography.X509Certificates;

namespace IfElseNestingFlowChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja else nesting");

            String input = Console.ReadLine();

            if (input == "auto")
            {
                Console.WriteLine("sisesta auto suurus");
                String size = Console.ReadLine();
                if (size == "sedaan")
                {
                    Console.WriteLine("Valisid sedaani");
                }

                else if (size == "kabriolet")
                {
                    Console.WriteLine("valisid kabrioleti");

                }
                else Console.WriteLine("Valisid muu auto");
            }
            else
            {
                Console.WriteLine("valisid muu sõiduki");
            }
        }
    }
}