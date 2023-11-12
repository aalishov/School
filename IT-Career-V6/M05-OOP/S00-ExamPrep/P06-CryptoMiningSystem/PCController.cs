using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P06_CryptoMiningSystem
{
    public class PCController
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private static double totalProfits = 0;

        public string RegisterUser(List<string> args)
        {
            string name = args[0];
            double money = double.Parse(args[1]);

            if (!users.ContainsKey(name))
            {
                users.Add(name, new User(name, money));
                return $"Successfully registered user – {name}!";
            }

            return $"Username: {name} already exists!";
        }

        public string CreateComputer(List<string> args)
        {
            //{userName} {processorType} {processorModel} {processorGeneration} {processorPrice} {videoCardType} {videoCardModel} {videoCardGerenation} {videoCardRam} {videoCardPrice}
            string userName = args[0];
            string processorType = args[1];
            string processorModel = args[2];
            int processorGeneration = int.Parse(args[3]);
            double processorPrice = double.Parse(args[4]);
            string videoCardType = args[5];
            string videoCardModel = args[6];
            int videoCardGerenation = int.Parse(args[7]);
            int videoCardRam = int.Parse(args[8]);
            double videoCardPrice = double.Parse(args[9]);
            int computerRam = int.Parse(args[10]);

            if (!users.ContainsKey(userName))
            {
                return $"Username: {userName} does not exist!";
            }

            Processor processor = null;

            if (processorType == "Low")
            {
                processor = new LowPerformanceProcessor(processorModel, processorPrice, processorGeneration);
            }
            else if (processorType == "High")
            {
                processor = new HighPerformanceProcessor(processorModel, processorPrice, processorGeneration);
            }
            else
            {
                return $"Invalid type processor!";
            }

            VideoCard videoCard = null;


            if (videoCardType == "Game")
            {
                videoCard = new GameVideoCard(videoCardModel, videoCardPrice, videoCardGerenation, videoCardRam);
            }
            else if (videoCardType == "Game")
            {
                videoCard = new MineVideoCard(videoCardModel, videoCardPrice, videoCardGerenation, videoCardRam);
            }
            else
            {
                return "Invalid type video card!";
            }

            double computerPrice = videoCardPrice + processorPrice;

            if (users[userName].Money < (computerPrice))
            {
                return $"User: {userName} - insufficient funds!";
            }

            Computer computer = new Computer(processor, videoCard, computerRam);
            users[userName].Computer = computer;
            users[userName].Money -= computerPrice;

            return $"Successfully created computer for user: {userName}!";
        }

        public string Mine()
        {
            double dailyProfits = 0;
            foreach (var user in users)
            {
                if (user.Value.Computer != null)
                {
                    double userAmount = user.Value.Computer.MinedAmountPerHour;
                    dailyProfits += userAmount;
                    user.Value.Money += userAmount;
                    user.Value.Computer.Processor.LifeWorkingHours--;
                    user.Value.Computer.VideoCard.LifeWorkingHours--;
                }
            }
            totalProfits += dailyProfits;
            return $"Daily profits: {dailyProfits}!";
        }

        public string UserInfo(List<string> args)
        {
            throw new NotImplementedException();
        }

        public string Shutdown()
        {
            throw new NotImplementedException();
        }

    }
}
