using Xunit;
namespace Algorithm._001
{
    public class Tester
    {
        [Fact(DisplayName="两数之和")]
        public  void Solution01Test01()
        {
            var nums= new int[]{2,7,11,15};
            var target = 9;

            var res = Solution01.TwoSum(nums,target);

            Assert.Equal(new int[]{0,1},res);
        }
    }
}