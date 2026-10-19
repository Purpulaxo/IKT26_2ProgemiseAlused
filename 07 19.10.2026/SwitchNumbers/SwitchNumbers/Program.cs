namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            //tuleb teha switch, kus esimene case on 10, teine on 20 ja kolmas on 30
            //küsitatakse numbrit ja sisestad konsooli
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                    Console.WriteLine("sisestasid 10");
                    break;

                case 20:
                    Console.WriteLine("sisestasid 20");
                    break;

                case 30:
                    Console.WriteLine("sisestasid 30");
                    break;
                
                default:
                    Console.WriteLine("Sisestasid numbri: " + number);
                    break;
            }

        }


    }
}
