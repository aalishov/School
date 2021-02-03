using P02_StudentsAppData;
using P02_StudentsAppData.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_StudentsServices
{
    public class StudentsService : IStudentsService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IAddressesService addressesService;

        public StudentsService(ApplicationDbContext dbContext, IAddressesService addressesService)
        {
            this.dbContext = dbContext;
            this.addressesService = addressesService;
        }

        public string AddStudent(string firstName, string lastName, int age, string country, string town, string addressName, int schoolId)
        {
            StringBuilder sb = new StringBuilder();

            Address address = addressesService.GetAddressByName(addressName, town, country);
            if (address == null)
            {
                sb.AppendLine(addressesService.AddAddress(addressName, town, country));
                address = addressesService.GetAddressByName(addressName, town, country);
            }

            Student student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Address = address,
                SchoolId = schoolId,
            };

            this.dbContext.Students.Add(student);
            this.dbContext.SaveChanges();

            sb.AppendLine($">> Student {firstName} {lastName} is added!");
            return sb.ToString().TrimEnd();
        }

        public string GetAllStudents()
        {
            StringBuilder sb = new StringBuilder();

            List<Student> students = this.dbContext.Students.ToList();

            sb.AppendLine(">> Students list");
            sb.AppendLine(new string('-', 30));
            sb.AppendLine($"{ "Id",3} | { "First Name",10} | { "Last Name",10} | {"School",10}");
            sb.AppendLine(new string('-', 30));
            foreach (var student in students)
            {
                sb.AppendLine($"{ student.Id,3} | {student.FirstName,10} | {student.LastName,10} | {student.School.Name,10}");
            }
            sb.AppendLine(new string('-', 30));

            return sb.ToString().TrimEnd();
        }

        public string GetStudentInfoById(int id)
        {
            StringBuilder sb = new StringBuilder();

            Student student = this.dbContext.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return $">> Studetn with id {id} not found!";
            }
            sb.AppendLine(new string('-', 30));
            sb.AppendLine($">> Info about student with id: {id}");
            sb.AppendLine(new string('-', 30));
            sb.AppendLine($"  >> First name: {student.FirstName}");
            sb.AppendLine($"  >> Last name: {student.LastName}");
            sb.AppendLine($"  >> Age: {student.Age}");
            sb.AppendLine($"  >> Country: {student.Address.Town.Country.Name}");
            sb.AppendLine($"  >> Town: {student.Address.Town.Name}");
            sb.AppendLine($"  >> Address: {student.Address.Name}");
            sb.AppendLine($"  >> School: {student.School.Name}");
            sb.AppendLine($"  >> School address: {student.School.Address.Name}");
            sb.AppendLine(new string('-', 30));
            return sb.ToString().TrimEnd();
        }
    }
}
