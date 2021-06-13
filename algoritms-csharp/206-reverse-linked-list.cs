//Definition for singly-linked list.
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class ReverseLinkedListSolution {
    public ListNode ReverseList(ListNode head) {
        if(head==null || head.next==null)
            return head;
        Stack<ListNode> nodeStack = new Stack<ListNode>();
        while(head!=null)
        {
            nodeStack.Push(new ListNode(head.val, head.next));
            head = head.next;
        }
        head = null;
        ListNode previousNode = null; 
        while(nodeStack.Count!=0)
        {
            ListNode node = new ListNode();
            node = nodeStack.Pop();
            if(node.next == null)
            {
                head = node;
                head.next = null;
                previousNode = head;
            }
            else
            {
                previousNode.next = node;
                previousNode = node;
            }
        }
        if (previousNode!= null) 
            previousNode.next = null;
        return head;
    }
}