namespace IfAndElsePikkus
﻿namespace IfandElseMajasuurus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui pikk sa oled");
            int cm = int.Parse(Console.ReadLine());
            Console.WriteLine("Kui suur su maja on");
            int m2 = int.Parse(Console.ReadLine());

            if (cm >= 40 && cm <= 80)
            if (m2 >= 0 && m2 <= 40)
            {
                Console.WriteLine("Sinu pikkus on " + cm + " cm");
                Console.WriteLine("Sinu maja on " + m2 + " ruutmeetrid");
            }
            else if (cm >= 81 && cm <= 130)
            else if (m2 >= 41 && m2 <= 90)
            {
                Console.WriteLine("Sinu pikkus on " + cm + " cm");
                Console.WriteLine("Sinu maja on " + m2 + " ruutmeetrid");
            }
            else if (cm >= 131 && cm <= 170)
            else if (m2 >= 91 && m2 <= 130)
            {
                Console.WriteLine("Sinu pikkus on " + cm + " cm");
                Console.WriteLine("Sinu maja on " + m2 + " ruutmeetrid");
            }
            else if (cm >= 171 && cm <= int.MaxValue)
            else if (m2 >= 131 && m2 <= int.MaxValue)
            {
                Console.WriteLine("Sinu pikkus on " + cm + " cm");
                Console.WriteLine("Sinu maja on " + m2 + " ruutmeetrid");
            }
            else
            {
                Console.WriteLine("Kahtlane number");

            }
        }
    }
}