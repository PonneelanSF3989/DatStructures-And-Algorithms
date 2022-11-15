using System;
using System.Collections.Generic;
namespace SortQuick;

class Program
{
    public static void Main(string[] args)
    {
        int [] array = new int[]{9,7,6,5,4,3,2,1};
        string [] array1 = new string [] {"z","b"};
        QuickSort(array1);
        foreach(string x in array1)
        {
            Console.Write(x+" ");
        }
    }



    public static void  QuickSort(dynamic array)
    {
        int start = 0;
        int end = array.Length-1;
        Start(array,start,end);
    }

    public static void Start(dynamic array , int start, int end)
    {
        int pivot;
        if (start < end)
        {
            pivot = Partition(array,start,end);
            if (pivot > 1)
            {
                Start(array,start,pivot-1);
            }
            else
            {
                Start(array,pivot+1,end);
            }
        }
    }
    public static int Partition(dynamic array, int start , int end)
    {
        int pivot = array[start];
        while(true)
        {
            while(IsLower(array[start] , pivot))
            {
                start++;
            }
            while(IsGreater(array[end] , pivot))
            {
                end--;
            }
            if (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
            }
            else
            {
                return end;
            }
        }
    }
    
    public static bool IsGreater(dynamic value1,dynamic value2)
    {
        var result = Comparer<dynamic>.Default.Compare(value1,value2);
        if (result >= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }  

    public static  bool IsLower(dynamic value1,dynamic value2)
    {
        var result = Comparer<dynamic>.Default.Compare(value1,value2);
        if (result <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }  
}