using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamental.Basic
{
    public class Employee : IEmployee
    {
        //private readonly IEmployee _employee;
        //public Employee(IEmployee employee)
        //{

        //    _employee = employee;

        //}

        //private Guid EmployeeId { get; set; }
        //public string EmployeeName { get; set; }
        //public int EmployeeAge { get; set; }
        //public string EmployeeGender { get; set; }


        //public Employee( string name, int age, string gender)
        //{
        //    EmployeeId = Guid.NewGuid();
        //    EmployeeName = name;
        //    EmployeeAge = age;
        //    EmployeeGender = gender;
        //}






        //public void AddEmployee()
        //{
        //    Console.WriteLine($"EmployeeId:{EmployeeId}");
        //    Console.WriteLine($"EmployeeName:{EmployeeName}");
        //    Console.WriteLine($"EmployeeAge:{EmployeeAge}");
        //    Console.WriteLine($"EmployeeGender:{EmployeeGender}");
        //}
        public void AddEmployee(string EmployeeName)
        {
            Console.WriteLine($"Employee name:{EmployeeName}");
        }
    }
}
