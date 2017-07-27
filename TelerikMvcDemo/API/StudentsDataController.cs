using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TelerikMvcDemo.Models;

namespace TelerikMvcDemo.API
{
    public class StudentsDataController : ApiController
    {
        StudentViewModel students = new StudentViewModel();
        public StudentsDataController()
        {
            students.Students.Add(new Student { Id = 1, Name = "john", Email = "johnsmith@outlook.com" });
            students.Students.Add(new Student { Id = 2, Name = "smith", Email = "smith@outlook.com" });
            students.Students.Add(new Student { Id = 3, Name = "seen", Email = "seen@outlook.com" });
            students.Students.Add(new Student { Id = 4, Name = "sham", Email = "sham@outlook.com" });
            students.Students.Add(new Student { Id = 5, Name = "ranga", Email = "ranga@outlook.com" });
        }

        //Get Students
        public IHttpActionResult GetStudents()
        {
            return Ok(students);
        }
    }
}
