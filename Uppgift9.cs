using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifternaKlasser
{
    public class Uppgift9
    {
        public static void GissaNummer()
        {

            Random random = new Random();

            int num = random.Next(1, 101);

            Console.WriteLine("Gissa ett nummer mellan 1 - 100:");

            int input = int.Parse(Console.ReadLine());

            while (true)

            {
                if (input < num)
                {
                    Console.WriteLine("Du gissade för lågt! Försök igen!");

                    input = int.Parse(Console.ReadLine());
                }
                else if (input > num)
                {
                    Console.WriteLine("Du gissade för högt! Försök igen!");

                    input = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Du gissade rätt! Bra jobbat!");

                    break;
                }
            }
        }
    }
}
