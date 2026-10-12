using System.Security.Cryptography;

namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numberid üks kuni kuus");

            // genereerib juhuslike numberid 1-6
            int RandomNumber = new Random().Next(1, 7);

            
            //kasutab switchi
            //peab kontrollima tulemust ja kuvama vastavalt sõnumilt
            switch (RandomNumber)
            {
                case 1:
                    Console.WriteLine("Said 1");
                    break;
                case 2:
                    Console.WriteLine("said 2");
                    break;
                case 3:
                    Console.WriteLine("said 3");
                    break;
                case 4:
                    Console.WriteLine("said 4");
                    break;
                case 5:
                    Console.WriteLine("said 5");
                    break;
                case 6:
                    Console.WriteLine("said 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
              
            
            }
           
        }
    }
}
