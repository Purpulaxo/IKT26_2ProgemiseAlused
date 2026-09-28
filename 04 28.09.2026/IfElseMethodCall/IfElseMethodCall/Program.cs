namespace IfElseMethodCall
{
    internal class Program
    {
        //see on meetod main
        static object Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else
            //kui kasutaja soovib,siis saab ta meetodi välja kutsuda
            Console.WriteLine("Kui soovid meetodit välja kutsuda, siis kirjuta ja ");

            string vastus = Console.ReadLine();
            if (vastus == "ja")
            {
                HelloMethod;
            }
        }

        //tehke uus meetod nimega HelloMethod
        //kirjutage sinna siisse kood, mis kuvab teksti Hello kitty
        static void HelloMethod()
        {
            Console.WriteLine("Hello Kitty");
        }


    }
}

 
  
