namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vokaal ja vajuta enter");

            string vokaal = Console.ReadLine();

            switch (vokaal)
            {
                case "a":
                    Console.WriteLine("sisestasid vokaali a");
                    break;
                case "e":
                   Console.WriteLine("Sisestasid vokaali e");
                    break;
                case "i":
                    Console.WriteLine("sisestasid vokaali i");
                    break;
                default:
                    Console.WriteLine("sisestatud täht ei ole vokaal");
                    break;
            }
        }
    }
}
