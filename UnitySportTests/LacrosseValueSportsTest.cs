using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsFinal;
using OOPFlyingVehicleCore;
using SportsFinal.SportsLibrary;
using SportsFinal.Models;
using Unity;

namespace ValueSportTests
{
    [TestClass]
    public class LacrosseValueTests
    {
        Lacrosse lacrosse = new Lacrosse(new Chrome(new LacrossePlayer()));
        Chrome chrome = new Chrome(new LacrossePlayer());
        [TestMethod]
        public void ValueSportLacrosse()
        {
            string defaultLacrosseAbout = lacrosse.About();

            Assert.AreEqual(defaultLacrosseAbout, lacrosse.About());
        }

        public void LacrosseAddTeamPlayer()
        {
            Team LacrosseAddTeam = lacrosse.AddTeam(lacrosse.LacrosseTeams);

            Assert.AreEqual(LacrosseAddTeam, lacrosse.AddTeam(lacrosse.LacrosseTeams));
        }

    }
}
