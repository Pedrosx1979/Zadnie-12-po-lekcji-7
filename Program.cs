
using System;

Console.WriteLine("Jaki mamy dziś dzień tygodnia");

int day = Int32.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Poniedziałek");
        break;

    case 2:
        Console.WriteLine("Wtroek");
        break;

    case 3:
        Console.WriteLine("Środa");
        break;

    case 4:
        Console.WriteLine("Czwartek");
        break;

    case 5:
        Console.WriteLine("Piątek");
        break;

    case 6:
        Console.WriteLine("Sobota");
        break;

    case 7:
        Console.WriteLine("Niedziela");
        break;

    default:
        Console.WriteLine("Tydzień ma tylko 7 dni :)");
        break;

}


/*int a = Int32.Parse(Console.ReadLine());


if (a == 1)
{
    Console.WriteLine("Poniedziałek");
}
else if (a == 2)
{
    Console.WriteLine("Wtorek");
}
else if (a == 3)
{
    Console.WriteLine("Środa");
}
else if (a == 4)
{
    Console.WriteLine("Czwartek");
}
else if (a == 5)
{
    Console.WriteLine("Piątek");
}
else if (a == 6)
{
    Console.WriteLine("Sobota");
}
else if (a == 7)
{
    Console.WriteLine("Niedziela");
}
else
{
    Console.WriteLine("Mamy tylko 7 dni");
}*/


