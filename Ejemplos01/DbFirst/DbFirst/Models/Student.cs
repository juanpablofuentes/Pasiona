using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = null!;
    }
}
