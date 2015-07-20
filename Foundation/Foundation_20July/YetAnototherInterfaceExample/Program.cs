using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnototherInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Test";
            student.Phone = "xxx-xxxx";
            student.Email = "Test@Test.Com";
            student.Address = "Test";
            student.AddCourse("C# From Scratch");
            student.AddCourse("Asp.net");
            student.AddCourse("Asp.net MVC");
            student.DisplayCourses();

        }
    }
}
