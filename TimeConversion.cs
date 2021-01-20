using System;

class Solution
{
    static string timeConversion(string s)
    {
        const string midnight = "00";
        foreach (char item in s)
        {
            if (item == 'P')
            {
                int hourComp = int.Parse(s.Substring(0, 2));
                if (s[0]=='1'&&s[1]=='2')
                {
                    return s.Substring(0,s.Length-2);
                }
                int newHourComp = 12 + hourComp;
                return newHourComp + s.Substring(2, s.Length-4);
            }
            else if(item == 'A')
            {
                if (s[0] == '1' && s[1] == '2')
                {
                    return midnight+s.Substring(2,s.Length-4);
                }
            }
        }
        return s.Substring(0,s.Length - 2);
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
