namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseivalt");
            Console.WriteLine("Teise else if-i sisse panna if ja else");
            double x = 1;

            if (x == 2)
            {


            }
            else if (x == 4)
            {
                Console.WriteLine("Vasuts on 4");

                if (x == 3)
                {
                    Console.WriteLine("vatus on 3");
                }
                else { Console.WriteLine("vastus ei ole 3"); }
            }
            else if (x == 5) ;

            else

                Console.WriteLine("mingi kahtlane number");
        }

    }
}
    

