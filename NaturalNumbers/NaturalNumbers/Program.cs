using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // var
            int sum = 0;
            // looop 1 to 9
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(250);
            }
            // is i divisible by 3 or 5
            // if it is,s tore, remember
        }
    }
}
