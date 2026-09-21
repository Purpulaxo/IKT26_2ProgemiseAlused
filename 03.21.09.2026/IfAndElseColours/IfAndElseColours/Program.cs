using System.Drawing;

namespace IfAndElseColours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            Console.WriteLine("Teha if ja else konsoolirakendus, kus kontrollitakse stringi abil värvi vastavust");
            Console.WriteLine("Värvide valikus on: red, blue, green ja white");
            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta eelpool sisestatud värvi");

            Console.WriteLine("Sisesta värv");
            string input = Console.ReadLine();


            if (input == "red")
            {
                Console.WriteLine("Valisid värvi red");
            }
            else if (input == "blue")
            {
                Console.WriteLine("Valisid värvi blue");
            }
            else if (input == "Green")
            {
                Console.WriteLine("Valisid värvi Green");
            }
            else if (input == "White")
            {
                Console.WriteLine("Valisid värvi White");
            }
            else
            {

                Console.WriteLine("Tundmatu värv");
            }
        }
    }
}