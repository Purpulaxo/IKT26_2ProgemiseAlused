namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("loop");
            //teha konsoolirakendu, kus kasutad for loopi
            //kolm korda näidatakse Tere tulemast reaNumber

            int nr = 3;
           

            for (int i = 1; i <= nr; i++)
            {
                Console.WriteLine("Tere tulemast " + i);
            }

        }
    }
}
