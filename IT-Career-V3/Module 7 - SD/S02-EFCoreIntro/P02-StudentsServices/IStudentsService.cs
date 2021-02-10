namespace P02_StudentsServices
{
    public interface IStudentsService
    {
        string AddStudent(string firstName, string lastName, int age, string country, string town, string addressName, int schoolId);
        string GetAllStudents();
        string GetStudentInfoById(int id);
    }
}