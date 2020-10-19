using System;
namespace Algorithm._010
{
    public class Solution01
    {
        public static bool IsMatch(string s, string p, int i, int j)
        {
            if (i == 0)
            {
                return false;
            }

            if (p[j - 1] == '.')
            {
                return true;
            }

            return s[i - 1] == p[j - 1];
        }

        public static bool IsMatch(string s, string p)
        {
            var m = s.Length;
            var n = p.Length;

            bool[,] f = new bool[m + 1, n + 1];
            f[0, 0] = true;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == '*')
                    {
                        f[i, j] = f[i, j - 2];
                        if (IsMatch(s, p, i, j-1 ))
                        {
                            f[i, j] = f[i, j] || f[i - 1, j];
                        }
                    }
                    else
                    {
                        if (IsMatch(s, p, i, j))
                        {
                            f[i, j] = f[i - 1, j - 1];
                        }
                    }
                }
            }

            return f[m, n];
        }
    }
}