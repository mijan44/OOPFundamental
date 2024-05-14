using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamental.Basic
{
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Employee1(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddEmployee1()
        {
            Console.WriteLine($"Id:{Id}");
            Console.WriteLine($"Name:{Name}");
            
        }

    }
}
