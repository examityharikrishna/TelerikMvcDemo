using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcDemo.Models
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Students = new List<Student>();
            Courses = new List<CoursesViewModel>();
        }
        public List<Student> Students { get; set; }
        public List<CoursesViewModel> Courses { get; set; }
    }

    public class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class CoursesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}