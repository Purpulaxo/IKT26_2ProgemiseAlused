Console.WriteLine("Sisesta värv");
//kasutata switchi
//Sisesta värvi nime
//Red, Green,Blue, White ja Orange
//iga värvi puhul näitab vastava värviga konsooli plus värv
//kui sisestatakse muu värv, siis näitab "Värv puudub"
string värv = Console.ReadLine();

switch (värv)
{
    case "Red":
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("sisestasid värvi Red");
        Console.ResetColor();
        break;
    case "Blue":
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("sisestasid värvi Blue");
        Console.ResetColor();
        break;
    case "Green":
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("sisestasid värvi Green");
        Console.ResetColor();
        break;
    case "White":
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("sisestasid värvi White");
        Console.ResetColor();
        break;
    case "Orange":
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("sisestasid värvi Orange");
        Console.ResetColor();
        break;
    default:
        Console.WriteLine("Värv puudub");
        break;
}
