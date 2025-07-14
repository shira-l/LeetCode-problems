/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
        string binaryVal="";
        ListNode node=head;
        while(node!=null){
            binaryVal+=node.val;
            node=node.next;
        }
        int decimalVal=Convert.ToInt32(binaryVal, 2);
        return decimalVal;
    }
}