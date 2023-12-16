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
        protected List<ITeam> lacrosseTeams;
        public List<ITeam>LacrosseTeams { get => lacrosseTeams; set => lacrosseTeams = value; }
        public Chrome chrome = new Chrome();
        public Lacrosse()
        {
            List<ITeam> lacrosseTeams = new List<ITeam>();
            this.sportName = "Lacrosse";
            this.sportDescription = " two teams of players use long-handled, racketlike implements (crosses) to catch, carry, or throw a " +
                "ball down the field or into the opponents’ goal. The goal is defined by uprights and a crossbar framing a loose net.";
            this.rosterSize = 25;
            this.LacrosseTeams = lacrosseTeams;
            lacrosseTeams.Add(chrome);
        }

        public string About()
        {
            return sportDescription;
        }

        public Team AddTeam(List<Team> lacrosseTeams)
        {
            Team newTeam = new Team(new Sport());
            lacrosseTeams.Add(newTeam);
            return newTeam;

        }

        public Team RemoveTeam(List<Team> lacrosseTeams)
        {
            Team newTeam = new Team(new Sport());
            lacrosseTeams.Remove(newTeam);
            return newTeam;
        }
    }
}
