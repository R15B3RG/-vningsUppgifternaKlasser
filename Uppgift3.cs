using System.Threading.Channels;

namespace ÖvningsUppgifternaKlasser;

public class Uppgift3
{
    public static void Talet()
    {
        //int number = 100;

        //Console.WriteLine("Skriv ett nummer:");

        //int input = Convert.ToInt32(Console.ReadLine());

        //if (input < number)
        //{
        //    Console.WriteLine("Talet är mindre än 100");
        //}
        //else if (input > number)
        //{
        //    Console.WriteLine("Talet är större än 100");
        //}
        //else
        //{
        //    Console.WriteLine("Talet är lika med 100");
        //}

        //---------------------------------------

        //int number = 100;

        //Console.WriteLine("Skriv ett nummer:");

        //int input = Convert.ToInt32(Console.ReadLine());

        //if (input < number)
        //{
        //    Console.WriteLine($"Talet är mindre än {number}");
        //}
        //else if (input > number)
        //{
        //    Console.WriteLine($"Talet är större än {number}");
        //}
        //else
        //{
        //    Console.WriteLine($"Talet är lika med {number}");
        //}

        //-----------------------------------------

        //int myNum;

        //bool tryOut = true;

        //while (tryOut)
        //{
        //    Console.WriteLine("Skriv in ett nummer:");

        //    string input = Console.ReadLine();

        //    bool isNumber = int.TryParse(input, out myNum);

        //    while (!isNumber && !string.IsNullOrEmpty(input))
        //    {
        //        Console.WriteLine("Du måste skriva in en siffra!");
        //        break;
        //    }

        //    while (isNumber)
        //    {
        //        if (myNum < 100)
        //        {
        //            Console.WriteLine("Talet är mindre än 100");
        //            break;
        //        }
        //        else if (myNum > 100)
        //        {
        //            Console.WriteLine("Talet är större än 100");
        //            break;
        //        }
        //        else if (myNum == 100)
        //        {
        //            Console.WriteLine("Talet är lika med 100");
        //            break;
        //        }
                
        //    }

        //    if (string.IsNullOrEmpty(input))
        //    {
        //        Console.WriteLine("Du skriv inte in något. Have a nice day!");
        //        tryOut = false;

        //        break;
        //    }
            
        //}

        //------------------------------------------------

        int number = 100;

        bool tryOut = true;

        int myNum;

        while (tryOut)
        {
            Console.WriteLine("Skriv in ett tal:");

            bool isNumber = int.TryParse(Console.ReadLine(), out myNum);

            while (!isNumber)
            {
                Console.WriteLine("Du måste använda siffror!");

                break;
            }

            while (isNumber)
            {
                if (myNum < number)
                {
                    Console.WriteLine("Talet är mindre än 100");

                    break;
                }
                else if (myNum > number)
                {
                    Console.WriteLine("Talet är större än 100");

                    break;
                }
                else if (myNum == number)
                {
                    Console.WriteLine("Talet är lika med 100");

                    tryOut = false;

                    break;
                }
                
            }
        }




    }
}