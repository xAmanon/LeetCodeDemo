using System.Collections.Generic;
using System.Linq;

namespace Algorithm._039
{
    public class Solution01
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            int len = candidates.Length;
            List<IList<int>> res = new List<IList<int>>();
            if (len == 0)
            {
                return res;
            }

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
                res.Add(new List<int>(path.ToArray()));
                return;
            }

            for (int i = begin; i < len; i++)
            {
                path.Push(candidates[i]);

                Dfs(candidates, i, len, target - candidates[i], path, res);

                path.Pop();
            }
        }
    }
}