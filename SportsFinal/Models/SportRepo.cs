using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    public class SportRepo : ISportRepo
    {
        protected List<Sport> sports;
        protected List<Team> teams;
        protected Sport sport;

        public Hockey hockey = new Hockey(new BlackHawks(new HockeyPlayer()));
        public Lacrosse lacrosse = new Lacrosse(new Chrome(new LacrossePlayer()));
        public Sport Sport { get => sport; set => sport = value; }
        public List<Sport> Sports { get; set; }

        public List<Team> Teams { get => teams; set => teams = value; }

        public SportRepo()
        {

        }

        public SportRepo(Sport sport)
        { 
            this.Sport = sport;
            this.Sports = sports;
            this.Teams = teams;
            AddSports(Sports);
        }

        public void printAllSports()
        {
            foreach(Sport s in Sports)
            {
                Console.WriteLine(Sports);
            }
        }

        public void AddSports(List<Sport>_sports)
        {
            if(_sports == null)
            {
                _sports.Add(new Hockey(new Team(new Player())));
                _sports.Add(new Lacrosse(new Team(new Player())));
            }
            else
            {
                _sports.Add(new Sport(new Team(new Player())));
            }
        }

    }
}
