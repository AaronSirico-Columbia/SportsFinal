using SportsFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.SportsLibrary
{
    internal class ITeam : ISport
    {
        string TeamName { get; set; }
        int TeamSize { get; set; }
        List<Player> Players { get; set; }
    }
}
