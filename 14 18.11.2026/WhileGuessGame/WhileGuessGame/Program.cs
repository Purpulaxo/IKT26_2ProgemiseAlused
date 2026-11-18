namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //number arvamise mäng

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            //tuleb kasutada while, kus öeldakse, kas sinu
            //pakutud number oli suurem või väiksem
            

            while (guess != secretNumber)
            {
                Console.WriteLine("Arva number ära 1 kuni 100-ni: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > secretNumber)
                {
                    attempts++;
                    Console.WriteLine("Pakutud number on liiga suur");
                    Console.WriteLine("Proovitud kordi: " + attempts);
                }
                else if (guess < secretNumber)
                {
                    attempts++;
                    Console.WriteLine("Pakutud number on liiga väike");
                    Console.WriteLine(" Proovitud kordi: " + attempts);
                }
                else if (guess == secretNumber)
                {
                    attempts++;
                    Console.WriteLine("Pakutud number on õige!");
                    Console.WriteLine("Võttis kokku " + attempts + " korda!");
                    Console.WriteLine("tubli poiss.");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            
        }
    }
}
