using System.Data;

namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Tuleb kasutada while ja omakorda while sisse panna while
            //while nesting
            //WhileNesting kordab ennast 5 korda
            //vooskeem teha
            int a = 1;
            while (a <= 5)
            {
                int b = 1;
                while (b <= 5)
                {
                    Console.WriteLine(b + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}
