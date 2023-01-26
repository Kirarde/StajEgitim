using System;
using System.Text.RegularExpressions;

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
                Console.WriteLine("Press 'Q' to quit or press anything to continue");
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
        //private static int GetAndValidateNumberAndSymbol(string prompt)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine(prompt);
        //        string weirdInput = Console.ReadLine();
        //        if (!string.IsNullOrEmpty(weirdInput))
        //        {
        //            string strWithP = weirdInput.Remove(0, 1);
        //            string strWithPp = strWithP.Remove(strWithP.Length-1, 1);

        //            //string symbolWithP = weirdInput.Remove(0, 1);
        //            //string symbolWithPp = symbolWithP.Remove(symbolWithP.Length - 1, 1);
        //            //string symbolOutcome = Regex.Replace(symbolWithPp, @"\d", "");
        //            //string symbol = symbolOutcome;
        //            //string numberWithP = weirdInput.Remove(0,1);
        //            //string numberWithPp = numberWithP.Remove(numberWithP.Length-1,1);
        //            //string numberOutcome = Regex.Replace(numberWithPp, @"\D", "'");
        //            //string finalOutcome = Regex.Replace(numberOutcome, "'", symbol);

        //            int number = int.Parse(strWithPp);
        //            return number;
        //        }
        //    }
        //}
    }
}