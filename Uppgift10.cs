namespace ÖvningsUppgifternaKlasser;

public class Uppgift10
{
    public static void RadSträngen()
    {
        Console.WriteLine("Skriv in en text:");
        string input;
        input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(input[i]);
        }
    }
}