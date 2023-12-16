using SportsFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.SportsLibrary
{
    public interface ITeam
    {
        
        string TeamName { get; set; }
        int TeamSize { get; set; }

        List<Player> players { get; set; }

    }
}
