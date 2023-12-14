using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SportsFinal.SportsLibrary;
using SportsFinal.Models;

namespace SportsFinal.SportsLibrary
{
    public class Sport : SportRepo, ISport
    {
        protected string sportName;
        protected string sportDescription;
        protected int rosterSize;
        protected ITeam team;

        public ITeam Team { get => team; set => team = value; }

        public Sport(ITeam team)
        {
            this.team = team;
            this.SportName = sportName;
            this.SportDescription = sportDescription;
            this.RosterSize = rosterSize;
        }

       

        public string SportName
        {
            get
            {
                return sportName;
            }
            set
            {

                this.sportName = value;

            }
        }
        public string SportDescription {

            get
            {
                return sportDescription;
            }
            set
            {

                this.sportDescription = value;

            }

        }


        public int RosterSize {

            get
            {
                return rosterSize;
            }
            set
            {

                this.rosterSize = value;

            }
        }
        
        public string ShowSports()
        {
            return SportName;
        }
       
    }
}
