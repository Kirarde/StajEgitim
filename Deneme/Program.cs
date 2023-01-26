using System.Text.RegularExpressions;


Console.WriteLine("Please input your number:");
Console.ReadLine();
 private static int GetAndValidateNumberAndSymbol(string prompt)
{
    while (true)
    {
        Console.WriteLine(prompt);
        string weirdinput = Console.ReadLine();
        if (!string.IsNullOrEmpty(weirdinput))
        {
            string symboloutcome = Regex.Replace(weirdinput, @"\d()", "");
            string symbol = symboloutcome;
            string numberoutcome = Regex.Replace(weirdinput, @"\D", "'");
            string finaloutcome = Regex.Replace(numberoutcome, "'", symbol);
                 
            int number = Convert.ToInt32(finaloutcome);
            return number;
        }
    }
}