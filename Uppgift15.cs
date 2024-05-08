namespace ÖvningsUppgifternaKlasser;

public class Uppgift15
{
    public static void Palindrom()
    {
        Console.WriteLine("Skriv in ett ord för att kolla om det är ett Palindrom:");

        string input = Console.ReadLine().ToLower();

        string reverse = String.Empty;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse += input[i];
        }

        if (input == reverse)
        {
            Console.WriteLine("Detta är ett Palindrom");
        }
        else
        {
            Console.WriteLine("Detta är inget Plaindrom");
        }
    }
}