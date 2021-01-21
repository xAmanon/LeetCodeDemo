using System;

namespace Algorithm._041
{
    /// <summary>
    /// 利用数组本身打标记
    /// </summary>
    public class Solution02
    {
        public int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            // 排除负数的影响
            for (int i = 0; i < n; i++)  {
                if (nums[i] <=0){
                    nums[i] = n+1;
                }
            }

            // 将在0-n之间的数对应的n-1索引处的值改为对应的负数，标志这个索引对应的数值是存在的
            for (int i = 0; i <n; i++) {
                int num = Math.Abs(nums[i]);
                if (num <= n) {
                    nums[num - 1] = -Math.Abs(nums[num - 1]);
                }
            }

            // 查找第一个值大于0的索引
            for (int i = 0; i < n; ++i) {
                if (nums[i] > 0) {
                    return i + 1;
                }
            }
            return n + 1;
        }
    }
}