namespace Algorithm._026
{
    public class Solution01
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length==0){
                return 0;
            }
            if(nums.Length==1){
                return 1;
            }
            var curIndex = 1;
            var curValue = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (curIndex >= nums.Length) 
                    break;
                if (curValue == nums[i])
                {
                    continue;
                }
                else
                {
                    nums[curIndex] = nums[i];
                    curIndex = curIndex + 1;
                    curValue = nums[i];
                }
            }
            return curIndex;
        }
    }
}