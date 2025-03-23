public interface IQueue {
    void Enqueue(int element);
    int Dequeue();
    int Front();
}