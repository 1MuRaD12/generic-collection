using System;

namespace ConsoleApp1
{
    internal class SortedList<T,U>
    {
        public T[] Year;
        public U[] Programing;
        
        public SortedList()
        {
            Year = new T[0];
            Programing = new U[0];
        }
        public U[] getprog()
        {
            return Programing;
        }
        public T[] getyear()
        {
            return Year;
        }
        public void Add(T year, U programing)
        {
            Array.Resize(ref Year, Year.Length + 1);
            Year[Year.Length - 1] = year;
            
            Array.Resize(ref Programing, Programing.Length + 1);
            Programing[Programing.Length - 1] = programing;
        }
    }
}