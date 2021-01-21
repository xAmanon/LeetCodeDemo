namespace Algorithm._941
{
    public class Solution01
    {
        public static bool ValidMountainArray(int[] A) {
            var i =1;

            while(i< A.Length && A[i]>A[i-1])
            {
                i++;
            }

            if(i == 1 || i == A.Length) return false;
            
            while(i< A.Length && A[i]<A[i-1])
            {
                i++;
            }

            if(i < A.Length) return false;

            return true;
        }
    }
}