using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LinqDemo
{
    class Sorting
    {
        public static void SortEmps()
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee(1006,"pavan","kumar","Male",50000),
            new Employee(1004,"Raju","kumar","Male",25000),
            new Employee(1008,"Sai","kumari","Female",70000),
            new Employee(1001,"Naveen","kumar","Male",40000),
        };
            //SortByName sortByName = new SortByName();

            //  employees.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));

            employees.Sort(delegate (Employee c1, Employee c2) { return c1.FirstName.CompareTo(c2.FirstName); });

           // Comparison<EmployeeD> e1 = new Comparison<EmployeeD>(CompareName);
           // emps.Sort(e1);
            foreach (var e in employees)
            {
                Console.WriteLine(e.FirstName);
            }
        }
         

        private static  int CompareName(Employee x, Employee y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }


            }

    

    public class SortByName : IComparer<EmployeeD>
    {
        public int Compare( EmployeeD x, EmployeeD y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
