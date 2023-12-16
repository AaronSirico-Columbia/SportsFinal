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
        protected List<ITeam> hockeyTeams;
        public List<ITeam>HockeyTeams { get => hockeyTeams; set => hockeyTeams = value; }
        public BlackHawks hawks = new BlackHawks();

        public Hockey()
        {
            List<ITeam> hockeyTeams = new List<ITeam>();
            this.sportName = "Hockey";
            this.sportDescription = " game between two teams, each usually having six players, who wear skates and compete on an ice rink. " +
                "The object is to propel a vulcanized rubber disk, the puck, past a goal line and into a net guarded by a goaltender, or goalie.";
            this.rosterSize = 23;
            this.HockeyTeams= hockeyTeams;
            hockeyTeams.Add(hawks);
        }

        public string About()
        {
            return sportDescription;
        }

        public Team AddTeam(List<Team>hockeyTeams)
        {
            Team newTeam = new Team(new Sport());
            hockeyTeams.Add(newTeam);
            return newTeam;

        }

        public Team RemoveTeam(List<Team> hockeyTeams)
        {
            Team newTeam = new Team(new Sport());
            hockeyTeams.Remove(newTeam);
            return newTeam;
        }   
    }
}
