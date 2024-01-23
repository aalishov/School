using System.Security.Cryptography.X509Certificates;

namespace P03_ClothingMagazine
{
    public class Program
    {
        public static void Main()
        {

            Magazine magazine = new Magazine("Zara", 20);
            //Initialize entity (Cloth)
            Cloth cloth1 = new Cloth("red", 36, "dress");
            Console.WriteLine(cloth1);
            //Product: dress with size 36, color red 
            //Add Cloth
            magazine.AddCloth(cloth1);
            //Remove Cloth
            Console.WriteLine(magazine.RemoveCloth("black"));
            //false
            Cloth cloth2 = new Cloth("brown", 34, "t-shirt");
            Cloth cloth21 = new Cloth("red", 38, "dress");
            Cloth cloth3 = new Cloth("blue", 32, "jeans");

            //Add Cloth
            magazine.AddCloth(cloth2);
            magazine.AddCloth(cloth21);
            magazine.AddCloth(cloth3);
            ////Get smallest cloth
            // Cloth smallestCloth = magazine.GetSmallestCloth();
            // Console.WriteLine(smallestCloth);
            ////Product: jeans with size 32, color blue
            ////Get Cloth
            // Cloth getCloth = magazine.GetCloth("brown");
            ////Product: t-shirt with size 34, color brown
            // Console.WriteLine(getCloth);
            Console.WriteLine(magazine.Report());
            Console.WriteLine(magazine.RemoveCloth("red"));
            Console.WriteLine(magazine.RemoveCloth("red"));
            Console.WriteLine(magazine.RemoveCloth("red"));
            Console.WriteLine(magazine.RemoveCloth("red"));
            Console.WriteLine(magazine.Report());
        }
    }
}