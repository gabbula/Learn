using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Learn
{
    // Ref : https://leetcode.com/submissions/detail/700026148
    public static class BaseballSolution
    {
        public static int calPoints(String[] ops)
        {
            List<int> results = new List<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                var op = ops[i];
                if (op == "C")
                {
                    results.RemoveAt(results[results.Count - 1]);
                    results.Remove(results[results.Count - 1]);
                }
                else if (op == "D")
                {
                    results.Add(results[results.Count - 1] * 2);
                }
                else if (op == "+")
                {
                    results.Add((results[results.Count - 1] + results[results.Count - 2]));
                }
                else
                {
                    results.Add(int.Parse(op));
                }
            }
            return results.Sum();
        }
    }

}
