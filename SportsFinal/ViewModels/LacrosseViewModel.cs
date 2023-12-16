using SportsFinal.Models;
using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SportsFinal.ViewModels
{
    public class LacrosseViewModel : BaseViewModel
    {

        public Lacrosse lacrosse { get; set; }
        public ITeam team { get; set; }

        public LacrosseViewModel(ITeam team)
        {
            this.team = new Chrome();
            this.TeamName = "Blank Team";
            this.TeamSize = 23;
            this.Players= new List<Player>();
        }

        public string TeamName
        {
            get
            {
                return team.TeamName;
            }
            set
            {
                team.TeamName = value;
                RaisePropertyChangedEvent();
            }
        }

        public int TeamSize
        {
            get
            {
                return team.TeamSize;
            }
            set
            {
                team.TeamSize = value;
                RaisePropertyChangedEvent();
            }
        }

        public List<Player>Players
        {
            get
            {
                return team.players;
            }
            set
            {
                team.players = value;
                RaisePropertyChangedEvent();
            }
        }


    }
}
