using System;
using System.Collections.Generic;

namespace ModelFirst.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
    }
}
