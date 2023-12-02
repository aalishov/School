namespace P09_Players_and_Monsters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string username = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());
            Hero hero = null;
            switch (type)
            {
                case nameof(Hero):
                    hero = new Hero(username, level);
                    break;
                case nameof(Elf):
                    hero = new Elf(username, level);
                    break;
                case nameof(MuseElf):
                    hero = new MuseElf(username, level);
                    break;
                case nameof(Wizard):
                    hero = new Wizard(username, level);
                    break;
                case nameof(DarkWizard):
                    hero = new DarkWizard(username, level);
                    break;
                case nameof(SoulMaster):
                    hero = new SoulMaster(username, level);
                    break;
                case nameof(Knight):
                    hero = new Knight(username, level);
                    break;
                case nameof(DarkKnight):
                    hero = new DarkKnight(username, level);
                    break;
                case nameof(BladeKnight):
                    hero = new BladeKnight(username, level);
                    break;
                default:
                    break;
            }
            Console.WriteLine(hero);
        }
    }
}