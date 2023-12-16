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
        protected Sport sport;
        
        Hockey hockey = new Hockey();
        Lacrosse lacrosse = new Lacrosse();
        public Sport Sport { get => sport; set => sport = value; }
        public List<Sport> Sports { get => sports; set => sports = value; }

        public SportRepo(Sport sport)
        {
            List<Sport> sports = new List<Sport>();
            this.Sport = hockey;
            this.Sports = sports;
            sports.Add(hockey);
            sports.Add(lacrosse);
        }

        public void printAllSports()
        {
            foreach(Sport s in Sports)
            {
                Console.WriteLine(Sports);
            }
        }


    }
}
