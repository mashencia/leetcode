public class Solution {
    public ListNode ReverseList(ListNode head) {
        // base case --- null head or empty list
        if (head == null || head.next == null) {
            return head;
        }

        // base case --- the last node      
        if(head.next == null){
            return head;
        }

        // Recursive Case
        ListNode newHead = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return newHead;
    }
}
