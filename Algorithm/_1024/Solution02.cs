using System;
namespace Algorithm._1024
{
    public class Solution02
    {
        public static int VideoStitching(int[][] clips, int T) 
        {
            var dp = new int[T+1];
            Array.Fill(dp,Int32.MaxValue-1);
            dp[0] = 0;
            for (int i = 0; i <=T; i++)
            {
                foreach (var clip in clips)
                {
                    if(clip[0]<i && i <= clip[1])
                    {
                        dp[i] = Math.Min(dp[i],dp[clip[0]]+1);
                    }
                }
            }

            return dp[T] == Int32.MaxValue -1  ?-1:dp[T];
        }
    }
}