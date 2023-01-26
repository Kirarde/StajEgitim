using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            double sayi1 = GetAndValidateNumber("Enter your first number:");
            while (true)
            {
                double sayi2 = GetAndValidateNumber("Enter your second number:");
                string symbol = GetAndValidateSymbol("Please select your symbol. '+,-,*,/'");

                switch (symbol)
                {
                    case "+":
                        result = sayi1 + sayi2;
                        Console.WriteLine("result:" + result);
                        sayi1 = result;
                        break;
                    case "-":
                        result = sayi1 - sayi2;
                        Console.WriteLine("result:" + result);
                        sayi1 = result;
                        break;
                    case "*":
                        result = sayi1 * sayi2;
                        Console.WriteLine("result:" + result);
                        sayi1 = result;
                        break;
                    case "/":
                        try
                        {
                            result = sayi1 / sayi2;
                            Console.WriteLine("result:" + result);
                            sayi1 = result;
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;
                }
                Console.WriteLine("Çıkmak için 'q'ya bas'");
                Console.WriteLine("Devam etmek için herhangi bir tuşa bas");
                ConsoleKeyInfo cikis = Console.ReadKey();
                if (cikis.Key == ConsoleKey.Q)
                {
                    Environment.Exit(0);
                }
            }
        }

        private static double GetAndValidateNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number) && !string.IsNullOrWhiteSpace(input))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        private static string GetAndValidateSymbol(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string symbol = Console.ReadLine();
                if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/")
                {
                    return symbol;
                }
                else
                {
                    Console.WriteLine("Please enter a valid symbol.");
                }
            }
        }
    }
}