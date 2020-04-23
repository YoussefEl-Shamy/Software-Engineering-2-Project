using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Software2_project.Models;

namespace Software2_project.ViewModel
{
    public class StudentExamsCoursesViewModel
    {
        public StudentModel student { get; set; }
        public List<ExamModel> exams { get; set; }
        public List<CourseModel> courses { get; set; }
    }
}