namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Illimar sulbi");

            //siin on muutuja nimega name,
            //mis on tüübiga string
            //loeb andmeid konsoolist ja salvestab
            //need muutuja name sisse
            string name = Console.ReadLine();
            //if ja else kontrollib, kas muutuja
            //name on tühi või mitte
            //kui teksti "tere, TUndmatu! error" ja teeeb paar piikus

            if (name != "")
            {
                Console.WriteLine("Tere, " + name);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("tere, Tundmatu Error");
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);


            }

        }
    }
}