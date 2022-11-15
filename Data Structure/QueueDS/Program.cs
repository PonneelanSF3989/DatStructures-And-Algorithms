using System;
namespace QueueDS;

class Program
{
    public static void Main(string[] args)
    {
        Queue<int> myQueue = new Queue<int>(2);
        myQueue.EnQueue(20);
        myQueue.EnQueue(10);
        myQueue.EnQueue(5);
         Console.WriteLine(myQueue.DeQueue());
        // Console.WriteLine(myQueue.DeQueue());
        // Console.WriteLine(myQueue.DeQueue());
        // Console.WriteLine(myQueue.DeQueue());//return 0 
        // Console.WriteLine(myQueue.DeQueue());//return 0
        Console.WriteLine(myQueue.Peek());
        Console.WriteLine(myQueue.Contains(20));


    }
}