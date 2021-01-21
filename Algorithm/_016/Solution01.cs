using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm._016
{
    public class Solution01
    {
        public int ThreeSumClosest(int[] nums,int target)
        {
            var sorted = nums.OrderBy(x => x).ToArray();
            var lis = new List<IList<int>>();
            var n = nums.Length;
            var best = int.MaxValue;
            var bestDiff =  int.MaxValue;

            for (int i = 0; i < sorted.Length; i++)
            {
                if (i > 0 && sorted[i] == sorted[i - 1])
                {
                    continue;
                }
                var l = i + 1;
                var r = n - 1;

                while (l < r)
                {
                    var sum = sorted[i] + sorted[l] + sorted[r] ;
                    var diff= sum -target;

                    if (Math.Abs(diff)< Math.Abs(bestDiff))
                    {
                        best = sum;
                        bestDiff = diff;
                    }

                    if (diff > 0)
                    {
                        r--;
                    }
                    else if(diff <0)
                    {
                        l++;
                    }
                    else{
                        return best;
                    }
                }
            }
            return best;
        }
    }
}