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
    public class ValueTests
    {
        Hockey hockey = new Hockey(new BlackHawks(new HockeyPlayer()));
        BlackHawks hawks = new BlackHawks(new HockeyPlayer());
        [TestMethod]
        public void ValueSportHockey()
        {
            string defaultHockeyAbout = hockey.About();

            Assert.AreEqual(defaultHockeyAbout, hockey.About());
        }

        public void HockeyAddTeamPlayer()
        {
            Team HockeyAddTeam = hockey.AddTeam(hockey.HockeyTeams);

            Assert.AreEqual(HockeyAddTeam, hockey.AddTeam(hockey.HockeyTeams));
        }

    }
}
