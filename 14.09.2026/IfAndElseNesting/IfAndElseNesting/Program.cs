namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            //muutuja nimega y on double e
            //komakohaga arv ja väärtsus on 9
            double y = 20.5;

            if (y == 9) 
            {
                //kui panen if-i sisse teise if-i
                //siis se on nested if ehk pesastatud if
                if (y == 11) 
                {
                    Console.WriteLine("vastus on 11");
                }
                else
                {
                    Console.WriteLine("vastus on kõike peale 11");
                }
            }
            else if (y == 20.5)
            {
                Console.WriteLine("vastus on 20.5");
            }
            else if (y == 30)
            {
                Console.WriteLine("vastus on 30");
            }
            else
            {
                Console.WriteLine("mingi kahtlane number");
            }
        }
    }
}
