using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    public class Lacrosse : Sport
    {
        public List<Team> LacrosseTeams { get; set; }
        public Lacrosse(ITeam team) : base(team)
        {
            this.sportName = "Lacrosse";
            this.sportDescription = " two teams of players use long-handled, racketlike implements (crosses) to catch, carry, or throw a " +
                "ball down the field or into the opponents’ goal. The goal is defined by uprights and a crossbar framing a loose net.";
            this.rosterSize = 25;
           
        }

        public string About()
        {
            return sportDescription;
        }

        public Team AddTeam(List<Team> lacrosseTeams)
        {
            Team newTeam = new Team(new LacrossePlayer());
            lacrosseTeams.Add(newTeam);
            return newTeam;

        }

        public Team RemoveTeam(List<Team> lacrosseTeams)
        {
            Team newTeam = new Team(new LacrossePlayer());
            lacrosseTeams.Remove(newTeam);
            return newTeam;
        }
    }
}
