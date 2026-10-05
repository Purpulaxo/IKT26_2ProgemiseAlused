namespace IfAndElseHindamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta midu punkti said");
            int pt = int.Parse(Console.ReadLine());
            
                if (pt >= 0 && pt <= 25)
                {
                Console.WriteLine("Sinu tulemus on " + pt + " punkti");
                }
                else if (pt >= 26 && pt <= 50)
                {
                Console.WriteLine("Sinu tulemus on " + pt + " punkti");
                }
                else if (pt >= 51 && pt <= 75)
                {
                Console.WriteLine("Sinu tulemus on " + pt + " punkti");
                }
                else if (pt >= 76 && pt <= 100)
                {
                Console.WriteLine("Sinu tulemus on " + pt + " punkti");
                }
                else
                {
                Console.WriteLine("Number mis sisestasid ei ole 0-100 vahemikus palun sisesta uuesti");
                
                }
        }
    }
}
