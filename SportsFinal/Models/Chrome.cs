using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    public class Chrome : ITeam
    {
        
        public ISport Sport { get; set; }
        public string TeamName { get; set; }
        public int TeamSize { get; set; }
        public List<Player> players { get; set; }

        public Chrome()
        {
            this.TeamName = "Chrome";
            this.TeamSize = 25;
            List<Player> players = new List<Player>();
             
            
        }

    }
}
