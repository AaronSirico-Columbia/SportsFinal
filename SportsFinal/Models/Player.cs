using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    internal class Player : IPlayer
    {
        string Name;
        int Number;

        public Player(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
    }
}
