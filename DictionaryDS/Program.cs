using System;

namespace DictionaryDS;
class program
{
    public static void Main(string[] args)
    {
        Dictionary<int , string> myDictionary = new Dictionary<int, string>(2);
        myDictionary.Add(1,"vasanth");
        myDictionary.Add(2,"Ponneelan");
        myDictionary.Add(3,"poo");

        // Console.WriteLine(myDictionary.SearchKey(2));
        // Console.WriteLine(myDictionary.SearchValue("Ponneelan"));
        // Console.WriteLine(myDictionary.SearchKey(4));
        // Console.WriteLine(myDictionary.SearchValue("ponneelan"));
        // Console.WriteLine(myDictionary.ContainsKey(3));
        // Console.WriteLine(myDictionary.ContainsKey(4));
        // Console.WriteLine(myDictionary.ContainsValue("vasanth"));
        // Console.WriteLine(myDictionary.ContainsValue("abc"));

        // myDictionary.Remove(2);
        // Console.WriteLine(myDictionary.Count);
        myDictionary.Add(4,"poo");
        Console.WriteLine(myDictionary.Count);
        Console.WriteLine(myDictionary[4]);
        myDictionary[4] = "Vasanth";
        foreach(KeyValuePair<int, string> pairs in myDictionary)
        {
            Console.WriteLine("SlNo : "+pairs.Key +"       "+"Name"+" : "+pairs.Value);
        }


    }
}