public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with multiple priorities and confirm they were correctly added, value and priority
        // Expected Result: [ hello-1.1 (Pri:1), hello-3.1 (Pri:3), hello-1.2 (Pri:1), hello-2.1 (Pri:2), hello-3.2 (Pri:3), hello-2.2 (Pri:2) ]
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("hello-1.1",1);
        priorityQueue.Enqueue("hello-3.1",3);
        priorityQueue.Enqueue("hello-1.2",1);
        priorityQueue.Enqueue("hello-2.1",2);
        priorityQueue.Enqueue("hello-3.2",3);
        priorityQueue.Enqueue("hello-2.2",2);
        Console.WriteLine(priorityQueue);
        
        // Defect(s) Found: 
        // Pass - values and priorities are correctly added to the queue.
        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with multiple priorities and return them in priority order
        // Expected Result: hello-3.1,hello-3.2,hello-2.1,hello-2.2,hello-1.1,hello-1.2
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("hello-1.1",1);
        priorityQueue.Enqueue("hello-3.1",3);
        priorityQueue.Enqueue("hello-1.2",1);
        priorityQueue.Enqueue("hello-2.1",2);
        Console.WriteLine(priorityQueue.Dequeue());
        priorityQueue.Enqueue("hello-3.2",3);
        priorityQueue.Enqueue("hello-2.2",2);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        // Defect(s) Found: 
        //- Fail. Dequeue method is not returning the proper values, probably not removing the correct elements
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Item sith the same priority should be returned in the order they entered the queue
        // Expected Result: hello-3.2, hello-3.1, hello-3.3, hello-1.1, hello-1.2
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("hello-1.1",1);
        priorityQueue.Enqueue("hello-1.2",1);
        priorityQueue.Enqueue("hello-3.2",3);
        priorityQueue.Enqueue("hello-3.1",3);
        priorityQueue.Enqueue("hello-3.3",3);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        // Defect(s) Found: 
        //- Fail. it is returning highest prioity but not the first one or latest one to enter the queue
        Console.WriteLine("---------");

        // Test 4
        // Scenario: Calling dequeue from empty list should retun error message
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue.Dequeue());
        // Defect(s) Found: 
        // Pass. calling Dequeue method on an empty queue shows the message
        Console.WriteLine("---------");
    }
}