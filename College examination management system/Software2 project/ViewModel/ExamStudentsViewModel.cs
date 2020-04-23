using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Software2_project.Models;

namespace Software2_project.ViewModel
{
    public class ExamStudentsViewModel
    {
        public List<StudentModel> students { get; set; }
        public List<ExamModel> exams { get; set; }
        public CourseModel course { get; set; }
    }
}