namespace StudentSystem.Services
{
    using Microsoft.EntityFrameworkCore;
    using StudentSystem.Data;
    using StudentSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;

    public class StudentsService
    {
        private readonly AppDbContext context;

        public StudentsService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<string> CreateStudentAsync(string name, string phoneNumber = null, string birthDate = null)
        {
            try
            {
                Student student = new Student()
                {
                    Name = name.Length > 3 ? name : throw new ArgumentException("Invalid name!"),
                    PhoneNumber = phoneNumber != null && phoneNumber.Length == 10 ? phoneNumber : null,
                    BirthDay = DateTime.ParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                };

                context.Students.Add(student);
                var result = await context.SaveChangesAsync();
                return $"Student created!";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public async Task<string> RemoveStudentAsync(string id)
        {
            try
            {
                int studentId = int.Parse(id);
                Student student = context.Students.Find(studentId);
                if (student == null)
                {
                    return $"Student not found";
                }
                context.Students.Remove(student);
                await context.SaveChangesAsync();
                return $"Student with id: {student.Id}, name {student.Name} is removed!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<ICollection<Student>> GetAllStudentsAsync()
        {
            return await this.context.Students.ToListAsync();
        }

        public async Task<ICollection<Student>> SearchStudentsByNameAsync(string name)
        {
            return await this.context.Students.Where(x => x.Name == name).ToListAsync();
        }
    }
}
