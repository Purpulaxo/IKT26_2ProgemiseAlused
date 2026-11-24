namespace TriangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk, täisnurkne kolmnurk");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv");
            int i, j, rows;
            rows = Convert.ToInt32(Console.ReadLine());

            //Kasutame kahte for loopi
            //for loop for loopi sees
            for (i = 0; i <= rows; i++)
            {
                Console.WriteLine(" ");
                for (j = 1; j <= i; j++)
                {
                Console.Write("*");
                }
            }
        }
    }
}
