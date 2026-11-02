public class Solution_DetectCycle
{
    public ListNode DetectCycle(ListNode head)
    {
        Dictionary<int, int> visited = new();
        int pos = 0;

        ListNode curr = head;

        while (curr != null)
        {
            visited.Add(curr.val, pos++);
            if (curr?.next != null)
            {
                var nextVal = curr.val;
                if (visited.ContainsKey(nextVal))
                {
                    return curr;
                }
            }
            curr = curr.next;
        }

        return null;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
