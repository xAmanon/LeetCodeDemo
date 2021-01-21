using Xunit;
namespace Algorithm._016
{
    public class Tester
    {
        [Fact(DisplayName="两数之和")]
        public  void Solution01Test01()
        {
            var solution = new Solution01();
            var nums= new int[]{-1,2,1,-4};

            var res = solution.ThreeSumClosest(nums,1);

            Assert.Equal(2,res);

            var nums2= new int[]{0,2,1,-3};

            var res2 = solution.ThreeSumClosest(nums2,1);

            Assert.Equal(0,res2);
        }
    }
}