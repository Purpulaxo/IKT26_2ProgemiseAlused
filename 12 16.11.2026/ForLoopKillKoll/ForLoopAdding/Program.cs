namespace ForLoopKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljutaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //jne
            //kasutada for loopi ja kasutaja saab sisestada korduse arvu


            Console.WriteLine("Sisesta korduste arv");
            Console.WriteLine("--------------------");
            Console.WriteLine("\n\n");
            int loop = int.Parse(Console.ReadLine());


            for (int i = 1; i < loop; i++)
            {
                Console.WriteLine("see on rida nr {0}", i);
                Console.WriteLine("kill-koll ");
                Console.WriteLine("kill-koll ");
                Console.WriteLine("killadi-koll");
            }
        }
    }
}
