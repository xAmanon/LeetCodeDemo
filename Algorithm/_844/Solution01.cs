namespace Algorithm._844
{
    public class Solution01
    {
        public static bool BackspaceCompare(string S, string T) {
            var n=S.Length-1;
            var m=T.Length-1;

            var isMatch=true;
            var delCount1 = 0;
            var delCount2 = 0;
            // 反向遍历字符串
            while(n>=0 || m>=0)
            {
                char schar='\0';
                if(n>=0)
                {
                    schar=S[n];
                    if(schar=='#')
                    {
                        delCount1++;
                        n--;
                        continue;
                    }

                    if(delCount1>0)
                    {
                        delCount1--;
                        n--;
                        continue;
                    }
                }

                char tchar='\0';
                if(m>=0)
                {
                    tchar=T[m];

                    if(tchar=='#')
                    {
                        delCount2++;
                        m--;
                        continue;
                    }

                    if(delCount2>0)
                    {
                        delCount2--;
                        m--;
                        continue;
                    }
                }

                if(schar==tchar)
                {
                    n--;
                    m--;
                }
                else
                {
                    isMatch =false;
                    break;
                }
            }

            if(m>0||n>0) isMatch=false;

            return isMatch;
        }
    }
}