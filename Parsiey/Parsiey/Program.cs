using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Parsiey
{
    class Program
    {
        static string promptText = "Enter a Sentence to Translate it";
        static List<string> matchlist = new List<string>();
        static Regex parselTest = new Regex(@"([b-df-hj-np-tv-xz]{1,})|([aeiouy]+)", RegexOptions.IgnoreCase);
        static Regex vowelTest = new Regex(@"[aeiouy]+", RegexOptions.IgnoreCase);
        static Regex consonantTest = new Regex(@"[b-df-hj-np-tv-xz]{1,}", RegexOptions.IgnoreCase);
        static MatchCollection parselmatches, vowelmatches, consonantmatches;
        static string result = string.Empty;
        static void Main(string[] args)
        {
            while (true)
            {
                HandleInput(Prompt(promptText));
            }
        }

        private static string Prompt(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        private static void HandleInput(string input)
        {
            
            if (input == "QUIT")
            {
                Environment.Exit(0);

            }
            // split string
            List<string> inputlist = SplitString(input).ToList();
            // match
            parselmatches = parselTest.Matches(input);
            matchlist.AddRange(MatchToString(parselmatches));
            vowelmatches = vowelTest.Matches(input);
            consonantmatches = consonantTest.Matches(input);
            //insert strings
            foreach (Match match in parselmatches)
            {
                if (match.Value == String.Empty)
                {
                    continue;
                }
                // if match is a vowel
                if (ContainsMatch(vowelmatches, match))
                {
                    if (matchlist.Contains(match.Value))
                    {
                        if (matchlist.IndexOf(match.Value) == 0)
                        {
                            matchlist.Prepend("h");
                        }
                        else
                        {
                            matchlist.Insert(matchlist.IndexOf(match.Value), "h");
                        }
                        // this is a vowel
                    }
                    else
                    {
                        // combine input and then search
                        string tosearch = CombineString(matchlist);
                        int index = tosearch.IndexOf(match.Value);
                        matchlist.Insert(index, "h");
                    }

                }
                if (ContainsMatch(consonantmatches, match))
                {
                    if (matchlist.Contains(match.Value))
                    {
                        matchlist.Insert(matchlist.IndexOf(match.Value) + 1, "iss");
                    }
                    else
                    {
                        // make list 1 string so we can search it
                        string tosearch = CombineString(matchlist);
                        // index of substring
                        int index = tosearch.IndexOf(match.Value);
                        int substringlength = tosearch.Substring(index, match.Value.Length).Length;
                        matchlist[index].Insert(matchlist[index].Length-1, "iss");
                    }
                    
                }
            }
            result = string.Empty;
            // capitalize only first character
            string temp = CombineString(matchlist);
            string[] temparray = SplitString(temp);
            temparray[0] = temparray[0].ToUpper();
            // update result with inserted substrings
            result = CombineString(temparray.ToList());

            
            Console.WriteLine(result);
            result = string.Empty;
        }

        private static string[] SplitString(string toSplit)
        {
            string[] array = new string[toSplit.Length];
            for (int i = 0; i < toSplit.Length; i++)
            {
                array[i] = toSplit[i].ToString();
            }
            return array;
        }

        private static string CombineString(List<string> inp)
        {
            string outp = string.Empty;
            foreach (string item in inp)
            {
                outp += item;
            }
            return outp;
        }

        private static bool ContainsMatch(MatchCollection collection, Match match)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].Value == match.Value)
                {
                    return true;
                }
            }
            return false;
        }

        private static List<string> MatchToString(MatchCollection mc)
        {
            List<string> rtn = new List<string>();
            foreach (Match item in mc)
            {
                rtn.Add(item.Value);
            }
            return rtn;
        }
    }
}

/// input string => split into chars => matches => insert strings => combine string => 
/// split again => first letter uppercase => combine => return
