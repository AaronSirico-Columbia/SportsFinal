using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    public class Hockey : Sport
    {
        public List<Team>HockeyTeams { get; set; }  

        public Hockey(ITeam team) :base(team)
        {
            this.sportName = "Hockey";
            this.sportDescription = " game between two teams, each usually having six players, who wear skates and compete on an ice rink. " +
                "The object is to propel a vulcanized rubber disk, the puck, past a goal line and into a net guarded by a goaltender, or goalie.";
            this.rosterSize = 23;
            
        }

        public string About()
        {
            return sportDescription;
        }

        public Team AddTeam(List<Team>hockeyTeams)
        {
            Team newTeam = new Team(new HockeyPlayer());
            hockeyTeams.Add(newTeam);
            return newTeam;

        }

        public Team RemoveTeam(List<Team> hockeyTeams)
        {
            Team newTeam = new Team(new HockeyPlayer());
            hockeyTeams.Remove(newTeam);
            return newTeam;
        }
    }
}
