using Microsoft.Extensions.DependencyInjection;
using OOPFundamental.Basic;


class Program
{
    
    static void Main(string[] args)
    {
        //Student student = new Student("Himel",30,"Male");
        //student.AddStudent();


        ////Teacher.TeacherName = "Mia";
        //Teacher.AddTeacher();

        //Employee employee = new Employee( "mijan", 27, "Male");
        //employee.AddEmployee();




        ////for employee1
        //Employee1 emp1 = new Employee1(101, "System.NullReferenceException: 'Object reference not set to an instance of an object.'Munsi");
        //emp1.AddEmployee1();


        //invoke addProduct 
        //  Product product = new Product(102, "AppleJuice", "Apple red");
        //product.AddProduct();


        //_iemp.AddEmployee();


        var serviceProvider = new ServiceCollection()
            .AddSingleton<IEmployee, Employee>()
            .BuildServiceProvider();

        var employeeService = serviceProvider.GetService<IEmployee>();
        employeeService.AddEmployee("Mijan");
        Console.ReadLine();

    }
}