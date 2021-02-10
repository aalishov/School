using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Repositories;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private GunRepository guns;
        private PlayerRepository players;
        private IMap map;

        public Controller()
        {
            guns = new GunRepository();
            players = new PlayerRepository();
            map = new Map();
        }
        public string AddGun(string type, string name, int bulletsCount)
        {
            switch (type)
            {
                case "Pistol":
                    guns.Add(new Pistol(name, bulletsCount));
                    break;
                case "Rifle":
                    guns.Add(new Rifle(name, bulletsCount));
                    break;
                default:
                     throw new ArgumentException(ExceptionMessages.InvalidGunType);
                    break;
            }
            return string.Format(OutputMessages.SuccessfullyAddedGun, name);
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            IGun gun = this.guns.FindByName(gunName);
            if (gun==null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }
            switch (type)
            {
                case "Terrorist":
                    this.players.Add(new Terrorist(username, health, armor, gun));
                    break;
                case "CounterTerrorist":
                    this.players.Add(new CounterTerrorist(username, health, armor, gun));
                    break;
                default:
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
                    break;
            }
            return string.Format(OutputMessages.SuccessfullyAddedPlayer, username);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var player in this.players.Models
                .OrderBy(x=>x.GetType().Name)
                .ThenByDescending(x=>x.Health)
                .ThenBy(x=>x.Username))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string StartGame()
        {
            return this.map.Start(this.players.Models.ToList());
        }
    }
}
