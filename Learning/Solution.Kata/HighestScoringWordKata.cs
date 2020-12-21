using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.Kata
{
    public static class HighestScoringWordKata
    {
        public static string High(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            var dict = new Dictionary<string, int>();

            foreach (var word in s
                .Split(" ")
                .Where(w => !dict.TryGetValue(w, out int _)))
            {
                int counterWord = word
                  .Where(ch => char.IsLetter(ch))
                  .Select(ch => (int)ch - 96).Sum();
                dict.Add(word, counterWord);
            }
            return dict.FirstOrDefault(x => x.Value == dict.Values.Max()).Key ?? "";
        }
        public static string High2(string s)    //TEST: 4/6
            => s.Split(' ').OrderBy(word => word.Select(ch => ch - 96).Sum()).Last();

        public static string High3(string s)    //TEST: 5/6
        {
            if (string.IsNullOrEmpty(s)) return "";

            return s.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select((word, position) =>
                 (
                     Word: word,
                     Score: word.Sum(ch => ch - 'a'), // ascii code value of 'a' is 97
                     Position: position
                 ))
                 .OrderByDescending(t => t.Score)
                 .ThenBy(t => t.Position)
                 .First().Word;
        }
    }
}
