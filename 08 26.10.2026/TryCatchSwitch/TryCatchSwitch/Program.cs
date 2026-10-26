namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try catch swtich!");

            try
            {
                int nr = int.Parse(Console.ReadLine());
                switch (nr)
                {
                    case 1:
                        Console.WriteLine("Valisid 1");
                        break;

                    case 2:
                        Console.WriteLine("valisid 2");
                        break;
                }
            }
            //vormi viga
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta number");
            }
            //antu juhul on lubatud maksimaalselt 32-bit-ne number
            catch
            {
                Console.WriteLine("Number on liiga suur");
            }
        }

    }
}
