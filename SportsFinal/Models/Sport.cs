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
    public class Sport : ISport
    {
        protected string sportName;
        protected string sportDescription;
        protected int rosterSize;
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
        public Sport()
        {
            this.SportName = "Hockey";
            this.SportDescription = sportDescription;
            this.RosterSize= rosterSize;
        }

        public void ShowSport()
        { this.SportName = sportName; }
    }
}
