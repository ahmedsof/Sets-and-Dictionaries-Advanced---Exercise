using System;
using System.Collections.Generic;
using System.Dynamic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> occurences = new SortedDictionary<char, int>();

            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if (!occurences.ContainsKey(current))
                {
                    occurences.Add(current, 0);
                }

                occurences[current]++;

            }

            foreach (var item in occurences)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }


            
        }
    }
}
