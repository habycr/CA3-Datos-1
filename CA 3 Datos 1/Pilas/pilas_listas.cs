using Pilas;

public class LinkedListStack : IStack
{
    private Node top;

    public void Push(int element)
    {
        Node newNode = new Node(element);
        newNode.Next = top;
        top = newNode;
    }

    public int Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        else
        {
            int element = top.Data;
            top = top.Next;
            return element;
        }
    }

    public int Top()
    {
        if (top == null)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        else
        {
            return top.Data;
        }
    }

    private class Node
    {
        public int Data { get; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}