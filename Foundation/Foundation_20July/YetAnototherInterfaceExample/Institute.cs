﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnototherInterfaceExample
{
    //class Institute:IContact
    //{
    //    private string[] courses;

    //    private Student[] students;
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }

    //    public string Phone
    //    {
    //        get;
    //        set;
    //    }

    //    public string Email
    //    {
    //        get;
    //        set;
    //    }

    //    public string Address
    //    {
    //        get;
    //        set;
    //    }

    //    public void AddCourse(string course)
    //    {
    //        if (courses == null)
    //        {
    //            courses = new string[1];
    //            courses[0] = course;
    //        }
    //        else
    //        {
    //            int newLength = courses.Length + 1;
    //            string[] newCourses = new string[newLength];
    //            Array.Copy(courses, newCourses, courses.Length);
    //            newCourses[newLength - 1] = course;
    //            courses = new string[newLength];
    //            Array.Copy(newCourses, courses, courses.Length);
    //        }
    //    }

    //    public void DisplayCourses()
    //    {
    //        Console.WriteLine(string.Join(",", courses));

    //    }

    //}


    class Institute:CourseBase
    {

        private MyContainer<Student> studentContainder = new MyContainer<Student>();

        public void AddStudent(Student student)
        {
            studentContainder.Add(student);
        }

    }
}
