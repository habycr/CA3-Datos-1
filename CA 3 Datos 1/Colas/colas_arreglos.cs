public class ArrayQueue : IQueue
{
    private int[] queue;
    private int front;
    private int rear;
    private int size;

    public ArrayQueue(int size)
    {
        this.size = size;
        queue = new int[size];
        front = -1;
        rear = -1;
    }

    public void Enqueue(int element)
    {
        if (rear == size - 1)
        {
            Console.WriteLine("Queue Overflow");
        }
        else
        {
            if (front == -1) front = 0;
            queue[++rear] = element;
        }
    }

    public int Dequeue()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        else
        {
            return queue[front++];
        }
    }

    public int Front()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        else
        {
            return queue[front];
        }
    }
}