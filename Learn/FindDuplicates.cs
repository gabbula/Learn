using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public static class FindDuplicates
    {
        static char findFirstDuplicate(string S)
        {
            HashSet<char> uniqueChar = new();

            foreach (char c in S)
            {
                if (uniqueChar.Contains(c))
                {
                    return c;
                }
            }
            return '\0';
        }
    }
}
