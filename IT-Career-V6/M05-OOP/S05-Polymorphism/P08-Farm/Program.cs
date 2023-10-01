namespace P08_Farm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = CreateAnimal(Console.ReadLine().Split(" "));
            Food food = CreateFood(Console.ReadLine().Split(" "));

            Console.WriteLine(animal.MakeSound());
            Console.WriteLine(animal.Eat(food));
            Console.WriteLine(animal);
        }

        public static Food CreateFood(string[] info)
        {
            string type = info[0];
            int quantity = int.Parse(info[1]);

            Food food = null;

            switch (type)
            {
                case "Vegetable":
                    food = new Vegetable() { Quantity=quantity};
                    break;
                case "Meat":
                    food = new Meat() { Quantity = quantity };
                    break;
            }
            return food;
        }

        public static Animal CreateAnimal(string[] info)
        {
            string type = info[0];
            string name = info[1];
            double weight = double.Parse(info[2]);
            string livingRegion = info[3];
            string breed = type == nameof(Cat) ? info[4] : default(string);

            Animal animal = null;

            switch (type)
            {
                case "Cat":
                    animal = new Cat() { AnimalName = name, AnimalWeight = weight, LivingRegion = livingRegion, Breed = breed };
                    break;
                case "Tiger":
                    animal = new Tiger() { AnimalName = name, AnimalWeight = weight, LivingRegion = livingRegion };
                    break;
                case "Zebra":
                    animal = new Zebra() { AnimalName = name, AnimalWeight = weight, LivingRegion = livingRegion };
                    break;
                case "Mouse":
                    animal = new Mouse() { AnimalName = name, AnimalWeight = weight, LivingRegion = livingRegion };
                    break;
            }

            return animal;
        }
    }
}