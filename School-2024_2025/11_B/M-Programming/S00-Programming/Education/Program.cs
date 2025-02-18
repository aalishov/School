namespace Education
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Speciality speciality1 = new Speciality("Profile 'Software and hardware sciences'", "Profile training with a focus on Informatics , IT, and math");
            Speciality speciality2 = new Speciality("Profession 'Applied Programmer'", "professional training with a focus on programming and software development");

            Group group1 = new Group("9A", new List<Student>());
            Group group2 = new Group("9B", new List<Student>());

            Student student1 = new Student("Stefan Kirov", 16, group1, speciality2);
            Student student2 = new Student("Kiril Valchev", 15, group1, speciality2);
            Student studen3 = new Student("Mariela Draganova", 16, group1, speciality2);

            Teacher teacher1 = new Teacher("A. Grigorov", "Math and Physics");
            Teacher teacher2 = new Teacher("M. Stefanova", "English");

            Course course1=new Course("English language and culture",teacher2,group1);
            Course course2 = new Course("Programing Basics", teacher1, group2);
            Course course3 = new Course("Programing advanced", teacher2, group2);

            Grade grade1 = new Grade(student1, course2, "", 5.50);
            Grade grade2 = new Grade(student2, course2, "", 6.00);


        }
    }
}
