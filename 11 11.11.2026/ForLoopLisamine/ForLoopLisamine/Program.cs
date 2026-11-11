using System.Diagnostics.CodeAnalysis;

namespace ForLoopLisamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täisarvude kokku liitmine kuni kümneni");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n\n");

            int  j, sum = 0;
            
            for (j = 1; j <= 10; j++) 
            {
                sum = j + sum;
                Console.WriteLine("Summa on:" + sum);
            }


        }
    }
}
