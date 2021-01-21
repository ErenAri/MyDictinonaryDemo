using System;
using System.Collections.Generic;

namespace MyDictinonaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> MyDictionary = new Dictionary<int, string>();
            MyDictionary.Add(007, "Eren Arı");
            MyDictionary.Add(001, "Engin Demiroğ");
            MyDictionary.Add(002, "Elon Musk");
            MyDictionary.Add(003, "Bill Gates");
            MyDictionary.Add(004, "Steve Jobs");
            //Console.WriteLine("Kodu : ");
            foreach (var key in MyDictionary.Keys)
            {
                Console.WriteLine("Kodu => "+key);
            }
            //Console.WriteLine("Değerler : ");
            foreach(var value in MyDictionary.Values)
            {
                Console.WriteLine("Değeri => "+value);
            }

        

    }
    }
}
