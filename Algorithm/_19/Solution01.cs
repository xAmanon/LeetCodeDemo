namespace Algorithm._19
{
    /// <summary>
    /// 删除链表倒数的第N个节点
    /// </summary>
    public class Solution01
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n) {
            /**
            * 1. 变量a记录链表的第一个节点，声明
            * 2. 遍历链表，i++,当i>n时将a节点的下个节点赋值给a
            * 3. 遍历结束a的指向的就是要删除节点的上一个节点
            * 4. 将a.next赋值为a.next.next
            */

            // 声明新的链表指向head，方便统一逻辑处理，否则需要单独判断倒数第n个节点是否指向head
            var newList=new ListNode(next:head);
            var a = newList;
            var cur = newList.next;
            var i = 0;

            while(cur!=null)
            {
                if(i>=n) a = a.next;
                cur=cur.next;
                i++;
            }

            a.next=a.next?.next;

            return newList.next;
        }
    }
}