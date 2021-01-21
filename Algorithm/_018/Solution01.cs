using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm._018
{
    public class Solution01
    {
        public IList<IList<int>> FourSum(int[] nums,int target)
        {
            if (nums == null || nums.Length < 3)
            {
                return new List<IList<int>>();
            }
            var sorted = nums.OrderBy(x => x).ToArray();
            var lis = new List<IList<int>>();
            var n = nums.Length;

            for (int i = 0; i < sorted.Length - 3; i++)
            {
                if (i > 0 && sorted[i] == sorted[i - 1])
                {
                    continue;
                }

                if (sorted[i] + sorted[i + 1] + sorted[i + 2] + sorted[i + 3] > target) {
                    break;
                }
                if (sorted[i] + sorted[n - 3] + sorted[n - 2] + sorted[n - 1] < target) {
                    continue;
                }

                for (int j = i + 1; j < sorted.Length - 2; j++)
                {
                    if(j>i+1 && sorted[j]==sorted[j-1]){
                        continue;
                    }

                    if (sorted[i] + sorted[j] + sorted[j + 1] + sorted[j + 2] > target) {
                        break;
                    }

                    if (sorted[i] + sorted[j]+ sorted[n-1] + sorted[n-2] < target) {
                        continue;
                    }

                    var l = j + 1;
                    var r = n - 1;

                    while (l < r)
                    {
                        var sum = sorted[i] + sorted[j]+ sorted[l] + sorted[r];
                        if (sum == target)
                        {
                            lis.Add(new List<int>() { sorted[i],sorted[j], sorted[l], sorted[r] });
                            while (l < r && sorted[l] == sorted[l + 1])
                                l++;
                            while (l < r && sorted[r] == sorted[r - 1])
                                r--;
                            l++;
                            r--;
                        }
                        else if (sum > target)
                        {
                            r--;
                        }
                        else
                        {
                            l++;
                        }
                    }

                }

            }
            return lis;
        }
    }
}