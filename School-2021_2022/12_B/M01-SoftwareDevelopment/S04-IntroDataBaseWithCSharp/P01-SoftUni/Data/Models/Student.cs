
namespace P01_SoftUni.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TownId { get; set; }

        public Town Town { get; set; }
    }
}
