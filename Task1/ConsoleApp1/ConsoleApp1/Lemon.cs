using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Lemon<M>
    {
        public string Name;
        public M AP;

        public Lemon(string name, M Ap)
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
