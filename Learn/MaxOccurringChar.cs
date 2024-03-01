using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public static class MaxOccurringChar
    {
        public static char GetMaxOccurringChar(string sentence)
        {
            var charCount = new Dictionary<char, int>();
            foreach (var c in sentence)
            {
                if(c == ' ' || c == '.')
                {
                    continue;
                }
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }
            return charCount.OrderByDescending(x => x.Value).First().Key;
        }
        public static char GetMaxOccurringAndFirstCharInSentence(string sentence)
        {
            var charCount = new Dictionary<char, int>();
            foreach (var c in sentence)
            {
                if (c == ' ' || c == '.')
                {
                    continue;
                }
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }
            return charCount.OrderByDescending(x => x.Value).ThenBy(x => sentence.IndexOf(x.Key)).First().Key;
        }
        public static char FindFirstOccuranceOfMaxOccurringChar(string sentence)
        {
            var charCount = new Dictionary<char, int>();
            foreach (var c in sentence)
            {
                if (c == ' ' || c == '.')
                {
                    continue;
                }
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }
            var maxOccuringChar = charCount.OrderByDescending(x => x.Value).First().Key;
            char resChar = sentence.IndexOf(maxOccuringChar) == -1 ? ' ' : maxOccuringChar;
            return resChar;
        }   
    }
}
