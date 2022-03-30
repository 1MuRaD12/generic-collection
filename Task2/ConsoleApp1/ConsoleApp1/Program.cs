using System;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList<int, string> sortList = new SortedList<int, string>();
            //sortList.Add(1975, "BASIC");
            //sortList.Add(1952, "SHORT CODE");
            //sortList.Add(1986, "PASCAL");
            //sortList.Add(1978, "C");
            //Console.WriteLine("sort by data:");
            //foreach (var item in sortList.getyear())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("sort by programing language");
            //foreach (var item in sortList.getprog())
            //{
            //    Console.WriteLine(item);
            //}

            SortedList sortedList = new SortedList();
            sortedList.Add(1975, "BASIC");
            sortedList.Add(1952, "SHORT CODE");
            sortedList.Add(1986, "PASCAL");
            sortedList.Add(1978, "C");
            Console.WriteLine("sort by data and sort by programing language:");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }



        }
    }
}
