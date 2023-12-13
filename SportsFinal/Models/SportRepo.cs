using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    internal class SportRepo : ISportRepo
    {
        protected List<Sport> sports;
        public List<Sport> Sports
        {
            get
            {
                return this.sports;
            }
            set
            {
                sports = value;
            }
        }


        public SportRepo() 
        { 
            this.Sports = sports;
            
        }

        public void PrintAllSports()
        {
            foreach(Sport s in Sports)
            {
                Console.WriteLine(Sports);
            }
        }
    }
}
