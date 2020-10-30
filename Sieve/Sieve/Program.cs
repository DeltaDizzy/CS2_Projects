using System;
using System.Collections.Generic;

namespace Sieve
{
    class Program
    {
        static List<string> pairs = new List<string>();
        static List<string> inverses = new List<string>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                FindAmicableSet(i);
                pairs.RemoveAll(p => inverses.Contains(p));
            }
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            
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
            int startNumFactorSumFactorSum = FindFactorSum(startNumFactorSum);
            if (startNum == startNumFactorSumFactorSum && startNum != startNumFactorSum)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if(startNum > startNumFactorSum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    goto writepair;
                }
                pairs.Add($"({startNum}), ({startNumFactorSum})");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            writepair:  Console.WriteLine($"({startNum}) ({startNumFactorSumFactorSum})");
            Console.ResetColor();
        }
    }
}
