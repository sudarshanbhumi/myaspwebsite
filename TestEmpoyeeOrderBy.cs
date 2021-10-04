using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    class TestEmpoyeeOrderBy
    {
        public static void TestOrderBy()
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee(1006,"pavan","kumar","Male",50000),
            new Employee(1004,"pavan","kumar","Male",25000),
            new Employee(1008,"Sai","kumari","Female",70000),
            new Employee(1001,"Naveen","kumar","Male",40000),
        };

            IOrderedEnumerable<Employee> orderedEmp = employees.OrderBy(x => x.FirstName).ThenBy(x => x.AnnualSalary);

            IOrderedEnumerable<Employee> emp2 = from empl in employees
                                               orderby empl.EmployeeId descending
                                               select empl;
            foreach(Employee emp in orderedEmp)
            {
                Console.WriteLine($"{emp.EmployeeId} \t {emp.FirstName} \t {emp.AnnualSalary}");
            }

        }
    }
}
