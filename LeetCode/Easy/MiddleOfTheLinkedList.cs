namespace LeetCode.Easy;

public static class MiddleOfTheLinkedList
{
    public static ListNode Run(ListNode head)
    {
        var middle = head;
        var last = head;

        while (last?.Next != null)
        {
            middle = middle?.Next;
            last = last.Next.Next;
        }

        return middle!;
    }
}

public class ListNode {
    public int? Val;
    public readonly ListNode? Next;
    public ListNode(int val, ListNode next = null!) {
        Val = val;
        Next = next;
    }
}