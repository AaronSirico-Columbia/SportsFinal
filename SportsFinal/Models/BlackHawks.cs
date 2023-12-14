using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    public class BlackHawks : Team
    {
        List<Player> Players = new List<Player>();

        public BlackHawks(HockeyPlayer player) :base(player) 
        { 
            this.players = Players;
        }

        public void AddPlayer()
        {
            players.Add(players[0]);
        }

        public void RemovePlayer()
        {
            players.Remove(players[0]);
        }
    }
}
