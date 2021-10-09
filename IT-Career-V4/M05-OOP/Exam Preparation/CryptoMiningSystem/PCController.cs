namespace CryptoMiningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PCController
    {
        private readonly ICollection<IUser> users;

        public PCController()
        {
            this.users = new List<IUser>();
        }
        public string RegisterUser(List<string> args)
        {
            string name = args[0];
            decimal money = decimal.Parse(args[1]);
            if (!this.users.Any(x => x.Name == name))
            {
                this.users.Add(new User(name, money));
                return $"Successfully registered user – {name}!";
            }
            else
            {
                return $"Username: {name} already exists!";
            }
        }
        public string CreateComputer(List<string> args)
        {
            string name = args[0];
            string processorType = args[1];
            string processorModel = args[2];
            int processorGeneration = int.Parse(args[3]);
            decimal processorPrice = decimal.Parse(args[4]);
            string videoCardType = args[5];
            string videoCardModel = args[6];
            int videoCardGeneration = int.Parse(args[7]);
            int videoCardRam = int.Parse(args[8]);
            decimal videoCardPrice = decimal.Parse(args[9]);

            IProcessor processor = CreateProcessor(processorType, processorModel, processorGeneration, processorPrice);
            if (processor == null)
            {
                return "Invalid type processor!";
            }
            IVideoCard videoCard = CreateVideoCard(videoCardType, videoCardModel, videoCardGeneration, videoCardRam, videoCardPrice);
            if (videoCard == null)
            {
                return "Invalid type video card!";
            }
            IComputer computer = new Computer(processor, videoCard, videoCardRam);

            IUser user = this.users.FirstOrDefault(x => x.Name == name);
            if (user == null)
            {
                return $"Username: {name} does not exist!";
            }
            user.Computer = computer;
            return $"Successfully created computer for user: {name}!";
        }
        public string Mine()
        {
            double dailyProfits = 0;

            foreach (var user in this.users.Where(x=>x.Computer!=null))
            {
                dailyProfits += user.Computer.MinedAmountPerHour*24;
                user.Computer.Processor.LifeWorkingHours -= 24;
                user.Computer.VideoCard.LifeWorkingHours -= 24;
                user.Money += (decimal)user.Computer.MinedAmountPerHour * 24;
                user.Profits+= (decimal)user.Computer.MinedAmountPerHour * 24;
            }
            return $"Daily profits: {dailyProfits}!";
        }
        public string UserInfo(List<string> args)
        {
            string name = args[0];
            IUser user = this.users.FirstOrDefault(x => x.Name == name);
            if (user!=null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Name: {user.Name} - Stars: {user.Stars}");
                sb.AppendLine($"Balance: {user.Money:f2}");
                if (user.Computer!=null)
                {
                    sb.AppendLine($"PC Ram: {user.Computer.Ram}");
                    sb.AppendLine($"- {user.Computer.Processor.GetType().Name} – {user.Computer.Processor.Model} – {user.Computer.Processor.Generation}");
                    sb.AppendLine($"- {user.Computer.VideoCard.GetType().Name} – {user.Computer.VideoCard.Model} – {user.Computer.VideoCard.Generation}");
                    sb.AppendLine($"* Video card Ram: {user.Computer.VideoCard.Ram}");
                }

                return sb.ToString().TrimEnd();
            }
            return $"Username: {name} does not exist!";
        }
        public string Shutdown()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var user in this.users)
            {
                sb.AppendLine(UserInfo(new List<string>() { user.Name }));
            }
            sb.AppendLine($"System total profits: {this.users.Sum(x=>x.Profits)}!!!");
            return sb.ToString().TrimEnd();
        }

        private IProcessor CreateProcessor(string type, string model, int generation, decimal price)
        {
            if (type == "Low")
            {
                return new LowPerformanceProcessor(model, price, generation);
            }
            else if (type == "High")
            {
                return new HighPerformanceProcessor(model, price, generation);
            }
            else
            {
                return null;
            }
        }
        private IVideoCard CreateVideoCard(string type, string model, int generation, int ram, decimal price)
        {
            if (type == "Game")
            {
                return new GameVideoCard(model, price, generation, ram);
            }
            else if (type == "Mine")
            {
                return new MineVideoCard(model, price, generation, ram);
            }
            else
            {
                return null;
            }
        }
    }
}
