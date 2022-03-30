using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class BasketList<T, M>
    {
        public T[] Manqo;
        public M[] Vitamin;
       
        public BasketList()
        {
             Manqo = new T[0];
             Vitamin = new M[0];
           
        }
        public T[] getT()
        {
            return Manqo;
        }
        public M[] getM()
        {
            return Vitamin;
        }
       
        public void Add(T manqo, M vitamin )
        {
            Array.Resize(ref Manqo, Manqo.Length + 1);
            Manqo[Manqo.Length-1] = manqo;

            Array.Resize(ref Vitamin, Vitamin.Length + 1);
            Vitamin[Vitamin.Length-1] = vitamin;

            
        }
        
    }
}
