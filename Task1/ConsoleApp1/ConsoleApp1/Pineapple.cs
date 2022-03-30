using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Pineapple<M>
    {
        public string Name;
        public M AP;

        public Pineapple(string name, M Ap)
        {
            Name = name;
            AP = Ap;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Vitamin view: {AP}";
        }
    }
}
