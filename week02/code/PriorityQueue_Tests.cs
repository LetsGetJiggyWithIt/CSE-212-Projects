using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with bob(1), sally(1), george(4), phil(3), and larry(4)
    // Then iterate until the queue is empty
    // Expected Result: [george, larry, phil, bob, sally]
    // Defect(s) Found: Objects weren't being removed from the queue at all when dequeueing 😬

    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Sally", 1);
        priorityQueue.Enqueue("George", 4);
        priorityQueue.Enqueue("Phil", 3);
        priorityQueue.Enqueue("Larry", 4);
        List<string> expected = ["George", "Larry", "Phil", "Bob", "Sally"];
        for (var i = 0; i < 5; i++) {
            var tmpPerson = priorityQueue.Dequeue();
            Assert.AreEqual(tmpPerson, expected[i]);
        }
    }

    [TestMethod]
    // Scenario: Attempt to Dequeue with an empty queue
    // Expected Result: Throw a relevant error
    // Defect(s) Found: None (?)
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        try {
            var tmpTest = priorityQueue.Dequeue();
            Assert.Fail("b r u h (Error should've been thrown)");
        }
        catch (InvalidOperationException e) {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    // Add more test cases as needed below.
}