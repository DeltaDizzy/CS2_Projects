using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DiceOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            // dice
            int d1, d2;
            Random rng = new Random();
            int total;
            int[] r = new int[13];
                // get how many rolls
            Console.WriteLine("How many rolls?");
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            // do all the rolls
            for (int i = 0; i < times; i++)
            {
                d1 = rng.Next(1,7);
                d2 = rng.Next(1, 7);
                total = d1 + d2; // 2-12
                r[total]++;
            }

            int rind=0; // index of item
            foreach (int item in r)
            {
                rind = Array.FindIndex(r, w => w == item); // get index of item
                if (rind > 1) // if its 2 or above
                {
                    Console.WriteLine($"Value {rind} occurred {r[rind]} times, which is {String.Format("{0:0.000}",(double)r[rind]/times*100)}% of the time.");
                }
            }
            Console.WriteLine();

            while (!Console.KeyAvailable)
            {
                Thread.Sleep(250);
            }
        }
    }
}
