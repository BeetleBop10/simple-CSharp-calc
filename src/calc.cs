using System;
using System.Globalization;

namespace Calc
{
    class calc
    {
        static void Main()
        {
            Console.WriteLine("Calc v0.1.2.1, ")
           Console.WriteLine("Type the symbol for the operation you want to perform.");
           string operation = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();

           if (!TryReadInt("How many numbers are in the equation? (enter an integer >= 2)", out int count) || count < 2)
           {
               Console.WriteLine("You must enter an integer >= 2.");
               return;
           }

           switch (operation)
           {
               case "+":
               {
                   decimal sum = 0m;
                   for (int i = 1; i <= count; i++)
                   {
                       if (!TryReadDecimal($"Enter number {i}:", out decimal n)) return;
                       sum += n;
                   }
                   Console.WriteLine($"{sum} Is the sum.");
                   break;
               }

               case "-":
               {
                   if (!TryReadDecimal("Enter number 1:", out decimal result)) return;
                   for (int i = 2; i <= count; i++)
                   {
                       if (!TryReadDecimal($"Enter number {i}:", out decimal n)) return;
                       result -= n;
                   }
                   Console.WriteLine($"{result} Is your answer.");
                   break;
               }

               case "*":
               case "x":
               {
                   decimal product = 1m;
                   for (int i = 1; i <= count; i++)
                   {
                       if (!TryReadDecimal($"Enter number {i}:", out decimal n)) return;
                       product *= n;
                   }
                   Console.WriteLine($"{product} Is your answer.");
                   break;
               }

               case "/":
               {
                   if (!TryReadDecimal("Enter number 1 (numerator):", out decimal result)) return;
                   for (int i = 2; i <= count; i++)
                   {
                       if (!TryReadDecimal($"Enter number {i} (divisor):", out decimal n)) return;
                       if (n == 0m)
                       {
                           Console.WriteLine("Trying to throw a System.DivideByZeroException? Good luck, lel");
                           return;
                       }
                       result /= n;
                   }
                   Console.WriteLine($"{result} Is your answer.");
                   break;
               }

               case "^":
               {
                   if (!TryReadDouble("Enter number 1 (base):", out double dresult)) return;
                   for (int i = 2; i <= count; i++)
                   {
                       if (!TryReadDouble($"Enter number {i} (exponent):", out double n)) return;
                       dresult = Math.Pow(dresult, n);
                   }
                   Console.WriteLine($"{dresult} Is your answer.");
                   break;
               }

               default:
                   Console.WriteLine("Invalid op. Try +, -, *, x, /, or ^ instead?");
                   break;
           }

           Console.WriteLine("Press any key to exit");
           Console.ReadKey();
        }

        static bool TryReadDecimal(string prompt, out decimal value)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out value))
                return true;

            Console.WriteLine("Invalid number input.");
            value = 0m;
            return false;
        }

        static bool TryReadDouble(string prompt, out double value)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(input, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out value))
                return true;

            Console.WriteLine("Invalid number input.");
            value = 0.0;
            return false;
        }

        static bool TryReadInt(string prompt, out int value)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
                return true;

            Console.WriteLine("Invalid integer input.");
            value = 0;
            return false;
        }
    }
}
