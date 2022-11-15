using System;
using System.Collections.Generic;
namespace BinarySearch;


class Program
{
    public static void Main(string[] args)
    {
        int x;
        int [] array2 = new int[]{45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77    };
        string[] array1 = new string[]{"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        char[] array3 = new char[] {'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
        double[] array4 = new double[]{1.1,65.3,93.9,55.5,3.5,6.9 };
        //Array.Sort(array1);
        Array.Sort(array2);
        Array.Sort(array3);
        Array.Sort(array4);
        x = BinarySearch(array1,"SF3067");//Return-1 while for this is an Un sorted array
        Console.WriteLine($"Element SF3067 at the Index of {x}");
        x = BinarySearch(array2,66);///Return-1 while for this is an Un sorted array
        Console.WriteLine($"Element {66} at the Index of {x}");
        x = BinarySearch(array3,'m');// return the position of 66 at 11 
        Console.WriteLine($"Element 'm' at the Index of {x}");
        x = BinarySearch(array4,3.5);///Return-1 while for this is an Un sorted array
        Console.WriteLine($"Element {3.5} at the Index of {x}");
    }

    static int BinarySearch(dynamic array, dynamic data)
    {
        int position = -1;
        int left = 0;
        int right = array.Length ;
        int mid ;
        while(left < right)
        {
            mid  = (left+right)/2;
            if (data == array[mid])
            {
                position = mid;
                break;
            }
            else if(IsGreater(data,array[mid]))
            {
                right = mid -1;
            }
            else
            {
                left = mid+1;
            }
           
        }
        return position;
    }
    static public bool IsGreater(dynamic value1,dynamic value2)
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


}