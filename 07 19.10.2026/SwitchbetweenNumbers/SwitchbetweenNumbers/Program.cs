namespace SwitchbetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number vahemikus 0 kuni 300");
            //esimese koondtulemuse puhul on number vahemikus
            //0 kuni 100
            //Teise puhul 101 kuni 200 ja
            //kolmanda puhul 201 kuni 300
            //kasuta switchi 
            //parsige tähemark numbriks
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("sisestasid numbri vahemikus 0 kuni 100");
                    break;
                case >= 101 and <= 200:
                    Console.WriteLine("sisestasid numbri vahemikus 101 kuni 200");
                    break;
                case >= 201 and <= 300:
                    Console.WriteLine("sisestasid numbri vahemikus 201 kuni 300");
                    break;
                default:
                    Console.WriteLine("number  ei ole vahemikus 0 kuni 300");
                    break;
            }

        }
    }
}
