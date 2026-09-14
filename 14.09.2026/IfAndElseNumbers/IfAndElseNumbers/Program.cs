namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");

            //peate kasutama if and else lasueid,
            //et kontrollida, kas kasutaja vanus 
            //on suurem kui 18 või väiksem kui 18

            //saab kasutada concerti ja parse-t
            //int vanus = conver.ToInt32(Console.Readline());

            String userinput = Console.ReadLine();

            int vanus = int.Parse(userinput);

            if (vanus > 18)
            {
                Console.WriteLine("Sa oled täisealine");
            }
            else if (vanus < 18)
            {
                Console.WriteLine("Sa oled alaealine");
            }
           
           
        }
    }
}
