namespace Maakulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere");
            //Meil on münt, mille diameeter on 25.75 mm
            //arvuta välja Maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutuses tohib kastada ainult mündi diameetrit ja Maa raadisut 6371 km

            double MaaRadius = 6371000; //m
            double MaaDiameter = MaaRadius * 2;

            double MaaPerimter = 2 * Math.PI * MaaRadius;

            Console.WriteLine("Maa ümbermõõt on " + MaaPerimter.ToString("0.###") + "m");

            double MüntiDiameter = 0.02575; //m
            double MüntiRadius = MüntiDiameter / 2;

            double MüntiPremiter = 2 * Math.PI * MüntiRadius;

            Console.WriteLine("Münti ümbermõõt on " + MüntiPremiter.ToString("0.###") + "m");

            double PaljuMünte = MaaPerimter / MüntiPremiter;
            Console.WriteLine("Kahe euroseid läheb ümber maa {0:0}", PaljuMünte);

        }
    }
}
