using System;
namespace Algorithm._1024
{
    public class Solution01
    {
        public static int VideoStitching(int[][] clips, int T) 
        {
            int[] maxn = new int[T];
            int last = 0, ret = 0, pre = 0;

            foreach (var clip in clips)
            {
                if (clip[0] < T) {
                    maxn[clip[0]] = Math.Max(maxn[clip[0]], clip[1]);
                }
            }

            for (int i = 0; i < T; i++) {
                last = Math.Max(last, maxn[i]);
                if (i == last) {
                    return -1;
                }
                if (i == pre) {
                    ret++;
                    pre = last;
                }
            }
            return ret;
        }
    }
}