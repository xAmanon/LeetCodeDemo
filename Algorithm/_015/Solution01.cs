using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm._015
{
    public class Solution01
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums == null || nums.Length < 3)
            {
                return new List<IList<int>>();
            }
            var sorted = nums.OrderBy(x => x).ToArray();
            var lis = new List<IList<int>>();
            var n = nums.Length;

            for (int i = 0; i < sorted.Length; i++)
            {
                if (sorted[i] > 0)
                {
                    return lis;
                }

                if (i > 0 && sorted[i] == sorted[i - 1])
                {
                    continue;
                }
                var l = i + 1;
                var r = n - 1;

                while (l < r)
                {
                    if (sorted[i] + sorted[l] + sorted[r] == 0)
                    {
                        lis.Add(new List<int>() { sorted[i], sorted[l], sorted[r] });
                        while (l < r && sorted[l] == sorted[l + 1])
                            l++;
                        while (l < r && sorted[r] == sorted[r - 1])
                            r--;
                        l++;
                        r--;
                    }
                    else if (sorted[i] + sorted[l] + sorted[r] > 0)
                    {
                        r--;
                    }
                    else
                    {
                        l++;
                    }
                }
            }
            return lis;
        }
    }
}