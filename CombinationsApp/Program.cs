using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationsApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var result = Combination(4, 2);
            foreach (var res in result)
            {
                Console.WriteLine($"[{string.Join(" ,", res)}]");
            }
        }

        public static IList<IList<int>> Combination(int n, int k)
        {
            int[] nums = Enumerable.Range(1, n).ToArray();
            List<IList<int>> result = new List<IList<int>>();

            void Helper(int i, List<int> subset)
            {
                if (subset.Count == k)
                {
                    result.Add(new List<int>(subset));
                    return;
                }

                for (int j = i; j < nums.Length; j++)
                {
                    subset.Add(nums[j]);
                    Helper(j + 1, subset);
                    subset.RemoveAt(subset.Count - 1);
                }
            }

            Helper(0, new List<int>());
            return result;
        }
    }
}
