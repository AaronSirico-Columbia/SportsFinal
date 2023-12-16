using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    public class HockeyPlayer : Player
    {
        ITeam Team { get; set; }
        public HockeyPlayer(Team team) : base(team)
        { 
            this.Team = team;
            this.player = new HockeyPlayer(team);
            this.Name = name;
            this.Number = number;
        }
    }
}
