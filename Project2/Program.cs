using System;
using System.Text.RegularExpressions;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([$%])(?<request>[A-Z][a-z]{2,})\1: \[(?<num1>[0-9]+)\]|\[(?<num2>[0-9]+)\]|\[(?<num3>[0-9]+)\]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            string name = string.Empty;

            if (matches.Count==0)
            {
                Console.WriteLine("Valid message not found!");
            }
            foreach (Match match in matches)
            {
                var request = match.Groups["request"].Value;
                int num1 = int.Parse(match.Groups["num1"].Value);
                name += (char)num1;

                int num2 = int.Parse(match.Groups["num2"].Value);
                name += (char)num2;

                int num3 = int.Parse(match.Groups["num3"].Value);
                name += (char)num3;

                Console.WriteLine($"{request}: {name}");
            }
        }
    }
}
