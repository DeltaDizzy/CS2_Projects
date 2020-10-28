using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HowFast
{
    class Program
    {
        static List<string> loopPrimes = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key to start!");
            Console.ReadKey();
            Console.WriteLine();
            var sw = Stopwatch.StartNew();
            RunProgram();
            sw.Stop();
            TimeSpan time = sw.Elapsed;
            string printedTime = String.Format("{0:00}.{1:00}",
                time.Seconds, time.Milliseconds / 10);
            Console.WriteLine($"\n\nElapsed Time: {printedTime}");
        }

        private static void RunProgram()
        {
            DoPrimesUnderTwoMillionStuff();
            loopPrimes.Clear();
        }

        private static void DoPrimesUnderTwoMillionStuff()
        {
            bool prime = false;
            for (int i = 0; i < 250000; i++)
            {
                if (i == 0)
                {
                    continue;
                }

                prime = CheckPrime(i);
                if (prime)
                {
                    loopPrimes.Add($"{i}");
                }
            }
            Console.WriteLine("Primes under two million:\n");
            Console.WriteLine(PrintStringList(loopPrimes));
            Console.WriteLine($"\n\nSum of Primes: {ListSum(loopPrimes)}");
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
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        private static string PrintStringList(List<string> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string item in list.Distinct())
            {
                sb.Append($"{ item}, ");
            }
            return sb.ToString();
        }

        private static ulong ListSum(List<string> list)
        {
            List<int> numbers = new List<int>();
            ulong sum = 0;
            foreach (string item in list)
            {
                numbers.Add(int.Parse(item));
            }
            foreach (int item in numbers)
            {
                sum += (ulong)item;
            }

            return sum;
        }
    }
}
