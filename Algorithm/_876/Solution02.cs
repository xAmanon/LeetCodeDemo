namespace Algorithm._876
{
    public class Solution02
    {
         public static ListNode MiddleNode(ListNode head) {

            var midNode=head;
            var node = head;
            while(node!=null && node.next!=null)
            {
                midNode=midNode.next;
                node=node.next.next;
            }

            return midNode;
        }
    }
}