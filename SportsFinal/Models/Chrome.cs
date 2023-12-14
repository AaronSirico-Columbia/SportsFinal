using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    public class Chrome : Team
    {
        
    
        public Chrome(LacrossePlayer player) : base(player)
        {
            List<Player> players = new List<Player>();
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
