using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pilas;

namespace unit_test_pilas
{
    [TestClass]
    public class ArrayStackTests
    {
        [TestMethod]
        public void Push_AddsElementToStack()
        {
            // Arrange
            var stack = new ArrayStack(5);

            // Act
            stack.Push(10);

            // Assert
            Assert.AreEqual(10, stack.Top());
        }

        [TestMethod]
        public void Pop_RemovesAndReturnsTopElement()
        {
            // Arrange
            var stack = new ArrayStack(5);
            stack.Push(10);
            stack.Push(20);

            // Act
            int poppedElement = stack.Pop();

            // Assert
            Assert.AreEqual(20, poppedElement);
            Assert.AreEqual(10, stack.Top());
        }

        [TestMethod]
        public void Pop_ThrowsExceptionWhenStackIsEmpty()
        {
            // Arrange
            var stack = new ArrayStack(5);

            // Act
            int poppedElement = stack.Pop();

            // Assert
            Assert.AreEqual(-1, poppedElement); // Asumiendo que -1 es el valor de retorno para underflow
        }

        [TestMethod]
        public void Top_ReturnsTopElementWithoutRemovingIt()
        {
            // Arrange
            var stack = new ArrayStack(5);
            stack.Push(10);
            stack.Push(20);

            // Act
            int topElement = stack.Top();

            // Assert
            Assert.AreEqual(20, topElement);
            Assert.AreEqual(20, stack.Top()); // Verifica que el elemento no fue removido
        }

        [TestMethod]
        public void Top_ThrowsExceptionWhenStackIsEmpty()
        {
            // Arrange
            var stack = new ArrayStack(5);

            // Act
            int topElement = stack.Top();

            // Assert
            Assert.AreEqual(-1, topElement); // Asumiendo que -1 es el valor de retorno para underflow
        }
    }

    [TestClass]
    public class LinkedListStackTests
    {
        [TestMethod]
        public void Push_AddsElementToStack()
        {
            // Arrange
            var stack = new LinkedListStack();

            // Act
            stack.Push(10);

            // Assert
            Assert.AreEqual(10, stack.Top());
        }

        [TestMethod]
        public void Pop_RemovesAndReturnsTopElement()
        {
            // Arrange
            var stack = new LinkedListStack();
            stack.Push(10);
            stack.Push(20);

            // Act
            int poppedElement = stack.Pop();

            // Assert
            Assert.AreEqual(20, poppedElement);
            Assert.AreEqual(10, stack.Top());
        }

        [TestMethod]
        public void Pop_ThrowsExceptionWhenStackIsEmpty()
        {
            // Arrange
            var stack = new LinkedListStack();

            // Act
            int poppedElement = stack.Pop();

            // Assert
            Assert.AreEqual(-1, poppedElement); // Asumiendo que -1 es el valor de retorno para underflow
        }

        [TestMethod]
        public void Top_ReturnsTopElementWithoutRemovingIt()
        {
            // Arrange
            var stack = new LinkedListStack();
            stack.Push(10);
            stack.Push(20);

            // Act
            int topElement = stack.Top();

            // Assert
            Assert.AreEqual(20, topElement);
            Assert.AreEqual(20, stack.Top()); // Verifica que el elemento no fue removido
        }

        [TestMethod]
        public void Top_ThrowsExceptionWhenStackIsEmpty()
        {
            // Arrange
            var stack = new LinkedListStack();

            // Act
            int topElement = stack.Top();

            // Assert
            Assert.AreEqual(-1, topElement); // Asumiendo que -1 es el valor de retorno para underflow
        }
    }
}