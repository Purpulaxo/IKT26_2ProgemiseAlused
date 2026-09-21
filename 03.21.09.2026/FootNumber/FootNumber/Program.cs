namespace FootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teha jalanumbri suurusest üks if ja else harjutus.
            //Esimene tingimus on jalanumbri 30 - 33 (siin on tekst roheline),
            //teine jalanumer 34-38 (siin on tekst valge)
            //kolmas jalanumbri 39 - 44 (siin on teks sinine ja tagatasut kollane)
            //neljas jalanumbri 45 - 48 (siin teeb arvuti häält beep)
            //kindlasti tuleb ära lahendada olukord
            //kus kasutataske mõnda teist jalanumbrit
            Console.WriteLine("Sisesta jalanumber");
            int jalanumber = int.Parse(Console.ReadLine());


            if (jalanumber >= 30 && jalanumber <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("jalanumber on 30 ja 33 vahel");
                Console.ResetColor();
            }
            else if (jalanumber >= 34 && jalanumber <= 38)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Jalanumber on 34 ja 38 vahel");
                Console.ResetColor();
            }
            else if (jalanumber >= 39 && jalanumber <= 44) 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jalanumber on 39 ja 44 vahel");
                Console.ResetColor();
            }
            else if (jalanumber >= 45 && jalanumber <= 48)
            {
                Console.WriteLine("Jalanumber on  45 ja 48 vahel");
                Console.Beep();
            }
            else
            {
                Console.WriteLine("Jalanumber ei kuulu ühtegi vahemikku.");
            }
        }
    }
}
