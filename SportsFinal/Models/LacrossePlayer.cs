using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFinal.SportsLibrary;

namespace SportsFinal.Models
{
    public class LacrossePlayer : Player
    {
        public LacrossePlayer(Team team) : base(team)
        {
            this.player = new LacrossePlayer(team);
            this.Name = name;
            this.Number = number;
        }
    }
}
