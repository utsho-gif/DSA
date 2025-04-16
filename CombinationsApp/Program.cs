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

            int[] arr = { 2, 2, 4, 5, 7, 1, 2 };
            int secondLargest = arr.OrderByDescending(x => x).Distinct().Skip(1).First();
            Console.WriteLine(secondLargest);

            bool IsPalindrome(string str) => str == new string(str.Reverse().ToArray());
            Console.WriteLine(IsPalindrome("Hello"));

            var duplicates = arr.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
            Console.WriteLine(duplicates);
            
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
