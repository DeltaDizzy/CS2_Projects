using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanksgivingScramble
{
    public static class util
    {
        public static string ListToString(this IOrderedEnumerable<string> list)
        {
            string output = string.Empty;
            foreach (string item in list)
            {
                output += item;
            }
            return output;
        }

        public static List<string> unscrambledWords = new List<string>();
    }
}
