namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Endless for loop ");

            ushort counter = 1;

            for (; ; )
            {
                Console.WriteLine($"Counter: { counter}");
                counter++;

                    if (counter > 10)
                    {
                    break;
                    }
            }


        }

    }

}