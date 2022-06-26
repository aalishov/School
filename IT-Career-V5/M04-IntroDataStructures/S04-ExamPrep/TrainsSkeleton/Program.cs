namespace TrainsSkeleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        private static Deque<Train> trains = new Deque<Train>();
        //TODO: add history functionality
        private static Stack<Train> history = new Stack<Train>();
        private static void Add(int number, string name, string type, int cars)
        {
            if (type == "F")
            {
                //Add freight trains to back
                trains.AddBack(new Train(number, name, type, cars));
            }
            else
            {
                trains.AddFront(new Train(number, name, type, cars));
            }
        }
        private static void Travel()
        {
            if (trains.Count > 0)
            {

                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                Train travel = null;
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15)
                {
                    travel = trains.RemoveBack();
                }
                else if (frontTrain != null && frontTrain.Type == "P")
                {
                    travel = trains.RemoveFront();
                }
                else if (backTrain != null && backTrain.Type == "F")
                {
                    travel = trains.RemoveBack();
                }
                if (travel != null)
                {
                    Console.WriteLine(travel);
                    history.Push(travel);
                }
            }
        }
        private static void Next()
        {
            if (trains.Count > 0)
            {

                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15)
                {
                    Console.WriteLine(backTrain);
                }
                else if (frontTrain != null && frontTrain.Type == "P")
                {
                    Console.WriteLine(frontTrain);
                }
                else if (backTrain != null && backTrain.Type == "F")
                {
                    Console.WriteLine(backTrain);
                }
            }
        }

        private static void History()
        {
            Console.WriteLine(String.Join($"{Environment.NewLine}",history));
        }

        static void Main(string[] args)
        {

            string[] command;
            do
            {
                command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "Add":
                        Add(int.Parse(command[1]), command[2], command[3], int.Parse(command[4]));
                        break;
                    case "Travel":
                        Travel();
                        break;
                    case "Next":
                        Next();
                        break;
                    case "History":
                        History();
                        break;
                }
            } while (command[0] != "End");

        }
    }
}
