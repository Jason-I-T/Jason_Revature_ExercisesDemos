namespace MyQueue;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        // MyQueue<string> myQ = new MyQueue<string>();
        // MyQueue<string> myOtherQ = new MyQueue<string>();

        // //myOtherQ.enqueue(null);

        // myQ.enqueue("please");
        // myQ.enqueue("work");
        // myQ.enqueue("im");
        // myQ.enqueue("begging");

        // Console.WriteLine(myQ.peek());
        // Console.WriteLine(myQ.peek());
        // Console.WriteLine(myQ.peek());

        // myQ.printQueue();

        // Console.WriteLine(myQ.Contains("work"));
        // Console.WriteLine(myQ.Contains("dont"));
        // //Console.WriteLine(myOtherQ.Contains(null));

        // myQ.Clear();
        // Console.WriteLine(myQ.Size());

        Queue2 queue = new Queue2();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        queue.PrintQueue();
        
        Console.WriteLine($"Dequeue: {queue.Dequeue()}");
        queue.PrintQueue();

        Console.WriteLine($"Dequeue: {queue.Dequeue()}");
        queue.PrintQueue();

        Console.WriteLine($"Dequeue: {queue.Dequeue()}");
        queue.PrintQueue();

        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.PrintQueue();

        Console.WriteLine($"Peek: {queue.Peek()}");
        Console.WriteLine($"Dequeue: {queue.Dequeue()}");
        queue.PrintQueue();

        Console.WriteLine($"\nPeek: {queue.Peek()}");
        Console.WriteLine($"Dequeue: {queue.Dequeue()}");
        queue.PrintQueue();
    }
}
