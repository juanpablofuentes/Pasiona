using System;
using System.Collections.Generic;

namespace ModelFirst.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = null!;
    }
}
