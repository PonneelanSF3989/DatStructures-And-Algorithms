using System;
namespace MergeSortAlgorith;

class Program
{
    public static void Main(string[] args)
    {
        int [] array = new int[]{1,2,4,3,0,9,8,7,6,5};
        char [] array1 = new char[]{'a','b','c','d','e'};

        var merged = MergeSort(array1,0,array.Length-1);
        foreach(int x in merged)
        {
            Console.Write(x+" ");
        }
    }

    static dynamic MergeSort(dynamic array, int start , int end)
    {
        if (start == end)
        {
            dynamic single = new dynamic[1];
            single[0] = array[start];
            return single;
        }
        int mid  = (start + end) /2;
        dynamic[] array1 = MergeSort(array,start,mid);
        dynamic[] array2 = MergeSort(array,mid+1,end);
        dynamic[]  merged = Merge(array1,array2);
        return merged;
    }

    static dynamic Merge(dynamic[] array1, dynamic[] array2)
    {
        dynamic[] sortedArray = new dynamic[array1.Length+array2.Length];
        int mid = sortedArray.Length/2;
        int i = 0;
        int j = 0;
        int k = 0;
        while(i < array1.Length && j < array2.Length)
        {
            if (array1[i] < array2[j])
            {
                sortedArray[k] = array1[i];
                i++;
                
            }
            else
            {
                sortedArray[k] = array2[j];
                j++;
            }
            k++;
        }
        if (i >= array1.Length)
            {
                while(j < array2.Length)
                {
                    sortedArray[k] = array2[j];
                    k++;
                    j++;
                }
            }
            else
            {
                if (j >= array2.Length )
                {
                    while(i < array1.Length)
                    {
                        sortedArray[k] = array1[i];
                        k++;
                        i++;
                    }
                }
            }

        


        return  sortedArray;
    }
}