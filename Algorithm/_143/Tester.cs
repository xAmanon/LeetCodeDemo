using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm._143
{
    public class Tester
    {
        [Fact(DisplayName="重排链表01")]
        public  void Solution01Test01()
        {
            var vals=new int[]{1,2,3,4,5};
            var node=CreateNode(vals);

            Solution01.ReorderList(node);

            var newVals=GetVals(node);

            Assert.Equal(new int[]{1,5,2,4,3},newVals);
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