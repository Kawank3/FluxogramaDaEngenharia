Console.WriteLine("Está se movendo? (s/n)");
string movendo = Console.ReadLine()!;

if (movendo == "s")
{
    Console.WriteLine("Deveria? (s/n)");
    string deveria = Console.ReadLine()!;

    if (deveria == "s")
    {
        Console.WriteLine("Ótimo.");
    }
    else
    {
        Console.WriteLine("Use fita adesiva.");
    }
}
else
{
    Console.WriteLine("Deveria? (s/n)");
    string deveria = Console.ReadLine()!;

    if (deveria == "s")
    {
        Console.WriteLine("Use WD-40.");
    }
    else
    {
        Console.WriteLine("Ótimo.");
    }
}