using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Prueba de ArrayQueue ===");
        IQueue arrayQueue = new ArrayQueue(5);
        arrayQueue.Enqueue(1);
        arrayQueue.Enqueue(2);
        arrayQueue.Enqueue(3);
        Console.WriteLine("Front of ArrayQueue: " + arrayQueue.Front()); // Debería imprimir 1
        Console.WriteLine("Dequeue from ArrayQueue: " + arrayQueue.Dequeue()); // Debería imprimir 1
        Console.WriteLine("Front after Dequeue: " + arrayQueue.Front()); // Debería imprimir 2

        Console.WriteLine("\n=== Prueba de LinkedListQueue ===");
        IQueue linkedListQueue = new LinkedListQueue();
        linkedListQueue.Enqueue(10);
        linkedListQueue.Enqueue(20);
        linkedListQueue.Enqueue(30);
        Console.WriteLine("Front of LinkedListQueue: " + linkedListQueue.Front()); // Debería imprimir 10
        Console.WriteLine("Dequeue from LinkedListQueue: " + linkedListQueue.Dequeue()); // Debería imprimir 10
        Console.WriteLine("Front after Dequeue: " + linkedListQueue.Front()); // Debería imprimir 20

        Console.WriteLine("\n=== Prueba de CircularArrayQueue ===");
        IQueue circularQueue = new CircularArrayQueue(3);
        circularQueue.Enqueue(100);
        circularQueue.Enqueue(200);
        circularQueue.Enqueue(300);
        circularQueue.Enqueue(400); // No debería agregarse (overflow)
        Console.WriteLine("Front of CircularQueue: " + circularQueue.Front()); // Debería imprimir 100
        Console.WriteLine("Dequeue from CircularQueue: " + circularQueue.Dequeue()); // Debería imprimir 100
        Console.WriteLine("Dequeue again: " + circularQueue.Dequeue()); // Debería imprimir 200
        circularQueue.Enqueue(500); // Debe insertarse correctamente
        Console.WriteLine("Front after operations: " + circularQueue.Front()); // Debería imprimir 300
    }
}