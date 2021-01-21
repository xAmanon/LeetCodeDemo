using Xunit;
using System.Collections.Generic;
using System.Linq;
namespace Algorithm._039
{
    public class Tester
    {
        [Fact(DisplayName = "组合总和")]
        public void Solution01Test01()
        {
            var solution = new Solution01();
            var nums = new int[] { 2,3,6,7 };

            var res = solution.CombinationSum(nums,7);

            Assert.Equal(2, res.Count);
            Assert.Equal(new int[] { 7 }, res[1]);
            Assert.Equal(new int[] { 2,2,3 }, res[0].OrderBy(n=>n));
        } 
    }
}