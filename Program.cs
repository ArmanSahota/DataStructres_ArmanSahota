using System;
//Arman Sahota

namespace DataStructures_ArmanSahota
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Singly Linked List
            TestSinglyLinkedList();

            // Test Doubly Linked List
            TestDoublyLinkedList();

            // Test Queue
            TestQueue();

            // Test Stack
            TestStack();

            Console.ReadLine();
        }

        static void TestSinglyLinkedList()
        {
            Console.WriteLine("Testing Singly Linked List:");

            // Create an instance of SinglyLinkedList
            SinglyLinkedList<int> singlyList = new SinglyLinkedList<int>();

            // Adding elements to the Singly Linked List
            singlyList.AddFirst(1);
            singlyList.AddLast(2);
            singlyList.AddLast(3);

            // Displaying count of elements in the Singly Linked List
            Console.WriteLine("Count: " + singlyList.Count);

            // Displaying elements in the Singly Linked List
            Console.WriteLine("Linked List Elements:");
            singlyList.Display();

            // Removing the first item from the Singly Linked List
            Console.WriteLine("Removing first item: " + singlyList.RemoveFirst());

            // Checking if the Singly Linked List contains a specific value
            Console.WriteLine("Contains 2: " + singlyList.Contains(2));

            // Displaying the Singly Linked List after removal
            Console.WriteLine("Linked List after removal:");
            singlyList.Display();

            // Clearing the Singly Linked List
            Console.WriteLine("Clearing the list.");
            singlyList.Clear();

            // Displaying count after clearing the Singly Linked List
            Console.WriteLine("Count after clearing: " + singlyList.Count);
        }

        // Testing methods for Doubly Linked List
        static void TestDoublyLinkedList()
        {
            Console.WriteLine("\nTesting Doubly Linked List:");

            // Create an instance of DoublyLinkedList
            DoublyLinkedList<int> doublyList = new DoublyLinkedList<int>();

            // Adding elements to the Doubly Linked List
            doublyList.AddFirst(1);
            doublyList.AddLast(2);
            doublyList.AddLast(3);

            // Displaying count of elements in the Doubly Linked List
            Console.WriteLine("Count: " + doublyList.Count);

            // Displaying elements in the Doubly Linked List
            Console.WriteLine("Linked List Elements:");
            doublyList.Display();

            // Removing the last item from the Doubly Linked List
            Console.WriteLine("Removing last item: " + doublyList.RemoveLast());

            // Checking if the Doubly Linked List contains a specific value
            Console.WriteLine("Contains 2: " + doublyList.Contains(2));

            // Displaying the Doubly Linked List after removal
            Console.WriteLine("Linked List after removal:");
            doublyList.Display();

            // Clearing the Doubly Linked List
            Console.WriteLine("Clearing the list.");
            doublyList.Clear();

            // Displaying count after clearing the Doubly Linked List
            Console.WriteLine("Count after clearing: " + doublyList.Count);
        }


        // Testing methods for Queue
        static void TestQueue()
        {
            Console.WriteLine("\nTesting Queue:");

            // Create an instance of Queue
            Queue<int> queue = new Queue<int>();

            // Enqueueing elements to the Queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Displaying count of elements in the Queue
            Console.WriteLine("Count: " + queue.Count);

            // Dequeueing an element from the Queue
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            // Peek at the front element in the Queue
            Console.WriteLine("Peek: " + queue.Peek());

            // Checking if the Queue is empty
            Console.WriteLine("Is Empty: " + queue.IsEmpty);

            // Clearing the Queue
            Console.WriteLine("Clearing the queue.");
            queue = new Queue<int>();

            // Displaying count after clearing the Queue
            Console.WriteLine("Count after clearing: " + queue.Count);
        }

        // Testing methods for Stack
        static void TestStack()
        {
            Console.WriteLine("\nTesting Stack:");

            // Create an instance of Stack
            Stack<int> stack = new Stack<int>();

            // Pushing elements to the Stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Displaying count of elements in the Stack
            Console.WriteLine("Count: " + stack.Count);

            // Popping an element from the Stack
            Console.WriteLine("Pop: " + stack.Pop());

            // Peek at the top element in the Stack
            Console.WriteLine("Peek: " + stack.Peek());

            // Checking if the Stack is empty
            Console.WriteLine("Is Empty: " + stack.IsEmpty);

            // Clearing the Stack
            Console.WriteLine("Clearing the stack.");
            stack = new Stack<int>();

            // Displaying count after clearing the Stack
            Console.WriteLine("Count after clearing: " + stack.Count);
        }

        // Implementation of Singly Linked List
        class SinglyLinkedList<T>
        {
            // Node class for Singly Linked List
            private class Node
            {
                public T Data { get; set; }
                public Node Next { get; set; }

                public Node(T data)
                {
                    Data = data;
                    Next = null;
                }
            }

            private Node head;
            private int count;

            // Method to add an item to the beginning of the Singly Linked List
            public void AddFirst(T item)
            {
                Node newNode = new Node(item);
                newNode.Next = head;
                head = newNode;
                count++;
            }

            // Method to add an item to the end of the Singly Linked List
            public void AddLast(T item)
            {
                Node newNode = new Node(item);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }

                count++;
            }

            // Method to remove the first item from the Singly Linked List
            public T RemoveFirst()
            {
                if (head == null)
                {
                    throw new InvalidOperationException("The list is empty.");
                }

                T data = head.Data;
                head = head.Next;
                count--;

                return data;
            }

            // Method to remove the last item from the Singly Linked List
            public T RemoveLast()
            {
                if (head == null)
                {
                    throw new InvalidOperationException("The list is empty.");
                }

                if (head.Next == null)
                {
                    T data = head.Data;
                    head = null;
                    count--;
                    return data;
                }

                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                T lastData = current.Next.Data;
                current.Next = null;
                count--;

                return lastData;
            }

            // Method to check if the Singly Linked List contains a specific item
            public bool Contains(T item)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Data.Equals(item))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            // Method to clear the Singly Linked List
            public void Clear()
            {
                head = null;
                count = 0;
            }

            // Property to get the count of elements in the Singly Linked List
            public int Count
            {
                get { return count; }
            }

            // Method to display the elements of the Singly Linked List
            public void Display()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            // Method to get the first element in the Singly Linked List
            public T First()
            {
                if (head == null)
                {
                    throw new InvalidOperationException("The list is empty.");
                }

                return head.Data;
            }

            // Method to get the last element in the Singly Linked List
            public T Last()
            {
                if (head == null)
                {
                    throw new InvalidOperationException("The list is empty.");
                }

                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                return current.Data;
            }
        }

        // Implementation of Doubly Linked List
        class DoublyLinkedList<T>
        {
            // Node class for Doubly Linked List
            private class Node
            {
                public T Data { get; set; }
                public Node Previous { get; set; }
                public Node Next { get; set; }

                public Node(T data)
                {
                    Data = data;
                    Previous = null;
                    Next = null;
                }
            }

            private Node head;
            private Node tail;
            private int count;

            // Method to add an item to the beginning of the Doubly Linked List
            public void AddFirst(T item)
            {
                Node newNode = new Node(item);

                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head.Previous = newNode;
                    head = newNode;
                }

                count++;
            }

            // Method to add an item to the end of the Doubly Linked List
            public void AddLast(T item)
            {
                Node newNode = new Node(item);

                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    tail = newNode;
                }

                count++;
            }

            // Method to remove the first item from the Doubly Linked List
            public T RemoveFirst()
            {
                if (head == null)
                {
                    throw new InvalidOperationException("The list is empty.");
                }

                T data = head.Data;

                if (head.Next == null)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head.Next.Previous = null;
                    head = head.Next;
                }

                count--;

                return data;
            }

            // Method to remove the last item from the Doubly Linked List
            public T RemoveLast()
            {
                if (head == null)
                {
                    throw new InvalidOperationException("The list is empty.");
                }

                T data = tail.Data;

                if (tail.Previous == null)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    tail.Previous.Next = null;
                    tail = tail.Previous;
                }

                count--;

                return data;
            }

            // Method to check if the Doubly Linked List contains a specific item
            public bool Contains(T item)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Data.Equals(item))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            // Method to clear the Doubly Linked List
            public void Clear()
            {
                head = null;
                tail = null;
                count = 0;
            }

            // Property to get the count of elements in the Doubly Linked List
            public int Count
            {
                get { return count; }
            }

            // Method to display the elements of the Doubly Linked List
            public void Display()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }

        // Implementation of Queue using Singly Linked List
        class Queue<T>
        {
            private SinglyLinkedList<T> linkedList;

            public Queue()
            {
                linkedList = new SinglyLinkedList<T>();
            }

            // Enqueue an element to the Queue
            public void Enqueue(T item)
            {
                linkedList.AddLast(item);
            }

            // Dequeue an element from the Queue
            public T Dequeue()
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException("The queue is empty.");
                }

                return linkedList.RemoveFirst();
            }

            // Peek at the front element in the Queue
            public T Peek()
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException("The queue is empty.");
                }

                return linkedList.First();
            }

            // Check if the Queue is empty
            public bool IsEmpty
            {
                get { return linkedList.Count == 0; }
            }

            // Get the count of elements in the Queue
            public int Count
            {
                get { return linkedList.Count; }
            }
        }

        // Implementation of Stack using Singly Linked List
        class Stack<T>
        {
            private SinglyLinkedList<T> linkedList;

            public Stack()
            {
                linkedList = new SinglyLinkedList<T>();
            }

            // Push an element to the Stack
            public void Push(T item)
            {
                linkedList.AddLast(item);
            }

            // Pop an element from the Stack
            public T Pop()
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException("The stack is empty.");
                }

                return linkedList.RemoveLast();
            }

            // Peek at the top element in the Stack
            public T Peek()
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException("The stack is empty.");
                }

                // Assuming you have a method like Last() in your SinglyLinkedList class
                return linkedList.Last();
            }

            // Check if the Stack is empty
            public bool IsEmpty
            {
                get { return linkedList.Count == 0; }
            }

            // Get the count of elements in the Stack
            public int Count
            {
                get { return linkedList.Count; }
            }
        }
    }
}
