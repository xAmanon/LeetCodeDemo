using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm._876
{
    public class Tester
    {
        [Fact(DisplayName="链表的中间结点01")]
        public  void Solution01Test01()
        {
            var node=CreateNode(new int[]{1,2,3,4,5});
            var midNode = Solution01.MiddleNode(node);

            Assert.Equal(3,midNode.val);

            var node2=CreateNode(new int[]{1,2,3,4,5,6});
            var midNode2 = Solution01.MiddleNode(node2);

            Assert.Equal(4,midNode2.val);
        }

         [Fact(DisplayName="链表的中间结点02")]
        public  void Solution01Test02()
        {
            var node=CreateNode(new int[]{1,2,3,4,5});
            var midNode = Solution02.MiddleNode(node);

            Assert.Equal(3,midNode.val);

            var node2=CreateNode(new int[]{1,2,3,4,5,6});
            var midNode2 = Solution02.MiddleNode(node2);

            Assert.Equal(4,midNode2.val);
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