using System;
using System.Collections.Generic;

namespace dotnet_boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<object> newList = new List<object>();
            newList.Add(7);
            newList.Add(28);
            newList.Add(-1);
            newList.Add(true);
            newList.Add("chair");

            foreach(var entry in newList)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine();
            int sum = 0;
            foreach(var entry in newList)
            {
                if(entry is int)
                {
                    int intEntry = (int)entry;
                    sum += intEntry;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
