namespace ForPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("On algarv");
            else
                Console.WriteLine("Pole algarv");
        }
    }
 }

