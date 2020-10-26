using System.Collections.Generic;

namespace Algorithm._143
{
    public class Solution01
    {
        public static void ReorderList(ListNode head) {
            var lis = new List<ListNode>();

            var node = head;
            while(node!=null)
            {
                lis.Add(node);
                node=node.next;
            }

            int i = 0,j = lis.Count - 1;

            while(i < j)
            {
                lis[i].next=lis[j];
                i++;
                if(i==j) break;
                lis[j].next=lis[i];
                j--;
            }
            lis[i].next=null;
        }
    }
}