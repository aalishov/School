using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P05_StudentsSystem.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; } = DateTime.UtcNow;

        public DateTime? Birthday  { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}
