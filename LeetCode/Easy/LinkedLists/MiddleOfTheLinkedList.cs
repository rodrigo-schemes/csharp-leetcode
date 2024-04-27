using LeetCode.Shared;

namespace LeetCode.Easy.LinkedLists;

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