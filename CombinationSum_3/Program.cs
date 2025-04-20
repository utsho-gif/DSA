using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationSum_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = CombinationSum_3(3, 9);
            foreach(var res in result)
            {
                Console.WriteLine($"[{string.Join(" ,", res)}]");
            }
        }

        public static IList<IList<int>> CombinationSum_3(int k, int n)
        {
            List<IList<int>> res = new List<IList<int>>();

            void Helper(int index, int countSum, List<int> curr)
            {
                if(countSum == n && curr.Count == k)
                {
                    res.Add(new List<int>(curr));
                    return;
                }
                if(countSum > n || curr.Count == k)
                {
                    return;
                }

                for(int j = index; j < 10; j++)
                {
                   
                        curr.Add(j);
                        Helper(j + 1, countSum + j, curr);
                        curr.RemoveAt(curr.Count - 1);
                
                }

            }
            Helper(1, 0, new List<int>());
            return res;
        }  
    }
}
