using System;
using System.Collections.Generic;

namespace Sieve
{
    class Program
    {
        static List<string> pairs = new List<string>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                FindAmicableSet(i);
            }
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < pairs.Count; i++)
            {
                if (i % 2 != 0 && i > 0)
                {
                    pairs.RemoveAt(i);
                }
            }
            foreach (string pair in pairs)
            {
                Console.WriteLine(pair);
            }
            Console.ResetColor();

        }

        private static int FindFactorSum(int number)
        {
            int factorSum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    factorSum += i;
                }
            }
            return factorSum;
        }

        private static void FindAmicableSet(int startNum)
        {
            
            int startNumFactorSum = FindFactorSum(startNum);
            if (startNum == FindFactorSum(startNumFactorSum) && startNum != startNumFactorSum)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                pairs.Add($"({startNum}), ({startNumFactorSum})");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"({startNum}), ({FindFactorSum(startNumFactorSum)})");
            Console.ResetColor();
        }
    }
}
