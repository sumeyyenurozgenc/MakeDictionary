using System;

namespace MakeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "C# Kursu");
            myDictionary.Add(2, "Java Kursu");
            myDictionary.Add(3, "SQL Kursu");

        }
    }
}
