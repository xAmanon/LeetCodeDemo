using Xunit;
namespace Algorithm._010
{
    public class Tester
    {
        [Fact(DisplayName="删除链表的倒数第N个节点01")]
        public  void Solution01Test01()
        {
            var s0="aa";
            var p0="a";

            Assert.False(Solution01.IsMatch(s0,p0));

            var s1="aa";
            var p1="a*";

             Assert.True(Solution01.IsMatch(s1,p1));

            var s2="ab";
            var p2="a*";

             Assert.False(Solution01.IsMatch(s2,p2));

            var s3="aab";
            var p3="c*a*b";

            Assert.True(Solution01.IsMatch(s3,p3));

            var s4="aaaacabaab";
            var p4="c*a*c.*ab";

             Assert.True(Solution01.IsMatch(s4,p4));
        }
    }
}