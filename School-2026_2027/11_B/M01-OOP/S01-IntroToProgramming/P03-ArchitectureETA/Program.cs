using System;
namespace P_ArchitectureETA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int architectureProjectETA = 3;
            int projectAmmount = int.Parse(Console.ReadLine());
            int finalProjectETA = projectAmmount * architectureProjectETA;
            Console.WriteLine($"The architect {architect} will need {finalProjectETA} hours to complete {projectAmmount} project/s.");
        }
    }
}
