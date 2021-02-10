namespace CounterStrike.Repositories
{
    using CounterStrike.Models.Players.Contracts;
    using CounterStrike.Repositories.Contracts;
    using CounterStrike.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PlayerRepository : IRepository<IPlayer>
    {
        private readonly List<IPlayer> players;
        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }
        public IReadOnlyCollection<IPlayer> Models => this.players;

        public List<IPlayer> GamePlayers
        {
            get => this.players;
        }
        public void Add(IPlayer model)
        {
            if (model==null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }
            this.players.Add(model);
        }

        public IPlayer FindByName(string name)
        {
            return players.FirstOrDefault(x => x.Username == name);
        }

        public bool Remove(IPlayer model)
        {
            return this.players.Remove(model);
        }
    }
}
