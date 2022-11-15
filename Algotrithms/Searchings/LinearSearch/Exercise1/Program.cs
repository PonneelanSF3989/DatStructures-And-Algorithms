using System;
namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
        
        int[] array1 = new int[]{45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        string[] array2 = new string[]{"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        char[] array3 = new char[] {'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
        double[] array4 = new double[]{1.1,65.3,93.9,55.5,3.5,6.9 };
        int LinearSearch(dynamic array,dynamic element)
        {
            int index = -1;
            for(int i = 0 ; i < array.Length ; i++)
            {
                if (element.Equals(array[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        int position = LinearSearch(array1,67);
        Console.WriteLine($"Element {67} at the index of {position}");

        position = LinearSearch(array2,"SF3067");
        Console.WriteLine($"Element SF3067 at the index of {position}");
        position = LinearSearch(array3,'m');
        Console.WriteLine($"Element 'm' at the index of {position}");
        position = LinearSearch(array4,3.5);
        Console.WriteLine($"Element {3.5} at the index of {position}");



        
    
    }
}