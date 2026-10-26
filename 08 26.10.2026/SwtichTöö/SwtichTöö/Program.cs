namespace SwtichTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sissestakas tehe, meetod või nimi ja vajuta kaks korda Enter klahvi");
           
            string töö = Console.ReadLine();
           
            
            switch (töö)
            {   
                case "tehe":
                    Console.WriteLine("Sisesta Esimene number");
                    float firstNr = float.Parse(Console.ReadLine());
                    Console.WriteLine("Sisesta + ");
                    string tehe = Console.ReadLine();
                    Console.WriteLine("Sisesta teine number");
                    float secondNr = float.Parse(Console.ReadLine());
                    Console.WriteLine("vastus on " + firstNr + secondNr);

                    break;

                case "meetod":
                    string meetod = Console.ReadLine();
                    Console.WriteLine("Kui soovid meetodit välja tuua kirjuta ja kui ei soovi kirjuta ei");
                    
                   {
                        if (meetod == "ja")
                        {
                            
                                 object AuhMethod;
                            {
                                Console.WriteLine("Auh");
                            }
                        }
                       else Console.WriteLine("Mingi viga tuli");

                    }     
                        break;

                case "nimi":
                    string name = Console.ReadLine();
                    Console.WriteLine("Kirjuta nimi");
                        if (name== "Illimar")
                        {
                        Console.WriteLine("Su nimi on Illimar (:");
                        }
                        else
                        {
                        Console.WriteLine("sinu nimi ei ole Illimar ):");
                        }
                        break;
                default:
                    Console.WriteLine("Viga tuli proovi uuesti");
                    break;
            }
        }
    }
}