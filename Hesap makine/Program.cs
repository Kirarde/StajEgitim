namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            //string value = "y";

            //while (value == "Y" || value == "y")
           // {
                //Console.Clear();
                Console.WriteLine("Enter your first number.");
                var sayi12 = Console.ReadLine();
                while (!int.TryParse(sayi12, out int option))
                {
                    Console.WriteLine("integer giriniz");
                    sayi12 = Console.ReadLine();
                }
                int sayi1 = Convert.ToInt32(sayi12);

           
                Console.WriteLine("Enter your second number.");

                var sayi22 = Console.ReadLine();
            while (true)
            {
                while (!int.TryParse(sayi22, out int option))
                {
                    Console.WriteLine("integer giriniz");
                    sayi22 = Console.ReadLine();
                }
                int sayi2 = Convert.ToInt32(sayi22);
                Console.WriteLine("Please select your symbol. '+,-,*,/'");
                string symbol = Console.ReadLine();

                while (symbol != "+" && symbol != "-" && symbol != "/" && symbol != "*")
                {
                    Console.WriteLine("enter a valid input");
                    symbol = Console.ReadLine();
                }



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
                        result = sayi1 / sayi2;
                        Console.WriteLine("result:" + result);
                        sayi1 = result;
                        break;

                }


                Console.WriteLine("Devam etmek istiyorsanız başka bir sayı giriniz :");
                sayi22= Console.ReadLine();
            }
            }





        }


    }




