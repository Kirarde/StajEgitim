Solution solution = new Solution();
Console.WriteLine(solution.Calculate("(3+4)*5"));
public class Solution
{
    public int Calculate(string s)
    {
        if (s == null || s == string.Empty)
            return 0;

        Stack<string> rpn = new Stack<string>(),
                      opt = new Stack<string>();
        int j = 0;

        s = s.Trim().Replace(" ", string.Empty);
        s = s.Trim().Replace("(", string.Empty);
        s= s.Trim().Replace(")", string.Empty);

        for (int i = 0; i < s.Length; i++)
            if (s[i] >= '0' && s[i] <= '9')
                continue;
            else if (s[i] == '+' || s[i] == '-')
            {
                rpn.Push(s.Substring(j, i - j));

                while (opt.Count > 0)
                {
                    string v2 = rpn.Pop(),
                           v1 = rpn.Pop();

                    rpn.Push(Cal(v1, v2, opt.Pop()).ToString());
                }

                opt.Push(s[i].ToString());
                j = i + 1;
            }
            else if (s[i] == '*' || s[i] == '/')
            {
                rpn.Push(s.Substring(j, i - j));

                while (opt.Count > 0 && opt.Peek() != "+" && opt.Peek() != "-")
                {
                    string v2 = rpn.Pop(),
                           v1 = rpn.Pop();

                    rpn.Push(Cal(v1, v2, opt.Pop()).ToString());
                }

                opt.Push(s[i].ToString());
                j = i + 1;
            }
           

        rpn.Push(s.Substring(j, s.Length - j));

        while (opt.Count > 0)
        {
            string v2 = rpn.Pop(),
                   v1 = rpn.Pop();

            rpn.Push(Cal(v1, v2, opt.Pop()).ToString());
        }

        return Convert(rpn.Peek());
    }

    private int Cal(string v1, string v2, string opt)
    {
        int result = 0;

        if (opt == "+")
            result = Convert(v1) + Convert(v2);
        else if (opt == "-")
            result = Convert(v1) - Convert(v2);
        else if (opt == "*")
            result = Convert(v1) * Convert(v2);
        else if (opt == "/")
            result = Convert(v1) / Convert(v2);
        else if (opt == "(")
            result = 0;
        else if (opt == ")")
            result = 0;
        return result;
    }

    private int Convert(string s)
    {
        int i = 0,
            j = s[0] == '-' ? 1 : 0;

        for (; j < s.Length; j++)
            i = i * 10 + (s[j] - '0');

        return s[0] == '-' ? i * -1 : i;
    }
}