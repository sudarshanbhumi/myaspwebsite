using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    class Employe
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double AnnualSalary { get; set; }


        public Employe(int id, string f, string l, string g, double a)
        {
            this.EmployeeId = id;
            this.FirstName = f;
            this.Department = l;
            this.Gender = g;
            this.AnnualSalary = a;
        }
    }
    public class TestEmploye
    {
        public static void TestEmp()
        {
            List<Employe> employees = new List<Employe>()
        {
            new Employe(1006,"pavan","IT","Male",50000),
            new Employe(1004,"Raju","Payroll","Male",25000),
            new Employe(1008,"Sai","IT","Female",70000),
            new Employe(1001,"Naveen","HR","Male",40000),
            new Employe(1002,"Naveena","IT","Female",40000),
            new Employe(1005,"Naveendra","Payroll","Male",40000),
            new Employe(1003,"shankar","HR","Male",40000),
        };

            //var emps= employees.GroupBy(x => x.Department);

            var emps = from emp in employees
                       group emp by emp.Department;
            var employes = from emp in employees
                           group emp by emp.Department into empGroup
                           orderby empGroup.Key ascending
                           select new
                           {
                               Key = empGroup.Key,
                               Employees = empGroup.OrderBy(x => x.FirstName)
                           };
            var employeess = employees.GroupBy(x => new { x.Department, x.Gender })
                           .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
                           .Select(g => new
                           {
                               Dept = g.Key.Department,
                               Gender = g.Key.Gender,
                               emps = g.OrderBy(x=>x.FirstName)
                           });

            foreach(var emp in employeess)
            {
                Console.WriteLine($"{emp.Dept}=========={emp.emps.Count(x=>x.Gender=="Male")}");
                Console.WriteLine("-------------------------------");
                foreach(var e in emp.emps)
                {
                    Console.WriteLine($"{e.FirstName} \t {e.Department}");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

