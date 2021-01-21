using Xunit;
namespace Algorithm._018
{
    public class Tester
    {
        [Fact(DisplayName = "四数之和")]
        public void Solution01Test01()
        {
            var solution = new Solution01();
            var nums = new int[] { 1, 0, -1, 0, -2, 2 };

            var res = solution.FourSum(nums, 0);

            Assert.Equal(3, res.Count);
            Assert.Equal(new int[] { -1, 0, 0, 1 }, res[2]);
            Assert.Equal(new int[] { -2, 0, 0, 2 }, res[1]);
            Assert.Equal(new int[] { -2, -1, 1, 2 }, res[0]);
        }
    }
}