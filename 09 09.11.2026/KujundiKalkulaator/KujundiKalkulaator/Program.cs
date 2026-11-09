namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere");

            //ruudu sees asub ring. ringi raadius on 3 ühikut
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3;
            int diameter = roundRadius * 2;

            double squareArea1 = Math.Pow(diameter, 2);
            double squaerArea2 = diameter * diameter;

            double squarePerimeter = diameter * 4; 

            Console.WriteLine("Ruudu pindala: " + squareArea1);
            Console.WriteLine("Ruudu ümbermõõt: " + squarePerimeter);

            //arvuta ringi pindala ja ümbermõõt
            int RoundRadius = 3;
            int Diameter = RoundRadius * 2;

            double RoundArea1 = Math.PI * Math.Pow(Diameter, 2);
            double RoundArea2 = Math.PI * (RoundRadius * RoundRadius);

            double RoundPerimeter = 2 * Math.PI * RoundRadius;
            //kuidas teha, et maksimaalselt kaks kohta pärast koma oleks

            Console.WriteLine("Ringi pindala: " + RoundArea2.ToString("0.##"));
            //# arv määrab kui palju kohti pärast koma on
            Console.WriteLine("Ringi ümbermõõt: " + RoundPerimeter.ToString("0.##"));
        }
    }
}
