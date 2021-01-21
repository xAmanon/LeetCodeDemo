using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;

namespace Algorithm._001
{
    public class Solution01
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var diff = target - nums[i];
                if (dic.TryGetValue(diff, out var index))
                {
                    return new int[] { index, i };
                }
                dic.Add(num, i);
            }
            return null;
        }
    }
}