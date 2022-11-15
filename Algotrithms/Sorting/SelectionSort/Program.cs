using System;
namespace SelectionSort;

class Program
{
    public static void Main(string[] args)
    {
        
        int[] array1 = new int[]{45,33,67,3,5,1,6,2,7,3,7};
        int[] array3 = new int[]{45,33,67,3,5,1,6,2,7,3,7};
        char[] array4 = new char[]{'b','d','m','c','i','b','c','i','s'};
        char[] array5 = new char[]{'b','d','m','c','i','b','c','i','s'};

        Selection(array4);
        SelectionRevese(array5);
        // Selection(array1);
        // SelectionRevese(array3);

        foreach(char x in array4)
        {
            Console.Write(x+" ");
        }

        Console.WriteLine();
        foreach(char x in array5)
        {
            Console.Write(x+" ");
        }
    }

    static void Selection(dynamic array)
    {
        dynamic temp, minimum;
        for (int i = 0; i < array.Length; i++) 
        {
            minimum = i;
            for (int j = i+1 ; j < array.Length; j++)
            {
                if (array[j] < array[minimum]) 
                {
                    minimum = j;
                }
            }
            if(array[i] > array[minimum])
            {
                temp = array[minimum];
                array[minimum] = array[i];
                array[i] = temp;
            }
        }
        
    }
    static void SelectionRevese(dynamic array)
    {
         dynamic temp, minimum;
        for (int i = 0; i < array.Length; i++) 
        {
            minimum = i;
            for (int j = i+1 ; j < array.Length; j++)
            {
                if (array[j] > array[minimum]) 
                {
                    minimum = j;
                }
            }
            if(array[i] < array[minimum])
            {
                temp = array[minimum];
                array[minimum] = array[i];
                array[i] = temp;
            }
        }
        
       
    }
}