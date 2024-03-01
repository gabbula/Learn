using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public static class FindLastKDigits
    {
        public static int lastKDigits(int[] a, int n, int k)
        {
            //int[] a = { 22, 31, 44, 27, 37, 43 };
            //k = 2
            int num = (int)Math.Pow(10, k);
            //num = 100

            // Multiplying array elements 
            // under modulo 10^k.
            int mul = a[0] % num;

            for (int i = 1; i < n; i++)
            {
                a[i] = a[i] % num;
                mul = a[i] * mul % num;
            }
            return mul;
        }
    }
}
