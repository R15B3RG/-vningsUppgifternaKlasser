namespace ÖvningsUppgifternaKlasser.Uppgift7;

public class Uppgift7
{
    public static void Månader()
    {
        Console.WriteLine("Skriv in en månad:");

        string input = Console.ReadLine().ToLower();

        string[] siffror = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

        int index = -1; // Initiera index som -1 (om inget matchande månad hittas).

        switch (input)
        {
            case "januari":
                index = 0;
                break;
            case "februari":
                index = 1;
                break;
            case "mars":
                index = 2;
                break;
            case "april":
                index = 3;
                break;
            case "maj":
                index = 4;
                break;
            case "juni":
                index = 5;
                break;
            case "juli":
                index = 6;
                break;
            case "augusti":
                index = 7;
                break;
            case "september":
                index = 8;
                break;
            case "oktober":
                index = 9;
                break;
            case "november":
                index = 10;
                break;
            case "december":
                index = 11;
                break;
        }

        if (index != -1)
        {
            Console.WriteLine(siffror[index]);
        }
        else
        {
            Console.WriteLine("Ogiltig månad.");
        }
    }
}