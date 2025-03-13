namespace CreaturesOfTheCode
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository (MythicalCreaturesHub)
            MythicalCreaturesHub creaturesHub = new MythicalCreaturesHub(3);

            //Create some creatures
            Creature orc = new Creature("Gorak", "Orc", 100, "Smash, Roar");
            Creature elf = new Creature("Elora", "Elf", 80, "Heal, Arrow Shot");
            Creature dragon = new Creature("Drakon", "Dragon", 200, "Fire Breath");

            //Add creatures to the hub
            creaturesHub.AddCreature(orc);

            //The first creature is added, 2 more positions available
            creaturesHub.AddCreature(elf);
            creaturesHub.AddCreature(dragon);

            //Attempt to add a creature when capacity is full
            Creature goblin = new Creature("Zug", "Goblin", 50, "Steal, Dodge");
            creaturesHub.AddCreature(goblin); //should not be added
                                              //Attempt to add a creature with a duplicate name
            Creature duplicateOrc = new Creature("Gorak", "Orc", 150, "Berserk");
            creaturesHub.AddCreature(duplicateOrc); //should not be added

            //Removing creatures from the hub
            //Try to remove a not existing creature, should return False
            Console.WriteLine(creaturesHub.RemoveCreature("Zug")); //False
                                                                   //Try to remove an existing creature, should return True
            Console.WriteLine(creaturesHub.RemoveCreature("Drakon")); //True

            //Now it should be possible to add "Zug"
            creaturesHub.AddCreature(goblin);

            // Get the strongest creature
            Console.WriteLine(creaturesHub.GetStrongestCreature());
            //Output:
            //Gorak (Orc) has 100 HP
            //Abilities: Smash, Roar

            //Getting existing creature details
            Console.WriteLine(creaturesHub.Details("Elora"));
            //Output:
            //Elora (Elf) has 80 HP
            //Abilities: Heal, Arrow Shot

            //Getting NOT existing creature details
            Console.WriteLine(creaturesHub.Details("Drakon"));
            //Output:
            //Creature with the name Drakon not found.
            //Get all creatures’ names in alphabetical order
            Console.WriteLine(creaturesHub.GetAllCreatures());
            //Mythical Creatures:
            //Elora -> Elf
            //Gorak -> Ork
            //Zug -> Goblin

        }
    }
}
