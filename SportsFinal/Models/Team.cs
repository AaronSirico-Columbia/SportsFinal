using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFinal.Models;
using System.Security.Cryptography.X509Certificates;

namespace SportsFinal.Models
{
    public class Team : ITeam
    {
        
        protected string teamName;
        protected int teamSize;
        protected List<Player> players;
        protected IPlayer player;

        public ISport Sport { get; set; }
        public IPlayer Player { get => player; set => player = value; }


        public Team(ISport sport)
        {
            this.Sport = sport;  
            this.Player = player;
            this.TeamName = teamName;
            this.TeamSize = teamSize;
            this.players = new List<Player>();

        }

        public string TeamName
        {
            get
            {
                return teamName;
            }
            set
            {

                this.teamName = value;

            }
        }

        public int TeamSize
        {
            get
            {
                return teamSize;
            }
            set
            {

                this.teamSize = value;

            }
        }

        public List<Player> Players
        {
            get
            {
                return players;
            }
            set
            {

                this.players = value;

            }
        }

        List<Player> ITeam.players { get; set; }

        public void AddTeam()
        {

        }

        public void RemoveTeam()
        {

        }


    }

}
