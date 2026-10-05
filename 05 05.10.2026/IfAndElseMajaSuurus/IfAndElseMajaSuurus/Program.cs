namespace IfAndElsePikkus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui pikk sa oled");
            int cm = int.Parse(Console.ReadLine());

            if (cm >= 40 && cm <= 80)
            {
                Console.WriteLine("Sinu pikkus on " + cm + " cm");
            }
            else if (cm >= 81 && cm <= 130)
            {
                Console.WriteLine("Sinu pikkus on " + cm + " cm");
            }
            else if (cm >= 131 && cm <= 170)
            {
                Console.WriteLine("Sinu pikkus on " + cm + " cm");
            }
            else if (cm >= 171 && cm <= int.MaxValue)
            {
                Console.WriteLine("Sinu pikkus on " + cm + " cm");
            }
            else
            {
                Console.WriteLine("Kahtlane number");

            }
        }
    }
}