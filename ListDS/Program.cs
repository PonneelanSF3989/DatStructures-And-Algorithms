using System;
namespace ListDS;

class Program
{
    public static void Main(string[] args)
    {
        List<int> newList = new List<int>();
        newList.Add(3);
        newList.Add(2);
        newList.Add(1);
        newList.Add(5);
        newList.Add(6);

        // List<int> list1 = new List<int>();
        // list1.Add(10);
        // list1.Add(15);
        // list1.Add(20);

        // newList.AddRange(list1);

        // for (int i = 0 ; i < newList.Count ; i++)
        // {
        //     Console.WriteLine(newList[i]);
        // }

        
        // Console.WriteLine();
        // int index = newList.IndexOf(20);
        // Console.WriteLine(index);
        // newList.Insert(3,0);

        //newList.RemoveAt(2);

        newList.Sort();
        // foreach(int numbers in newList)
        // {
        //     Console.Write(numbers+" ");
        // }


        // int[] newArray = newList.ToArray();

        // foreach(int x in newArray)
        // {
        //     Console.Write(x +" ");
        // }


        


        
    }
}