using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class unit_test_colas
{
    [TestMethod]
    // Prueba que verifica que se puedan agregar y quitar elementos en orden correcto en ArrayQueue
    public void ArrayQueue_EnqueueAndDequeue_WorksCorrectly()
    {
        IQueue queue = new ArrayQueue(5);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.AreEqual(1, queue.Dequeue()); // Se espera el primero
        Assert.AreEqual(2, queue.Dequeue()); // Luego el segundo
        Assert.AreEqual(3, queue.Dequeue()); // Luego el tercero
    }

    [TestMethod]
    // Prueba que verifica el comportamiento cuando se intenta quitar o acceder al frente en una cola vacía (underflow)
    public void ArrayQueue_Underflow_ReturnsMinusOne()
    {
        IQueue queue = new ArrayQueue(3);
        Assert.AreEqual(-1, queue.Dequeue()); // Espera -1 por cola vacía
        Assert.AreEqual(-1, queue.Front());   // Espera -1 por cola vacía
    }

    [TestMethod]
    // Prueba que verifica que no se agreguen más elementos de los permitidos (overflow)
    public void ArrayQueue_Overflow_DoesNotAddMore()
    {
        IQueue queue = new ArrayQueue(3);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4); // Se espera que no se agregue

        Assert.AreEqual(1, queue.Dequeue());
        Assert.AreEqual(2, queue.Dequeue());
        Assert.AreEqual(3, queue.Dequeue());
        Assert.AreEqual(-1, queue.Dequeue()); // Ya no hay más elementos
    }

    [TestMethod]
    // Prueba que verifica inserción y extracción correcta en una cola basada en listas enlazadas
    public void LinkedListQueue_EnqueueAndDequeue_WorksCorrectly()
    {
        IQueue queue = new LinkedListQueue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Assert.AreEqual(10, queue.Dequeue());
        Assert.AreEqual(20, queue.Dequeue());
        Assert.AreEqual(30, queue.Dequeue());
    }

    [TestMethod]
    // Prueba de underflow en la implementación con listas enlazadas
    public void LinkedListQueue_Underflow_ReturnsMinusOne()
    {
        IQueue queue = new LinkedListQueue();
        Assert.AreEqual(-1, queue.Dequeue()); // Espera -1 porque está vacía
        Assert.AreEqual(-1, queue.Front());   // Espera -1 porque está vacía
    }

    [TestMethod]
    // Prueba que valida que el método Front devuelve el primer elemento insertado en LinkedListQueue
    public void LinkedListQueue_Front_ReturnsFirstElement()
    {
        IQueue queue = new LinkedListQueue();
        queue.Enqueue(99);
        queue.Enqueue(100);
        Assert.AreEqual(99, queue.Front()); // Debe devolver 99 sin quitarlo
    }

    [TestMethod]
    // Prueba que valida que el método Front devuelve el primer elemento insertado en ArrayQueue
    public void ArrayQueue_Front_ReturnsFirstElement()
    {
        IQueue queue = new ArrayQueue(3);
        queue.Enqueue(42);
        queue.Enqueue(43);
        Assert.AreEqual(42, queue.Front()); // Debe devolver 42 sin quitarlo
    }
}
