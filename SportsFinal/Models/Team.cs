using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    internal class Team : ITeam
    {
        ISport sport;

        protected string teamName;
        protected int teamSize;
        protected List<Player> players;

        public string TeamName {

            get
            {
                return this.teamName;
            }
            set
            {
                teamName = value;
            }
        }

        public int TeamSize {

            get
            {
                return this.teamSize;
            }
            set
            {
                teamSize = value;
            }
        }
        List<Player> Players {

            get
            {
                return this.players;
            }
            set
            {
                players = value;
            }
        }

        public Team()
        {
            this.TeamName = teamName;
            this.TeamSize = teamSize;
            this.Players = players;
            
        }
    }

}
