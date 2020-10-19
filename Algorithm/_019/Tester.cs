using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm._019
{
    public class Tester
    {
        [Fact(DisplayName="删除链表的倒数第N个节点01")]
        public  void Solution01Test01()
        {
            var vals=new int[]{1,2,3,4,5};
            var node=CreateNode(vals);

            var removedNode = Solution01.RemoveNthFromEnd(node,2);

            var newVals=GetVals(removedNode);

            Assert.Equal(new int[]{1,2,3,5},newVals);
        }

        [Fact(DisplayName="删除链表的倒数第N个节点02")]
        public  void Solution01Test02()
        {
            var vals=new int[]{1};
            var node=CreateNode(vals);

            var removedNode = Solution01.RemoveNthFromEnd(node,1);

            var newVals=GetVals(removedNode);

            Assert.Equal(new int[0],newVals);
        }

        public ListNode CreateNode(params int[] vals)
        {
            var temp=new ListNode();
            var cur = temp;
            foreach (var item in vals)
            {
                cur.next=new ListNode(item);
                cur=cur.next;
            }

            return temp.next;
        }

        public int[] GetVals(ListNode node)
        {
            var lis=new List<int>();

            var cur = node;
            while(cur!=null)
            {
                lis.Add(cur.val);
                cur=cur.next;
            }

            return lis.ToArray();
        }

    }
}