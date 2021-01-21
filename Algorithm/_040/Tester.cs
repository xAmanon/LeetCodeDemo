using Xunit;
using System.Collections.Generic;
using System.Linq;
namespace Algorithm._040
{
    public class Tester
    {
        [Fact(DisplayName = "组合总和")]
        public void Solution01Test01()
        {
            var solution = new Solution01();
            var nums = new int[] { 10,1,2,7,6,1,5 };

            var res = solution.CombinationSum2(nums,8);

            Assert.Equal(4, res.Count);
            Assert.Contains(new int[] { 1, 7 }, res);
            Assert.Contains(new int[] { 1, 2, 5 }, res);
            Assert.Contains(new int[] { 2, 6 }, res);
            Assert.Contains(new int[] { 1, 1, 6 }, res);
        } 
    }
}