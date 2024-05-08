using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace ÖvningsUppgifternaKlasser;

public class Uppgift11
{
    public static void BokstäverSiffror()
    {
        string[] Siffror = { "Noll", "Ett", "Två", "Tre", "Fyra", "Fem", "Sex", "Sju", "Åtta", "Nio" };

        Console.WriteLine("Var god och skriv in en eller flera siffror:");

        string input = Console.ReadLine();

        if (input.Length == 1)
        {
            int siffra = int.Parse(input);

            if (siffra >= 0 && siffra <= 9)
            {
                Console.WriteLine(Siffror[siffra]);
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning");
            }
        }
        else
        {
            for (int i = 0; i < input.Length; i++)
            {
                int siffra = int.Parse(input[i].ToString());    

                if (siffra >= 0 && siffra <= 9)
                {
                    Console.Write(Siffror[siffra]);
                   
                }

                else
                {
                    Console.WriteLine("Ogiltig inmatning");
                    return;
                }
            }
            
        }
        
    }
}