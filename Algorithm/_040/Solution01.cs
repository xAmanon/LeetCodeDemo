using System.Collections.Generic;
using System.Linq;

namespace Algorithm._040
{
    public class Solution01
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            int len = candidates.Length;
            List<IList<int>> res = new List<IList<int>>();
            if (len == 0)
            {
                return res;
            }

            candidates = candidates.OrderBy(n => n).ToArray();

            Stack<int> path = new Stack<int>();
            Dfs(candidates, 0, len, target, path, res);
            return res;
        }

        private void Dfs(int[] candidates, int begin, int len, int target, Stack<int> path, List<IList<int>> res)
        {
            if (target < 0)
            {
                return;
            }
            if (target == 0)
            {
                res.Add(new List<int>(path.Reverse()));
                return;
            }

            for (int i = begin; i < len; i++)
            {
                if (target - candidates[i] < 0)
                {
                    break;
                }
                if (i > begin && candidates[i] == candidates[i - 1])
                    continue;
                path.Push(candidates[i]);

                Dfs(candidates, i + 1, len, target - candidates[i], path, res);

                path.Pop();
            }
        }
    }
}