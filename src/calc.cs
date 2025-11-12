using System;

namespace idk
{
    class idk
    {
        static void Main()
        {
           Console.WriteLine("Type the symbol for the operation you want to perform.");
            string operation = Console.ReadLine();
            if (operation == "+")
            {
                // Addition
                Console.WriteLine("Type the first number you wanna add.");
                if (decimal.TryParse(Console.ReadLine(), out decimal ad1))
                {
                    // ad1 was successfully converted
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    // ad1 wasn't converted properly
                }
                Console.WriteLine("Now type the second number you wanna add");
                if (decimal.TryParse(Console.ReadLine(), out decimal ad2))
                {
                    // ad2 was successfully converted
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    // ad2 wasn't converted properly
                }
                decimal AddSum = ad1 + ad2;
                Console.WriteLine(AddSum + " Is the sum if those two numbers.");
            }
            if (operation == "-")
                {
                // Subtraction
                Console.WriteLine("Type the number you wanna subtract from.");
                if (decimal.TryParse(Console.ReadLine(), out decimal sub1))
                {
                    // sub1 was successfully converted
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    // sub1 wasn't converted properly
                }
                Console.WriteLine("Now type the amount you wanna subtract from the first number.");
                if (decimal.TryParse(Console.ReadLine(), out decimal sub2))
                {
                    // sub2 was successfully converted
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    // sub2 wasn't converted properly
                }
                decimal SubSum = sub1 - sub2;
                Console.WriteLine(SubSum + " Is your answer.");

            }

            if (operation == "*" || operation == "x")
            {
                // Multiplication
                Console.WriteLine("Type the number you wanna multiply.");
                if (decimal.TryParse(Console.ReadLine(), out decimal mul1))
                {
                    // mul1 was successfully converted
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    // mul1 wasn't converted properly
                }
                Console.WriteLine("Now type the number you wanna multiply the first number by.");
                if (decimal.TryParse(Console.ReadLine(), out decimal mul2))
                {
                    // mul2 was successfully converted
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    // mul2 wasn't converted properly
                }
                decimal MulSum = mul1 * mul2;
                Console.WriteLine(MulSum + " Is your answer.");

            }

            if (operation == "/")
            {
                // Division
                Console.WriteLine("Type the number you wanna have divided.");
                if (decimal.TryParse(Console.ReadLine(), out decimal div1))
                {
                    // div1 was successfully converted
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    // div1 wasn't converted properly
                }
                Console.WriteLine("Now type the number you wanna divide the first one by.");
                if (decimal.TryParse(Console.ReadLine(), out decimal div2))
                {
                    //div2 was properly converted
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    // div2 wasn't converted properly
                }
                if (div2 != 0)
                {
                    decimal DivSum = div1 / div2;
                    Console.WriteLine(DivSum + " Is your answer.");
                }
                else
                {
                    Console.WriteLine("trying to throw a System.DivideByZeroException? try again, lel");
                }

            }

            Console.ReadLine();

        }
    }
}
