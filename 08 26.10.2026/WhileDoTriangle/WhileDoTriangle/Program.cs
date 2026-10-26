namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Le Triangle");
            //otsi internetist while koodiga kolmnurga
            //kujunedeid e tegemise viise 
            //kui kood on leitud, siis kurjutada see siia alla
            int n = 10; 
            int i = 1; 

            while (i <= n)
            {
                int l = 1; 

                while (l <= i)
                {
                    
                    Console.Write(l + " ");
                    l++;
                }

                Console.WriteLine(); 
                i++;
            }

        }

    }

    }

