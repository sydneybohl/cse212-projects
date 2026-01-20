using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items that have the same highest priority and ensure they are dequeued in the order they were added.
    // Expected Result: Items with the same priority are dequeued in FIFO order.
    // Defect(s) Found: The main code did not maintain the order of items with the same priority, causing them to be dequeued in an incorrect order.
    public void TestPriorityQueue_WithSamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("First", result);
    }

    [TestMethod]
    // Scenario: Dequeue is called multiple times.
    // Expected Result: Items are dequeued in priority order.
    // Defect(s) Found: The main code returned the value but it did not remove the item from the queue.
    public void TestPriorityQueue_DequeueRemovesItem()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();

        Assert.AreEqual("B", first);
        Assert.AreEqual("A", second);

    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: The highest priority item is the last item that gets enqueued.
    // Expected Result: The last item is correctly identified as the highest priority item and dequeued first.
    // Defect(s) Found: The main code loop did not examine the last item in the queue correctly, so the highest priority item was not identified.
    public void TestPriorityQueue_HighestPriorityLast()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("High", 5);

        var first = priorityQueue.Dequeue();
        Assert.AreEqual("High", first);

    }

    [TestMethod]
    // Scenario: Dequeue is called on an empty queue.
    // Expected Result: An InvalidOperationException is thrown.
    // Defect(s) Found: The main code correctly throws the exception.
    public void TestPriorityQueue_DequeueEmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}