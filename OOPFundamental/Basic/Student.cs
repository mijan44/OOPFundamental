using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamental.Basic
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public string StudentGender { get; set; }


        public Student(string name, int age,string gender)
        {
            StudentName = name;
            StudentAge = age;
            StudentGender = gender;
        }


        public void AddStudent()
        {
            Console.WriteLine($"StudentName: {StudentName}");
            Console.WriteLine($"StudentAge:{StudentAge}");
            Console.WriteLine($"StudentGender:{StudentGender}");
            

        }


    }


}

