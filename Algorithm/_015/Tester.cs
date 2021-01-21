using Xunit;
namespace Algorithm._015
{
    public class Tester
    {
        [Fact(DisplayName="两数之和")]
        public  void Solution01Test01()
        {
            var solution = new Solution01();
            var nums= new int[]{-10,-1,0,1,2,-1,-4};

            var res = solution.ThreeSum(nums);

            Assert.Equal(new int[]{-1,-1,2},res[0]);
            Assert.Equal(new int[]{-1,0,1},res[1]);
        }
    }
}