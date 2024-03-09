public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Verify that the Enqueue function adds an item (with data and priority) to the back of the queue.
        // Expected Result: [Bob (Pri:2), Tim (Pri:5), Sue (Pri:3)]
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        Console.WriteLine(priorityQueue);

        // Defect(s) Found: no errors found

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Verify that the Dequeue function removes the item with the highest priority and returns its value.
        // Expected Result: Tim Sue Bob
        Console.WriteLine("Test 2");

        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        for(int i = 0; i < 3; ++i) {
            Console.WriteLine($"{priorityQueue.Dequeue()}");
        }

        // Defect(s) Found: the _queue was not removing the element

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Multiple Items with the Same High Priority.
        // Expected Result: Tim Dan Sue Bob
        Console.WriteLine("Test 3");

        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("Dan", 5);

        for(int i = 0; i < 4; ++i) {
            Console.WriteLine($"{priorityQueue.Dequeue()}");
        }

        // Defect(s) Found: the for was taking the last person in the queue not the firts (was not following the FIFO strategy), and it was not considering the last element in the queue.

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Verify that an error message is displayed when attempting to dequeue from an empty queue.
        // Expected Result: An error message should be displayed
        Console.WriteLine("Test 4");

        priorityQueue = new PriorityQueue();
        Console.WriteLine($"{priorityQueue.Dequeue()}");

        // Defect(s) Found: the for was taking the last person in the queue not the firts (was not following the FIFO strategy), and it was not considering the last element in the queue.

        Console.WriteLine("---------");
    }
}