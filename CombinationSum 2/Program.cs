using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationSum_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = CombinationSum2(new int[] { 1, 1, 1, 1, 2, 2 }, 4);
            foreach (var res in result)
            {
                Console.WriteLine($"[{string.Join(" ,", res)}]");
            }
        }
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            List<IList<int>> res = new List<IList<int>>();

            void Helper(int index, List<int> curr, int currSum)
            {
                if(currSum > target || index > candidates.Length - 1)
                {
                    return;
                }
                if(currSum == target)
                {
                    res.Add(new List<int>(curr));
                    return;
                }

                HashSet<int> hashTable = new HashSet<int>();

                for(int j = index; j < candidates.Length; j++)
                {
                    if (!hashTable.Contains(candidates[j]))
                    {
                        curr.Add(candidates[j]);
                        hashTable.Add(candidates[j]);
                        Helper(j + 1, curr, currSum + candidates[j]);
                        curr.RemoveAt(curr.Count - 1);
                    }
                    
                }
            }
            Helper(0, new List<int>(), 0);
            return res;
        }
    }
}
