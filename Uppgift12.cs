namespace ÖvningsUppgifternaKlasser;

public class Uppgift12
{
    public static void OmvändOrdning()
    {
        Console.WriteLine(
            "Här ska du få mata in ett antal siffror. Välj först hur många siffror du vill skriva in (minst 2 och högst 9:");

        string input = Console.ReadLine();
        int num = -1;

        List<int> Reverse = new List<int>();

        while (true)
        {
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Detta är ingen siffra. Skriv in en siffra:");

                input = Console.ReadLine();

                Console.Clear();

            }

            else

            {
                if (num < 2 && num > 9)
                {
                    Console.WriteLine("Fel inmatning! Försök igen!");

                    input = Console.ReadLine();
                }

                else if (num > 1 && num < 10)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        Console.WriteLine("Skriv in tal " + i);

                        int input2 = Convert.ToInt32(Console.ReadLine());

                        Reverse.Add(input2);
                    }

                    Console.WriteLine("Här kommer talen i omvänd ordning: ");

                    for (int i = Reverse.Count - 1; i >= 0; i--)
                    {
                        Console.Write(Reverse[i]);

                    }
                }
            }

            break;
        }

    }

}





