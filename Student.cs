using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public List<string> Subjects { get; set; }


        public static IEnumerable<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Name="Ravi",Gender="Male",Subjects=new List<string>(){"C#","JAVA" } },
                new Student(){Name="Kajal",Gender="Female",Subjects=new List<string>(){"Python","JAVA","Ruby" } },
                new Student(){Name="Surya",Gender="Male",Subjects=new List<string>(){"C#","HTML","Javascript","TestNG" } },
                new Student(){Name="Priya",Gender="Female",Subjects=new List<string>(){"Selenium","RPA","Jquery","Maven" } },

            };

            return students;
        }
    }

    class TestStudents
    {
        public static void TestStud()
        {
            // IEnumerable<string> studs= Student.GetAllStudents().SelectMany(x => x.Subjects);
            var result = Student.GetAllStudents().SelectMany(x => x.Subjects, (student, subject) => new
            {
                name = student.Name,
                subject = subject
            });

           IEnumerable<string> studs = (from student in Student.GetAllStudents()
                                        from sub in student.Subjects
                                        select sub).Distinct();

       var result2=from student in Student.GetAllStudents()
                  from sub in student.Subjects
                 select new { studentName = student.Name, subName = sub };

            foreach (string s in studs)
            {
                Console.WriteLine(s);
            }
            foreach (var s in result)
            {
                Console.WriteLine($"Name is {s.name} subject is  {s.subject}");
            }
        }

        
    }

    
    
}
