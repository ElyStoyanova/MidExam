using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^([%\$])(?<name>[A-Z][a-z]{2,})\1:\s\[(?<num1>\d{1,3})\]\|\[(?<num2>\d{1,3})\]\|\[(?<num3>\d{1,3})\]\|$";
            StringBuilder newText = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex isValid = new Regex(pattern);
               

                if (isValid.IsMatch(input))
                {

                    Match match = isValid.Match(input);

                    string name = match.Groups["name"].Value;
                    int num1 = int.Parse(match.Groups["num1"].Value);
                    int num2 = int.Parse(match.Groups["num2"].Value);
                    int num3 = int.Parse(match.Groups["num3"].Value);

                    char first = (char)num1;
                    char second = (char)num2;
                    char third = (char)num3;

                    newText.Append(first);
                    newText.Append(second);
                    newText.Append(third);

                    Console.WriteLine($"{name} ==> {newText}");
                    newText.Clear();
                }
                else
                {
                    Console.WriteLine("No corect inptut");
                }
            }
        }
    }
}
