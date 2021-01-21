using Xunit;
namespace Algorithm._026
{
    public class Tester
    {
        [Fact(DisplayName = "删除排序数组中的重复项")]
        public void Solution01Test01()
        {
            var solution = new Solution01();
            var nums = new int[] { 1, 1, 2 };

            var res = solution.RemoveDuplicates(nums);

            Assert.Equal(2, res);
            Assert.Equal(new int[] { 1, 2 }, nums[0..2]);

            var nums2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            var res2 = solution.RemoveDuplicates(nums2);

            Assert.Equal(5, res2);
            Assert.Equal(new int[] { 0, 1, 2, 3, 4 }, nums2[0..5]);
        }
    }
}