using System;
namespace BubbleSort;

class Program
{
    public static void Main(string[] args)
    {
        
        int[] array1 = new int[]{45,33,12,55,77,22,33,14,67,12,35};
        char[] array = new char[]{'a','b','c','d'};
        Sort(array);
        Sort(array1);
        foreach(int x in array1)
        {
            Console.Write(x+" ");
        }
        System.Console.WriteLine();
        foreach(char x in array)
        {
            Console.Write(x+" ");
        }
    }

    static void Sort(dynamic array)
        {
            int temp;
            int count;
            for (int i = 0 ; i < array.Length-1 ; i++)
            {
                count = 0;
                for (int j = 0; j < array.Length -1-i  ; j++)
                {
                    if (array[j]> array[j+1])
                    {   
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                        count += 1;
                    }
                }
                if (count == 0)
                {
                    break;
                }
            }
        }
}