using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command!="Finish")
            {
                string[] tokans = command.Split(" ");
                string action = tokans[0];

                switch (action)
                {
                    case "Replace":
                        string currentChar = tokans[1];
                        string newChar = tokans[2];
                        input = input.Replace(currentChar, newChar);
                        Console.WriteLine(input);
                        break;
                    case "Cut":
                        int startIndex =int.Parse( tokans[1]);
                        int endIndex = int.Parse(tokans[2]);
                        input = input.Remove(startIndex,endIndex-1);
                        Console.WriteLine(input);
                        break;
                    case "Make":
                        string upperOrLower = tokans[1];
                       
                        if (upperOrLower=="Upper")
                        {
                            input = input.ToUpper();
;                       }
                        else
                        {
                            input = input.ToLower();
                        }
                        Console.WriteLine(input);
                        break;
                    case "Check":
                        string givenString = tokans[1];

                        if (input.Contains(givenString))
                        {
                            Console.WriteLine($"Message contains {givenString}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {givenString}");
                        }
                        break;
                    case "Sum":
                        int stratIndex = int.Parse(tokans[1]);
                        int enddIndex = int.Parse(tokans[2]);
                        int sum = 0;

                        if (stratIndex>=0 && stratIndex<input.Length && enddIndex>=0 && enddIndex<input.Length)
                        {
                            string substring = input.Substring(stratIndex, enddIndex - 1);
                            foreach (char item in substring)
                            {
                                sum += (int)item;
                            }
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        
                        
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
