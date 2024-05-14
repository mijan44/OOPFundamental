using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamental.Basic
{
    public class EmployeeExtend : IEmployee
    {
       
        public void AddEmployee(int EmployeeId, string EmployeeName, int EmployeeAge, string EmployeeGender)
        {
            Console.WriteLine($"EmployeeId:{EmployeeId}");
            Console.WriteLine($"EmployeeName:{EmployeeName}");
            Console.WriteLine($"EmployeeAge:{EmployeeAge}");
            Console.WriteLine($"EmployeeGender:{EmployeeGender}");
        }
    }
}
