using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P05_StudentsSystem.Data.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime  StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }= new List<Resource>();
        public virtual ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}
