namespace Switch_töö_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kas tehe, linn või meetod");

            string input = Console.ReadLine();




            switch (input)
            {
                case "tehe":

                    Console.WriteLine("sisesta esimene number");
                    float firstNR = float.Parse(Console.ReadLine());
                    Console.WriteLine("Sisesta / ");
                    string tehe = Console.ReadLine();
                    Console.WriteLine("Sisesta teine number");
                    float secondNR = float.Parse(Console.ReadLine());
                    Console.WriteLine("vastus on " + firstNR / secondNR);
                    break;
                case "linn":
                    Console.WriteLine("Mis on sinu kodulinn?");
                    string linn = Console.ReadLine();
                    Console.WriteLine("Sinu kodulinn on " + linn);
                    break;
                case "meetod":
                    
                    {
                         HurraaMethod();
                    }


                    break;
                default:
                    Console.WriteLine("Viga tuli proovi uuesti");
                    break;

                   
            }

           
            static void HurraaMethod()
            {
                Console.WriteLine("Hurraa!");
            }
        

        

        }

         
            
    }
}


