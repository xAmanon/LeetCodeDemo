using System;
namespace Algorithm._011
{
    public class Solution01
    {
        public static int MaxArea(int[] height) {
            /*
            **  双指针法，如果左边的长度小于右边的长度，则表明继续向右移动才有可能增大面加，否则相反
            */
            var max=0;
            var i= 0;
            var j=height.Length - 1;

            var lval = height[i];
            var rval = height[j];

            while(i < j)
            {
                lval = height[i];
                rval = height[j];

                if( lval < rval )
                {
                    max= Math.Max( lval * (j-i),max);
                    i++;
                    while(i<j&&lval>=height[i]) i++;
                }
                else
                {
                    max= Math.Max(rval * (j-i),max);
                    j--;
                    while(i<j&&rval>=height[j]) j--;
                }
                
            }
            return max;
        }
    }
}