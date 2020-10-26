using Xunit;
namespace Algorithm._763
{
    public class Tester
    {
        [Fact(DisplayName="划分字母区间01")]
        public  void Solution01Test01()
        {
            var res=Solution01.PartitionLabels("ababcbacadefegdehijhklij");
            Assert.Equal(new int[]{9,7,8},res);
        }
    }
}