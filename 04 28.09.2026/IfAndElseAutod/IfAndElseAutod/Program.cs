using System.Security.AccessControl;

namespace IfAndElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta automark kas BMW, Audi, Porsche või Skoda");
        

            //kasutada if ja else
            //kirjuta automark
            //valikus on bmw, audi, porsche, ja skoda
            //Kui valitakse škoda siis seal sees on uuesti küsimus, et 
            //mis mudelit soovid valida. Mudeli valkus kodiaq ja Octavia
            string automark = Console.ReadLine();
           
            if (automark == "BMW")

            {
                Console.WriteLine("valisid marki BMW");
            }

            else if (automark == "Audi")
            {
                Console.WriteLine("valisid marki Audi");
            }
            else if (automark == "Porsche")
            {
                Console.WriteLine("valisid marki Porsche");
            }
            else if (automark == "Skoda")
            {
                Console.WriteLine("Mis mudel?");
                Console.WriteLine("kas Kodiaq või Octavia");
                string mudel = Console.ReadLine();
                if (mudel == "Kodiaq")
                {
                    Console.WriteLine("valisid Skoda Kodiaq mudeli");
                }
                else if (mudel == "Octavia")
                {
                    Console.WriteLine("valisid Skoda Octaiva mudeli");
                }
                else Console.WriteLine("mingi kahtlane mudel");
            }
            else Console.WriteLine("mingi kahtlane auto");
        }
    }
}