namespace StudentSystem.Services
{
    using Microsoft.EntityFrameworkCore;
    using StudentSystem.Data;
    using StudentSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading.Tasks;

    public class StudentsService
    {
        private readonly AppDbContext context = new AppDbContext();

        public async Task CreateStudentAsync(string name, string phoneNumber = null, string birthDate = null)
        {
            Student student = new Student()
            {
                Name = name.Length > 3 ? name : throw new ArgumentException("Invalid name!"),
                PhoneNumber = phoneNumber != null && phoneNumber.Length == 10 ? phoneNumber : null,
                BirthDay = DateTime.ParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };

            context.Students.Add(student);
            var result = await context.SaveChangesAsync();
        }

        public async Task<ICollection<Student>> GetAllStudentsAsync()
        {
            return await this.context.Students.ToListAsync();
        }
    }
}
