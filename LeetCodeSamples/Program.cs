using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = TwoSum(new int[] { 3, 2, 4 }, 6);

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int index2;

                if (dic.TryGetValue(target - nums[i], out index2) && index2 !=i)
                {
                    return new int[] { i, index2 };
                }
            }

            throw new Exception("No solution");

        }
    }
}