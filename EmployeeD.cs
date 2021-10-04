using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    public class EmployeeD

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public static List<EmployeeD> GetEmployees()
        {
            List<EmployeeD> employees = new List<EmployeeD>()
            {
                new EmployeeD(){Id=1,Name="Pavan",DepartmentId=1},
                new EmployeeD(){Id=2,Name="Kumar",DepartmentId=2},
                new EmployeeD(){Id=3,Name="Anjali",DepartmentId=1},
                new EmployeeD(){Id=4,Name="Vinay",DepartmentId=2},
                new EmployeeD(){Id=5,Name="Reddy",DepartmentId=1},
                new EmployeeD(){Id=6,Name="Kajal",DepartmentId=2},
                new EmployeeD(){Id=7,Name="Dheeraj",DepartmentId=1},
                new EmployeeD(){}
            };

            return employees;
        }
    }
}
