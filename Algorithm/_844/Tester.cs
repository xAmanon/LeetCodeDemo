using Xunit;

namespace Algorithm._844
{
    public class Tester
    {
         [Fact(DisplayName="比较含退格的字符串01")]
        public  void Solution01Test01()
        {
            var s0="ab#c";
            var p0="ad#c";

            Assert.True(Solution01.BackspaceCompare(s0,p0));

            var s1="ab##";
            var p1="c#d#";

             Assert.True(Solution01.BackspaceCompare(s1,p1));

            var s2="a##c";
            var p2="#a#c";

             Assert.True(Solution01.BackspaceCompare(s2,p2));

            var s3="a#c";
            var p3="b";

            Assert.False(Solution01.BackspaceCompare(s3,p3));

            var s4="bxj##tw";
            var p4="bxj###tw";

            Assert.False(Solution01.BackspaceCompare(s4,p4));
        }
    }
}