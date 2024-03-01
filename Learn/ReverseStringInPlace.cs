using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public static class ReverseStringInPlace
    {
        static string Reverse(string originalString)
        {
            char[] charArray = originalString.ToCharArray();
            int start = 0;
            int end = charArray.Length - 1;

            // Swap characters from the beginning to the end
            while (start < end)
            {
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;

                start++;
                end--;
            }

            return new string(charArray);
        }
    }
}
