namespace PaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string playerChoice = "";
            int playerpoints = 0;
            int computerpoints = 0;

            while (playerChoice != "lõpeta")
            {
                Console.WriteLine("Vali: kivi, paber või käärid.");
                Console.WriteLine("Mängu lõpetamiseks kirjuta: lõpeta");
                //ToLower muudab sinu kirjutatud teksti väikesteks tähdeteks
                playerChoice = Console.ReadLine().ToLower();

                if (playerChoice == "lõpeta")
                {
                    break;
                }
                if (playerChoice != "kivi" &&
                    playerChoice != "paber" &&
                    playerChoice != "käärid")
                {
                    Console.WriteLine("Sellist valikut pole, Proovi uuesti");
                    continue;
                }

                int computerNumber = random.Next(1, 4);
                string computerChoice = "";

                if (computerNumber == 1)
                {
                    computerChoice = "kivi";
                }
                else if (computerNumber == 2) 
                {
                    computerChoice = "paber";

                }
                else
                {
                    computerChoice = "käärid";
                }
                Console.WriteLine($"Arvuti valis: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("VIIK!!");
                }
                else if ((playerChoice != "kivi" && computerChoice == "käärid") ||
                        (playerChoice != "paber" && computerChoice == "kivi") ||
                        (playerChoice != "käärid" && computerChoice == "paber"))
                {
                    Console.WriteLine("Sina võitsid!");
                    playerpoints++;
                }
                else
                {
                    Console.WriteLine("Arvuti võitis!");
                    computerpoints++;
                }
                Console.WriteLine($"Puntid: sina {playerpoints} -- arvuti {computerpoints}");
                Console.WriteLine();
            }
            Console.WriteLine("Mäng on läbi");
            Console.WriteLine($"Lõpptulemus {playerpoints} -- arvuti {computerpoints}");
        }
    }
}
