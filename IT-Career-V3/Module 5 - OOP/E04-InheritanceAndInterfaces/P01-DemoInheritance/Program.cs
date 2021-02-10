namespace P01_DemoInheritance
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Student student = new Student("Pesho")
            {
                Age = 12,
                School = "Vasil Levski",
                Address = "Velingrad"
            };

            Employee employee = new Employee("Gosho", 1560m)
            {
                Age = 42,
                Address = "Velingrad",
                Company = "UniCredit"
            };

            Person person = new Employee("Ivan", 1560m);
            Student pEmployee = (Student)person;

            School school = new School();
            school.people.Add(student);
            school.people.Add(employee);

        }
    }
}
