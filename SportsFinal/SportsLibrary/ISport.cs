﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsFinal.SportsLibrary
{
    public interface ISport
    {
        string SportName { get; set; }
        string SportDescription { get; set; }

        int TeamSize { get; set; }

        string ShowSport();


        
    }

   
}
