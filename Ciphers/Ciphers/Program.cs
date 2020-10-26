using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciphers
{
    class Program
    {
        static bool showbox = false;
        static string toEncrypt, encrypted = "";
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            while(true)
            {
                toEncrypt = Console.ReadLine();

                if (toEncrypt == "0")
                {
                    break;
                }

                encrypted = Encrypt(toEncrypt);
                Console.WriteLine(encrypted.ToUpper());
                sb.Clear();
            }
        }

        static string Encrypt(string input)
        {
            List<string> chars = ToStringList(input.ToCharArray());
            chars.RemoveAll(c => c == " ");
            if (chars.Count % Math.Sqrt(chars.Count) != 0)
            {
                return $"Message could not be boxed, SQRT Length = {Math.Sqrt(chars.Count)}";
            }
            //Console.WriteLine($"BOX LENGTH:{Math.Sqrt(chars.Count)}\nCHAR COUNT: {chars.Count}");
            WriteList(chars);
            int boxSize = (int)Math.Sqrt(chars.Count);
            string[] rows = new string[boxSize];
            for (int i = 0; i < boxSize; i++)
            {
                for (int n = i; n < chars.Count; n+=boxSize)
                {
                    rows[i] += chars[n];
                }
            }
            for (int i = 0; i < rows.Length; i++)
            {
                if (showbox)
                {
                    sb.Append($"{rows[i]}\n");
                }
                else
                {
                    sb.Append(rows[i]);
                }
            }
            return sb.ToString();
        }

        static void WriteList(List<string> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string item in list)
            {
                sb.Append($"{item}, ");
            }
            Console.WriteLine(sb);
        }

        static List<string> ToStringList(char[] array)
        {
            List<string> slist = new List<string>();
            foreach (char item in array)
            {
                slist.Add(item.ToString());
            }
            return slist;
        }
        
    }
}
