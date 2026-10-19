namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta Esimene number");
            float firstNr = float.Parse(Console.ReadLine());
            Console.WriteLine("Vali tehe: *,/, +, - ");
            string tehe = Console.ReadLine();
            Console.WriteLine("Sisesta teine number");
            float secondNr = float.Parse(Console.ReadLine());
            //nüüd tuleb teha switchi valik, kas *,/, +, -
            //tuleb teha neli case, kus toimub soovitud tehe 
            //peab näitama tehte tulemust 
            //Kasutage floati Parsimisel



            Console.WriteLine("Vastus on ");
            switch (tehe)
            {
               case "+":
                    Console.WriteLine(firstNr + secondNr);
                    break;
               case "-":
                    Console.WriteLine(firstNr - secondNr);
                    break;
               case "*":
                    Console.WriteLine(firstNr * secondNr);
                    break;
               case "/":
                    Console.WriteLine(firstNr / secondNr);
                    if (secondNr == 0)
                    {
                        Console.WriteLine("ERROR");
                    }
                    else if (firstNr == 0)
                    {
                        Console.WriteLine("ERROR");
                    }
                    break;
               default:
                    Console.WriteLine("Viga tuli proovi uuesti");
                    break;

            }
           
        }

    }
}
