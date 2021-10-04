using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemo
{
    class TestInnerJoin
    {
        public static void TestInner()
        {
            var result = EmployeeD.GetEmployees().Join(
                        Department.GetDepartments(),
                        e => e.DepartmentId,
                        d => d.Id,
                        (employeeName, deptName) => new
                        {
                            EmployeeName = employeeName.Name,
                            DeptName = deptName.Name
                        });
            var res=from emp in EmployeeD.GetEmployees()
                    join d in Department.GetDepartments() on
                    emp.DepartmentId equals d.Id
                    select new
                    {
                        EmployeeName = emp.Name,
                        DeptName = d.Name
                    };
            foreach (var e in result) {
                Console.WriteLine($"{e.EmployeeName} \t {e.DeptName}");
                    }
            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmployeeName} \t {e.DeptName}");
            }
        }
    }
}
