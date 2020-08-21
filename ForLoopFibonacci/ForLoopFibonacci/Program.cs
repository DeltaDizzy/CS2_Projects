using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForLoopFibonacci
{
    class Program
    {
        static int?[] sequence = new int?[20];
        static List<int?> modulo7Sequence = new List<int?>();
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci-O-Matic 3000");
            Console.WriteLine();
            Console.WriteLine("Press a key to start!");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();


            sequence[0] = 1;
            sequence[1] = 2;
            Console.WriteLine($"{1}. {sequence[0]}");
            Console.WriteLine($"{2}. {sequence[1]}");
            for (int i = 2; i < 20; i++)
            {
                NextFibonacci(i);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The following numbers are evenly divisible by 7:");
            Console.WriteLine();
            foreach (int number in modulo7Sequence)
            {
                Console.WriteLine(number);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void NextFibonacci(int index)
        {
            if (sequence[index] == null) // if we havent gotten here yet
            {
                sequence[index] = sequence[index - 1] + sequence[index - 2];
                if (sequence[index] % 7 == 0)
                {
                    modulo7Sequence.Add(sequence[index]);
                }
            }
            Console.WriteLine($"{index+1}. {sequence[index]}");
           
        }
    }
}
