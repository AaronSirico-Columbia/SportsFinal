using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    public class BlackHawks : ITeam
    {
        public ISport Sport { get; set; }

        public string TeamName { get; set; }
        public int TeamSize { get; set; }
        public List<Player> players { get; set; }

        public BlackHawks()
        {
            this.TeamName = "BlackHawks";
            this.TeamSize = 23;
            List<Player> players = new List<Player>();

        }

    }
}
