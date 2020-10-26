using System.Collections.Generic;
namespace Algorithm._876
{
    public class Solution01
    {
        public static ListNode MiddleNode(ListNode head) {
            var lis = new List<ListNode>();
            var node = head;
            while(node!=null)
            {
                lis.Add(node);
                node=node.next;
            }

            var midIndex= lis.Count/2;

            return lis[midIndex];
        }
    }
}