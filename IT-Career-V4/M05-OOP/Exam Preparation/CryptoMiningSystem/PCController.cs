namespace CryptoMiningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
            if (!this.users.Any(x=>x.Name==name))
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
            if (processor==null)
            {
                return "Invalid type processor!";
            }
            IVideoCard videoCard = CreateVideoCard(videoCardType, videoCardModel, videoCardGeneration, videoCardRam, videoCardPrice);
            if (videoCard==null)
            {
                return "Invalid type video card!";
            }
            IComputer computer = new Computer(processor, videoCard, videoCardRam);

            IUser user = this.users.FirstOrDefault(x => x.Name == name);
            if (user==null)
            {
                return $"Username: {name} does not exist!";
            }
            user.Computer = computer;
            return $"Successfully created computer for user: {name}!";
        }
        public string Mine()
        {
            //TODO: Add some logic here …
        }
        public string UserInfo(List<string> args)
        {
            //TODO: Add some logic here …
        }
        public string Shutdown()
        {
            //TODO: Add some logic here …
        }

        private IProcessor CreateProcessor(string type, string model,  int generation, decimal price)
        {
            if (type=="Low")
            {
                return new LowPerformanceProcessor(model, price, generation);
            }
            else if(type=="High")
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
            if (type=="Game")
            {
                return new GameVideoCard(model, price, generation);
            }
            else if (type=="Mine")
            {
                return new MineVideoCard(model, price, generation);
            }
            else
            {
               return null;
            }
        }
    }
}
