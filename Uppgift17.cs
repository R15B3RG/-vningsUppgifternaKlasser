using System.Threading.Channels;

namespace ÖvningsUppgifternaKlasser;

public class Uppgift17
{
    public static void FärgText()
    {
        int i = 0;

        Console.WriteLine("Mata in en text:");
        string input = Console.ReadLine();

        Console.WriteLine("Mata nu in den delen av din föregående text som du vill ha utskriven i en annan färg:");

        string input2 = Console.ReadLine();

        int inputLength = input.Length;


        if (!input.Contains(input2))
        {
            Console.WriteLine("Din andra inmatning fanns ej i din första inmatning");
        }

        else
        {
            while (i < inputLength && !input.Contains(input2))
            {
                int startIndex = i;
                i++;

                if (i < inputLength && input == input2)
                {
                    int endIndex = i;

                    string validNumber = input.Substring(startIndex, endIndex - startIndex + 1);

                    Console.WriteLine(validNumber);
                }
            }
        }

    }
}