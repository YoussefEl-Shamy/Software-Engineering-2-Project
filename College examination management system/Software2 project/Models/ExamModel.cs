using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Software2_project.Models
{
    public class ExamModel
    {
        public short id { get; set; }
        [Required]
        public short student_id { get; set; }
        [Required]
        public short course_id { get; set; }
        [Required]
        public short grade { get; set; }
    }
}