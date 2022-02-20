

namespace StudentSystem.Services
{
    using Microsoft.EntityFrameworkCore;
    using StudentSystem.Data;
    using StudentSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class CoursesService
    {
        private readonly AppDbContext context;

        public CoursesService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<string> CreateCourseAsync(string name, string price, string startDate, string endDate, string description = null)
        {
            try
            {
                DateTime start = DateTime.ParseExact(startDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime end = DateTime.ParseExact(endDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (start<DateTime.Now)
                {
                    throw new ArgumentException("Start date must be after today!");
                }
                if (start >= end)
                {
                    throw new ArgumentException("Start date must be before end date!");
                }
                Course course = new Course()
                {
                    Name = name,
                    Price = double.Parse(price),
                    StartDate = start,
                    EndDate = end,
                    Description = description
                };
                this.context.Courses.Add(course);
                await this.context.SaveChangesAsync();
                return $"Course created succesfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<ICollection<Course>> GetAllCoursesAsync()
        {
            return await this.context.Courses.ToListAsync();
        }
    }
}
