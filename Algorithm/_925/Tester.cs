using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm._925
{
    public class Tester
    {
        [Fact(DisplayName="长按键入")]
        public  void Solution01Test01()
        {
            var result1 = Solution01.IsLongPressedName("alex","aaleex");
            var result2 = Solution01.IsLongPressedName("saeed","ssaaedd");
            var result3 = Solution01.IsLongPressedName("leelee","lleeelee");
            var result4 = Solution01.IsLongPressedName("laiden","laiden");

            Assert.True(result1);
            Assert.False(result2);
            Assert.True(result3);
            Assert.True(result4);
        }
    }
}