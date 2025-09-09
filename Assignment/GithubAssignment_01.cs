using System;
namespace Assignments
{
    class GithubAssignment_01
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            CountWordFrequencyDesc(str);
        }

        public static void CountWordFrequencyDesc(string? str)
        {
            List<string> words = new List<string>();
            string Word = "";
            foreach (char ch in str)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    Word += char.ToLower(ch);
                }
                else if (Word.Length > 0)
                {
                    words.Add(Word);
                    Word = "";
                }
            }
            if (Word.Length > 0)
            {
                words.Add(Word);
            }
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }
            //foreach (var item in Count)
            //{
            //    Console.WriteLine($"{item.Value} {item.Key}");
            //}
            var sorted = dict
                .OrderByDescending(x => x.Value)
                .OrderByDescending(x => x.Key);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Value} {item.Key}");
            }

            //Console.WriteLine(list);
        }
    }
}


