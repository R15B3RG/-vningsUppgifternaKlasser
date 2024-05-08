namespace ÖvningsUppgifternaKlasser;

public class Uppgift13
{
    public static void textBaklänges()
    {
        Console.WriteLine("Skriv in en text:");

        string input = Console.ReadLine();

        string reverse = input;

        for (int i = input.Length - 1; i > -1; i--)
        {
            Console.Write(input[i]);
        }
    }
}