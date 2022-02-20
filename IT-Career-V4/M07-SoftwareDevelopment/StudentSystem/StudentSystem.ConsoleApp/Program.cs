using StudentSystem.Data;
using StudentSystem.Services;

namespace StudentSystem.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();
            StudentsService studentsService = new StudentsService(context);
            CoursesService coursesService = new CoursesService(context);
            Engine engine = new Engine(studentsService,coursesService);
            engine.Run();
        }

    }
}
