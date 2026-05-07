using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    internal class Book
    {
        public string Name {  get; set; }
        internal Book(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}