using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        /// <summary>
        /// Using force loop.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum1(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Use Dictionary instead of using for loop.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum2(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
                var index2 = 0;

                if (dic.TryGetValue(target - nums[i], out index2) && index2 != i)
                    return new[] {index2, i};
            }

            throw new Exception("No solution");
        }
    }
}