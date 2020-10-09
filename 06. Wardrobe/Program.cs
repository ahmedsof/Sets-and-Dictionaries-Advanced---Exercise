using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ").ToArray();
                var color = input[0];
                var clotes = input[1].Split(",").ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clotes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clotes[j]))
                    {
                        wardrobe[color].Add(clotes[j], 0);

                    }

                    wardrobe[color][clotes[j]]++;
                }
            }

            var cloatingToFind = Console.ReadLine().Split(" ").ToArray();

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var clothing in item.Value)
                {
                    Console.Write($"* {clothing.Key} - {clothing.Value}");

                    if (clothing.Key == cloatingToFind[1] && item.Key == cloatingToFind[0])
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
