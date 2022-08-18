using System;
using System.Collections.Generic;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var heroList = new Dictionary<string, List<string>>();

            while (input!="End")
            {
                string[] tokans = input.Split(" ");
                string command = tokans[0];
                string heroName = tokans[1];

                switch (command)
                {
                    case "Enroll":
                       
                        if (!heroList.ContainsKey(heroName))
                        {
                            heroList.Add(heroName,new List<string>());
                            
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }
                        break;
                    case "Learn":
                        string spellName = tokans[2];

                        if (!heroList.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else
                        {
                            if (heroList[heroName].Contains(spellName))
                            {
                                Console.WriteLine($"{heroName} has already learnt {spellName}.");
                            }
                            else
                            {
                                heroList[heroName].Add(spellName);
                            }
                        }

                            break;
                    case "Unlearn":
                        string newSpelName = tokans[2];

                        if (!heroList.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                       else if (heroList[heroName].Contains(newSpelName))
                             {
                            heroList[heroName].Remove(newSpelName);
                             }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {newSpelName}.");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Heroes:");
            foreach (var hero in heroList)
            {
                Console.Write("== ");
                Console.Write($"{hero.Key}: ");
                Console.WriteLine(string.Join(", ",hero.Value));
               
            }
        }
           
    }
}
