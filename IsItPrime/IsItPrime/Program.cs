using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace IsItPrime
{
    class Program
    {
        static int numtotest = 0;
        static int mode = 0;
        static List<string> factors = new List<string>();
        static List<string> loopPrimes = new List<string>();
        static void Main(string[] args)
        {
            while(true)
            {
                RunProgram();
            }
        }

        private static void RunProgram()
        {
            factors.Add($"{1}");
            PostHeader();

            if (mode == 0)
            {
                while (true)
                {
                    StringBuilder sb = new StringBuilder("Enter a Number\n\n");
                    Console.WriteLine(sb);
                    DoPrimeInputStuff();
                    factors.Clear();
                    factors.Add($"{1}");

                }
            }
            else if (mode == 1)
            {
                DoPrimeLoopStuff();
                loopPrimes.Clear();
            }
            else if (mode == 2)
            {
                DoFirstHundredPrimeStuff();
                loopPrimes.Clear();
            }
        }
        private static void DoPrimeInputStuff()
        {
            numtotest = int.Parse(Console.ReadLine());
            bool prime = CheckPrime(numtotest);
            if (prime)
            {
                factors.Add($"{numtotest}, ");
                Console.WriteLine($"\n{numtotest} is Prime!\n");

            }
            else
            {
                factors.Add($"{numtotest}, ");
                Console.WriteLine($"\n{numtotest} is NOT Prime!\n");
            }
        }

        private static void DoPrimeLoopStuff()
        {
            bool prime = false;
            for (int i = 0; i < 100; i++)
            {
                if (i == 0)
                {
                    continue;
                }

                prime = CheckPrime(i);
                if (prime)
                {
                    loopPrimes.Add($"{i},\n");
                }
            }
            Console.WriteLine("Primes from 1 to 100:\n");
            Console.WriteLine(PrintStringList(loopPrimes));
        }

        private static void DoFirstHundredPrimeStuff()
        {
            bool prime;
            for (int i = 0; i < 1000; i++)
            {
                if (loopPrimes.Count > 100)
                {
                    break;
                }

                if (i < 2)
                {
                    continue;
                }

                prime = CheckPrime(i);
                if (prime)
                {
                    loopPrimes.Add($"{i},\n");
                }
            }
            Console.WriteLine("First 100 Primes:\n");
            Console.WriteLine(PrintStringList(loopPrimes));
        }

        private static string PrintStringList(List<string> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string item in list.Distinct())
            {
                sb.Append(item);
            }
            return sb.ToString().Trim(',');
        }

        private static void PostHeader()
        {
            Console.WriteLine("Would you like to input numbers (0), see the primes from 1-100 (1) or see the first 100 primes (2)?");
            mode = int.Parse(Console.ReadLine());
        }

        private static bool CheckPrime(int num)
        {
            if (num % 2 == 0) // even
            {
                return false;
            }
            else
            {
                for (int i = num; i > 2; i--)
                {
                    if (num % i == 0)
                    {
                        if (num != i)
                        {
                            factors.Add($"{i}");
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
