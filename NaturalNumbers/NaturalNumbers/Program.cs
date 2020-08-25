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

            NormalSum();
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(250);
            }
        }

        public static void NormalSum()
        {
            // var
            int sum = 0,n,m;
            // looop 1 to 9
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                    // 233168
                }
            }

            Console.WriteLine(sum);
        }
    }
}
