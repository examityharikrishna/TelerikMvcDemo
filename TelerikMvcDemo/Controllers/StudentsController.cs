using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcDemo.Models;

namespace TelerikMvcDemo.Controllers
{
    public class StudentsController : Controller
    {
        StudentViewModel students = new StudentViewModel();


        public StudentsController()
        {
            students.Students.Add(new Student { Id = 1, Name = "john", Email = "johnsmith@outlook.com" });
            students.Students.Add(new Student { Id = 2, Name = "smith", Email = "smith@outlook.com" });
            students.Students.Add(new Student { Id = 3, Name = "seen", Email = "seen@outlook.com" });
            students.Students.Add(new Student { Id = 4, Name = "sham", Email = "sham@outlook.com" });
            students.Students.Add(new Student { Id = 5, Name = "ranga", Email = "ranga@outlook.com" });

            students.Courses.Add(new CoursesViewModel { Id = 1, Name = "Maths" });
            students.Courses.Add(new CoursesViewModel { Id = 2, Name = "Physics" });
            students.Courses.Add(new CoursesViewModel { Id = 3, Name = "Computers" });
        }

        public ActionResult Students()
        {
            return View(students);
        }
        public ActionResult GetCourses([Kendo.Mvc.UI.DataSourceRequest]Kendo.Mvc.UI.DataSourceRequest request)
        {
           
           return View("Students", students);
        }
    }
}