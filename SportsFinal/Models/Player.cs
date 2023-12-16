using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    public class Player : IPlayer
    {
        protected string name;
        protected int number;
        public string Name;
        public int Number;
        protected IPlayer player;
        public IPlayer PlayerType { get; set; }

        int IPlayer.number { get; set; }

        string IPerson.name { get; set; }


        public Player(ITeam team )
        {
            this.Name = "player name";
            this.Number = 00;
        }


      
    }
}
