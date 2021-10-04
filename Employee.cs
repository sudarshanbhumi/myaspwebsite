using LinqDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public double AnnualSalary { get; set; }


        public Employee(int id,string f,string l,string g,double a)
        {
            this.EmployeeId = id;
            this.FirstName = f;
            this.LastName = l;
            this.Gender = g;
            this.AnnualSalary = a;
        }
    }
    
}

    class TestEmployee{
   public static List<Employee> employees;
    public TestEmployee()
    {
        employees = new List<Employee>()
        {
            new Employee(1006,"pavan","kumar","Male",50000),
            new Employee(1004,"Raju","kumar","Male",25000),
            new Employee(1008,"Sai","kumari","Female",70000),
            new Employee(1001,"Naveen","kumar","Male",40000),
        };
    }
    public static  void TestEmp()
    {

        employees.Sort();



       IEnumerable<int> ids=employees.Select(x => x.EmployeeId);
       var result= employees.Select(emp => new { FirstName = emp.FirstName, Gender = emp.Gender });
        foreach(int id in ids)
        {
            Console.WriteLine("Employee id is =" + id);
        }
        foreach (var res in result)
        {
            Console.WriteLine($"Employee FirstName is = { res.FirstName} Gender is {res.Gender}");
        }
    }

    public string this[int id]
    {
        get
        {
            return employees.FirstOrDefault(x => x.EmployeeId == id).FirstName;
        }
        set
        {
            employees.FirstOrDefault(x => x.EmployeeId == id).FirstName = value;
        }
    }

}

class TestIndex
{
    public static void TestInd()
    {
        TestEmployee emp = new TestEmployee();
        Console.WriteLine("Name of employee with id 1001 is " + emp[1001]);
        emp[1001] = "Sunil";
        Console.WriteLine("Name of employee with id 1001 is " + emp[1001]);

       Dictionary<int,Employee> e= TestEmployee.employees.ToDictionary(x => x.EmployeeId);
    }
}
