using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.Models
{
    internal class Player : IPlayer
    {
        protected string name;
        protected int number;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }
        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                number = value;
            }
        }


        public Player()
        {
            this.Name = name;
            this.Number = number;
        }
    }
}
