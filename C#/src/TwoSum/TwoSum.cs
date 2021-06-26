using System;
using System.Linq;

namespace LeetHack
{
    public class TwoSum
    {
        public int[] Sums(int[] nums, int target)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int num = nums[i];
                int firstAddend = target - num;
                if (!nums.Contains(firstAddend))
                {
                    continue;
                }

                int firstAddendIndex = Array.IndexOf(nums, firstAddend);
                return new int[] { firstAddendIndex, i };
            }

            return new int[0];
        }

    }
}