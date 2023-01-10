using System;

public class Program
{
    public static void Main()
    {
        
    }

    public Animal CreateAnimal(string[] animalInfo,string[] foodInfo)
    {
        string type=animalInfo[0];
        string name = animalInfo[1];
        double weight = double.Parse(animalInfo[2]);

        string foodType = foodInfo[0];
        int foodWeight=int.Parse(foodInfo[1]);


        Animal animal = null;

        switch (type)
        {
            case nameof(Cat):
                string catLivingRegion = animalInfo[3];
                string catBreed = animalInfo[4];
                int catFoodQuantity = 0;
                if (foodType== "Vegetable "||foodType =="Meat")
                {
                    catFoodQuantity = foodWeight;
                }
                else
                {
                    Console.WriteLine($"{nameof(Cat)} does not eat {foodType}!");
                }
                animal = new Cat(name, weight, catFoodQuantity, catLivingRegion, catBreed);
                break;
            case nameof(Tiger):
                string tigerLivingRegion = animalInfo[3];
                string tigerBreed= animalInfo[4];
                int tigerFoodQuantity = 0;
                if (foodType == "Meat")
                {
                    tigerFoodQuantity = foodWeight;
                }
                else
                {
                    Console.WriteLine($"{nameof(Cat)} does not eat {foodType}!");
                }
                animal = new Tiger(name,weight, tigerFoodQuantity, tigerLivingRegion,tigerBreed);
                    break;
            default:
                break;
        }


        return animal;

       //Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}";
       //Birds - "{Type} {Name} {Weight} {WingSize}";
       //Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}";

    }
}

