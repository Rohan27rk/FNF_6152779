using System;
using System.Collections.Generic;
using System.Linq;

namespace Github

{
    internal class FrequencyCounter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your input text:");
            string? str = Console.ReadLine();
            CountWordFrequencyDesc(str);
        }

        private static void CountWordFrequencyDesc(string? str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("0");
                return;
            }

            List<string> words = new List<string>();
            string word = "";

            foreach (char ch in str)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    word += char.ToLower(ch);
                }
                else if (word.Length > 0)
                {
                    words.Add(word);
                    word = "";
                }
            }

            if (word.Length > 0)
            {
                words.Add(word);
            }

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string w in words)
            {
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }

            var sorted = dict
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => x.Key);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Value} {item.Key}");
            }
        }
    }
}
