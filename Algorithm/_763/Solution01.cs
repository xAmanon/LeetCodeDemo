using System.Collections.Generic;
using System;

namespace Algorithm._763
{
    public class Solution01
    {
        public static IList<int> PartitionLabels(string S) {
            int[] endIndexs=new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                var c = S[i];
                endIndexs[c-'a']=i;
            }

            var startIndex=0;
            var endIndex=0;

            var partition=new List<int>();

            for (int i = 0; i < S.Length; i++)
            {
                endIndex = Math.Max(endIndex,endIndexs[S[i] - 'a']);
                if(i== endIndex)
                {
                    partition.Add(endIndex-startIndex + 1);
                    startIndex = endIndex + 1;
                }
            }

            return partition;
        }
    }
}