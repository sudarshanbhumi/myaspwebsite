using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemo
{
    class LeftOuterJoinDemo
    {
        public static void TestLeftOuterJoin()
        {
            var result = from e in EmployeeD.GetEmployees()
                         join d in Department.GetDepartments()
                         on e.DepartmentId equals d.Id into eGroup
                         from eg in eGroup.DefaultIfEmpty()
                         select new
                         {
                             EmployeeName = e.Name,
                             DeptName = eg.Name == null ? "No Department" : eg.Name
                         };
            var res = EmployeeD.GetEmployees().GroupJoin(
                    Department.GetDepartments(),
                    e => e.DepartmentId, d => d.Id,
                    (emp, dept) => new
                    {
                        emp,
                        dept
                    })
                    .SelectMany(z => z.dept.DefaultIfEmpty(),
                      (a, b) => new
                      {
                          EmployeeName = a.emp.Name,
                          DeptName = b.Name == null ? "No Department" : b.Name
                      }

                     );
        }
    }
}
