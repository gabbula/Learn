using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public static class Fibonacci
    {
        /// <summary>
        /// Print the first n Fibonacci numbers 
        /// </summary>
        /// <param name="n">int</param>
        public static void PrintFibonacci(int n)
        {
            int val1 = 0, val2 = 1, val3, i;

            Console.WriteLine(val1 + " " + val2 + " ");
            for (i = 0; i < n; i++)
            {
                val3 = val1 + val2;
                Console.WriteLine(val3 + " ");
                val1 = val2;
                val2 = val3;
            }
        }
    }
}
