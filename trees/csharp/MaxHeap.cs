public class MaxHeap
{
    readonly int[] array;
    public int[] Heap { get => array[..size]; }

    int size = 0;


    public MaxHeap(int cap = 100)
    {
        array = new int[cap];
    }

    public MaxHeap(List<int> lst) : this()
    {
        for (int i = 0; i < lst.Count; ++i, size++)
        {

            array[i] = lst[i];
            System.Console.WriteLine($"size: {size}");
        }
        Heapify();
    }
    public bool IsEmpty() => size <= 0;

    private void Heapify()
    {
        for (int i = size - 1; i >= 0; --i)
        {
            HeapifyDown(i);
        }
    }

    int LeftChildIdx(int node_idx)
    {
        int leftChild_idx = 2 * node_idx + 1;

        if (leftChild_idx >= size)
            return -1;

        return leftChild_idx;
    }
    int RightChildIdx(int node_idx)
    {
        int rightChild_idx = 2 * node_idx + 2;
        return rightChild_idx >= size ? -1 : rightChild_idx;
    }

    int ParentIdx(int node_idx)
    {
        return node_idx == 0 ? -1 : (node_idx - 1) / 2;
    }

    void HeapifyUp(int child_pos)
    {

        var parent = this.ParentIdx(child_pos);

        if (child_pos <= 0 || array[parent] > array[child_pos])
            return;

        (array[parent], array[child_pos]) = (array[child_pos], array[parent]);
        HeapifyUp(parent);
    }

    void HeapifyDown(int parent_pos)
    {

        var child_pos = this.LeftChildIdx(parent_pos);
        var rightN = this.RightChildIdx(parent_pos);

        if (child_pos == -1)
            return;

        if (rightN != -1 && array[rightN] > array[child_pos])
            child_pos = rightN;

        if (array[parent_pos] < array[child_pos])

        {
            (array[child_pos], array[parent_pos]) = (array[parent_pos], array[child_pos]);

            HeapifyDown(child_pos);
        }

    }


    public void Push(int key)
    {
        if (size + 1 > array.Length)
            throw new IndexOutOfRangeException("Size is bigger than capicty");

        array[size++] = key;

        HeapifyUp(size - 1);
    }

    public void Pop()
    {

        if (IsEmpty())
            throw new InvalidOperationException("Heap is empty.");


        var min = array[0];
        array[0] = array[size - 1];
        array[--size] = min;

        if (!IsEmpty())
            HeapifyDown(0);
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Heap is empty.");

        return array[0];
    }
    public int[] Sort()
    {
        var ints = new int[size];
        var s = size;
        for (int i = 0; i < s; i++)
        {
            ints[i] = Peek();
            Pop();
        }
        size = s;
        return ints;
    }
}