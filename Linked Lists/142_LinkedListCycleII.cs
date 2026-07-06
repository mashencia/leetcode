// O(n) memory solution
public class Solution {
    public ListNode DetectCycle(ListNode head) {
         Dictionary<ListNode, int> beenTo = new Dictionary<ListNode, int>();
         var currentNode = head;

         if(head == null) return null;
         
        while(currentNode != null)
        {
            if(beenTo.ContainsKey(currentNode)) return currentNode;
            beenTo.Add(currentNode, currentNode.val);
            currentNode = currentNode.next;
        }
        return null;
    }
}
