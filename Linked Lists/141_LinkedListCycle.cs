public class Solution {
    public bool HasCycle(ListNode head) {
         Dictionary<ListNode, int> beenTo = new Dictionary<ListNode, int>();
         var currentNode = head;

         if(head == null) return false;
         
        while(currentNode != null)
        {
            if(beenTo.ContainsKey(currentNode)) return true;
            beenTo.Add(currentNode, currentNode.val);
            currentNode = currentNode.next;
        }
        return false;
    }
}
