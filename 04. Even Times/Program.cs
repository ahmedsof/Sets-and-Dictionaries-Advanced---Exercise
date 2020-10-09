using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, int> ocurences = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (!ocurences.ContainsKey(currentNum))
                {
                    ocurences.Add(currentNum, 0);
                }

                ocurences[currentNum]++;
            }

            foreach (var item in ocurences)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}
