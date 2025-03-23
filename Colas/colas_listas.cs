public class LinkedListQueue : IQueue
{
    private class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node front;
    private Node rear;

    public LinkedListQueue()
    {
        front = null;
        rear = null;
    }

    public void Enqueue(int element)
    {
        Node newNode = new Node(element);
        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }
    }

    public int Dequeue()
    {
        if (front == null)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        else
        {
            int value = front.Data;
            front = front.Next;
            if (front == null) rear = null;
            return value;
        }
    }

    public int Front()
    {
        if (front == null)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        else
        {
            return front.Data;
        }
    }
}
