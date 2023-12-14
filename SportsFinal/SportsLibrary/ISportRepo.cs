using SportsFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.SportsLibrary
{
    public interface ISportRepo
    {
       List<Sport> Sports { get;  set; }

        void printAllSports();

        void AddSports(List<Sport>_sports);
    } 
        
}
