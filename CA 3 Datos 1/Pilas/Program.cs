using Pilas;

class Program
{
    static void Main(string[] args)
    {
        // Prueba de ArrayStack
        IStack arrayStack = new ArrayStack(5);
        arrayStack.Push(3);
        arrayStack.Push(5);
        Console.WriteLine("Top of ArrayStack: " + arrayStack.Top()); // Debería imprimir 5
        Console.WriteLine("Pop from ArrayStack: " + arrayStack.Pop()); // Debería imprimir 5
        Console.WriteLine("Top of ArrayStack after Pop: " + arrayStack.Top()); // Debería imprimir 3

        // Prueba de LinkedListStack
        IStack linkedListStack = new LinkedListStack();
        linkedListStack.Push(10);
        linkedListStack.Push(20);
        Console.WriteLine("Top of LinkedListStack: " + linkedListStack.Top()); // Debería imprimir 20
        Console.WriteLine("Pop from LinkedListStack: " + linkedListStack.Pop()); // Debería imprimir 20
        Console.WriteLine("Top of LinkedListStack after Pop: " + linkedListStack.Top()); // Debería imprimir 10
    }
}