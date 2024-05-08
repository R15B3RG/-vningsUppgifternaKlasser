namespace ÖvningsUppgifternaKlasser;

public class Uppgift14
{
    public static void vokalerSomStjärnor()
    {
        Console.WriteLine("Skriv in en text och se alla vokaler ändras till stjärnor:");

        string input = Console.ReadLine();

        char[] vocals = { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };

        foreach (char vocal in vocals)
        {
            input = input.Replace(vocal.ToString().ToLower(), "*");
            input = input.Replace(vocal.ToString().ToUpper(), "*");
        }

        Console.WriteLine(input);
    }
}