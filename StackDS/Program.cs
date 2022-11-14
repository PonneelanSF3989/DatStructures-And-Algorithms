using System;

namespace StackDS;

class Program
{
    public static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>(2);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        // Console.WriteLine(myStack.Peek());
        // Console.WriteLine(myStack.Pop());
        // Console.WriteLine(myStack.Peek());
        // Console.WriteLine(myStack.Contains(3));

        // for (int i = 0 ; i < myStack.Count ; i++)
        // {
        //     Console.WriteLine(myStack[i]+ "");
        // }

        //not possible to print the all emlement in the stack
        // Console.WriteLine(myStack.Pop());
        // Console.WriteLine(myStack.Pop());
        // Console.WriteLine(myStack.Pop());
        // Console.WriteLine(myStack.Pop());
        // Console.WriteLine(myStack.Pop());



    }
}