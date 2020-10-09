﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                foreach (var item in input)
                {
                    elements.Add(item);
                }
            }

            var sorted = elements.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
