public class CircularArrayQueue : IQueue
{
    private int[] queue;
    private int front;
    private int rear;
    private int size;
    private int count;

    public CircularArrayQueue(int size)
    {
        this.size = size;
        queue = new int[size];
        front = 0;
        rear = -1;
        count = 0;
    }

    public void Enqueue(int element)
    {
        if (count == size)
        {
            Console.WriteLine("Queue Overflow");
            return;
        }
        rear = (rear + 1) % size;
        queue[rear] = element;
        count++;
    }

    public int Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        int value = queue[front];
        front = (front + 1) % size;
        count--;
        return value;
    }

    public int Front()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        return queue[front];
    }
}