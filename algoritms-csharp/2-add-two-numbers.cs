// Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
 }
 
public class AddTwoNumbersSolution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode();
        ListNode tail = new ListNode();
        int addNext = 0;
        while(l1 != null || l2 != null)
        {
            ListNode node = new ListNode();
            ListNode item1 = new ListNode();
            ListNode item2 = new ListNode();
            if(l1 != null)
            {
                item1 = l1;
                l1 = l1.next;
            }
            if(l2 != null)
            {
                item2 = l2;
                l2 = l2.next;                
            }
            node.val = item1.val + item2.val +addNext;
            if(node.val >= 10)
            {
                node.val-=10;
                addNext=1;
            }
            else
                addNext=0;
            tail.next = node;
            tail = node;
            if(head.next == null)
                head = tail;
        }
        if(addNext == 1)
        {
            ListNode node = new ListNode(1);
            tail.next = node;
            tail = node;
        }
        return head;
    }
}