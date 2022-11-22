namespace MyQueue;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        MyQueue<string> myQ = new MyQueue<string>();
        MyQueue<string> myOtherQ = new MyQueue<string>();

        //myOtherQ.enqueue(null);

        myQ.enqueue("please");
        myQ.enqueue("work");
        myQ.enqueue("im");
        myQ.enqueue("begging");

        Console.WriteLine(myQ.peek());
        Console.WriteLine(myQ.peek());
        Console.WriteLine(myQ.peek());

        myQ.printQueue();

        Console.WriteLine(myQ.Contains("work"));
        Console.WriteLine(myQ.Contains("dont"));
        //Console.WriteLine(myOtherQ.Contains(null));

        myQ.Clear();
        Console.WriteLine(myQ.Size());
    }
}
