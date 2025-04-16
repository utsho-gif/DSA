using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = CombinationSub(new int[] { 2, 3, 8, 9}, 9);
            foreach(var res in result)
            {
                Console.WriteLine($"[{string.Join(" ,", res)}]");
            }
        }
        public static IList<IList<int>> CombinationSub(int[] candidate, int target)
        {
            List<IList<int>> res = new List<IList<int>>();

            void Helper(int index, List<int> curr, int currSum)
            {
                if(currSum > target)
                {
                    return;
                }

                if(currSum == target)
                {
                    res.Add(new List<int>(curr));
                    return;
                }

                for(int j = index; j < candidate.Length; j++)
                {
                    curr.Add(candidate[j]);
                    Helper(j, curr, currSum +  candidate[j]);
                    curr.RemoveAt(curr.Count - 1);
                }
            }

            Helper(0, new List<int>(), 0);
            return res;
        }
    }
}
