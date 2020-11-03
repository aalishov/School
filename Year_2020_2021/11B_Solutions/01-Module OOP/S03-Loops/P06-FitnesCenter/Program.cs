namespace P06_FitnesCenter
{
    using System;
    class Program
    {
        static void Main()
        {
            int backCounter = 0;
            int chestCounter = 0;
            int legsCounter = 0;
            int absCounter = 0;
            int shakeCounter = 0;
            int barCounter = 0;

            Console.Write("Peoples count: ");
            int peoples = int.Parse(Console.ReadLine());
            for (int i = 0; i < peoples; i++)
            {
                Console.Write("Type: ");
                string type = Console.ReadLine();

                switch (type)
                {
                    case "Back":
                        backCounter++;
                        break;
                    case "Chest":
                        chestCounter++;
                        break;
                    case "Legs":
                        legsCounter++;
                        break;
                    case "Abs":
                        absCounter++;
                        break;
                    case "Protein shake":
                        shakeCounter++;
                        break;
                    case "Protein bar":
                        barCounter++;
                        break;
                    default:
                        break;
                }
            }

            int trainingCounter = backCounter + chestCounter + legsCounter + absCounter;
            int proteinCounter = shakeCounter + barCounter;

            double trainingPercent = trainingCounter/ (double)peoples*100  ;
            double proteintPercent= proteinCounter / (double)peoples*100;

            Console.WriteLine($"{backCounter} - back");
            Console.WriteLine($"{chestCounter} - chest");
            Console.WriteLine($"{legsCounter} - legs");
            Console.WriteLine($"{absCounter} - abs");
            Console.WriteLine($"{shakeCounter} - protein shake");
            Console.WriteLine($"{barCounter} - protein bar");
            Console.WriteLine($"{trainingPercent:f2}% - work out");
            Console.WriteLine($"{proteintPercent:f2}% - protein");
        }
    }
}
