using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Apple<M>
    {
        public string Name;
        public M AP;

        public Apple(string name, M Ap)
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
