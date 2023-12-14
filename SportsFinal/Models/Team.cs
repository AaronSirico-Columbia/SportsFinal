using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFinal.Models;

namespace SportsFinal.Models
{
    public class Team : ITeam
    {
        
        protected string teamName;
        protected int teamSize;
        protected List<Player> players;
        protected IPlayer player;

        public IPlayer Player { get => player; set => player = value; }

        public string TeamName { get => teamName; set => teamName = value; }
        public int TeamSize { get => teamSize; set => teamSize = value; }
        List<Player> Players { get => players; set => players = value; }

        public Team(IPlayer player)
        {
            this.player = player;
            this.TeamName = teamName;
            this.TeamSize = teamSize;
            this.players = new List<Player>();

        }

        public void AddTeam()
        {

        }

        public void RemoveTeam()
        {

        }


    }

}
