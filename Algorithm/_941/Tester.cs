using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm._941
{
    public class Tester
    {
        [Fact(DisplayName="山脉数组")]
        public  void Solution01Test01()
        {
            var result1 = Solution01.ValidMountainArray(new int[] { 1 });
            var result2 = Solution01.ValidMountainArray(new int[] { 1 , 2 });
            var result3 = Solution01.ValidMountainArray(new int[] { 1 ,3 ,2});
            var result4 = Solution01.ValidMountainArray(new int[] { 1 ,3,2 ,4,1});

            Assert.False(result1);
            Assert.False(result2);
            Assert.True(result3);
            Assert.False(result4);
        }
    }
}