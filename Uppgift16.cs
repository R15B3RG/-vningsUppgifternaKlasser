using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace ÖvningsUppgifternaKlasser;

public class Uppgift16
{
    public static void MiniräknareAdvanced()
    {
        Console.Write("Skriv in ett enkelt matematiskt uttryck (t.ex. 2 + 3) och tryck Enter: ");

        string input = Console.ReadLine().Replace(" ", "");

        double result = EvaluateExpression(input);
        Console.WriteLine("= " + result);

    }

    static double EvaluateExpression(string expression)
    {

        string[] parts = expression.Split(new[] { "+", "-", "*", "/" }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 2)
        {
            throw new ArgumentException("Ogiltigt uttryck! Försök igen!");
        }

        double operand1 = double.Parse(parts[0]);
        double operand2 = double.Parse(parts[1]);

        char oper = expression.First(c => c == '+' || c == '-' || c == '*' || c == '/');


        switch (oper)
        {
            case '+':
                return operand1 + operand2;
            case '-':
                return operand1 - operand2;
            case '*':
                return operand1 * operand2;
            case '/':
                // Kontrollera division med noll
                if (operand2 == 0)
                    throw new ArgumentException("Det går inte att dela med noll.");
                return operand1 / operand2;
            default:
                throw new ArgumentException("Ogiltig operator.");
        }
    }
}


    

