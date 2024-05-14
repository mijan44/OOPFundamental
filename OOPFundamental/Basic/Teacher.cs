using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamental.Basic
{
    static class Teacher
    {
        //public static  int TeacherId { get; set; }
        //public static string TeacherName { get; set; }
        //public static string TeacherAge { get; set; }
        //public static string TeacherGender { get; set; }

        public static int TeacherId = 0;
        public static string TeacherName = "Rasel";
        public static string TeacherAge = "40";
        public static string TeacherGender = "Female";


        public static void AddTeacher()
        {
            Console.WriteLine("TeacherName:{0}",TeacherName);
            Console.WriteLine("TeacherAge:{0}",TeacherAge);
            Console.WriteLine("TeacherGender:{0}", TeacherGender);
        }

    }
}
