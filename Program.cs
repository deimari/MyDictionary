using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "table");
            myDictionary.Add(2, "spoon");
            myDictionary.Add(3, "fork");
            Console.WriteLine(myDictionary[3]);
            myDictionary[3] = "phone";
            Console.WriteLine(myDictionary[3]);
        }
    }
}
