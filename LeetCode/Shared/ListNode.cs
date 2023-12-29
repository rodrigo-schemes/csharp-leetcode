namespace LeetCode.Shared;

public class ListNode {
    public int? Val;
    public readonly ListNode? Next;
    public ListNode(int val, ListNode next = null!) {
        Val = val;
        Next = next;
    }
}