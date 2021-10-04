using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemo
{
    class TestGroupJoin
    {
        public static void TestJoin()
        {
            var employeesByDepartment = Department.GetDepartments()
                                      .GroupJoin(EmployeeD.GetEmployees(),
                                      d => d.Id,
                                      e => e.DepartmentId,
                                      (department, employees) => new
                                      {
                                          Department = department,
                                          Employees=employees
                                      }
                                      );
            var empsByDepartment = from department in Department.GetDepartments()
                                   join e in EmployeeD.GetEmployees() on
                                   department.Id equals e.DepartmentId into egroup
                                   select new
                                   {
                                       Department = department,
                                       Employees = egroup
                                   };

            foreach(var emp in empsByDepartment)
            {
                Console.WriteLine(emp.Department.Name);

                foreach(var e in emp.Employees)
                {
                    Console.WriteLine($"{e.Name} ===> {emp.Department.Name}");
                }

            }


        }
    }
}
