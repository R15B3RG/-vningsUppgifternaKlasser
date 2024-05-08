namespace ÖvningsUppgifternaKlasser;

public class Uppgift8
{
    public static void DubblaSiffran()
    {

        //for (int i = 1; i < 35000; i = i * 2)
        //{
        //    Console.WriteLine(i);
        //}

        int num = 1;

        for (int i = 1; i <= 16; i++)
        {
            Console.WriteLine(num);
            num *= 2; // Dubbla numrets värde för varje iteration
        }
    }
}