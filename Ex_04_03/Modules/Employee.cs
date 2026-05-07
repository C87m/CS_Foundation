using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_04_03.Modules
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public Employee(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Employee[ id={Id} , name={Name} , address={Address}]";
        }
    }
}