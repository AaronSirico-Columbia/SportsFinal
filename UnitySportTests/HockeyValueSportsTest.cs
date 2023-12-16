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
        Hockey hockey = new Hockey();
        BlackHawks hawks = new BlackHawks();
        [TestMethod]
        public void ValueSportHockey()
        {
            string defaultHockeyAbout = hockey.About();

            Assert.AreEqual(defaultHockeyAbout, hockey.About());
        }

        [TestMethod]
        public void HockeyDescription()
        {
            Hockey hockey = new Hockey();
            string SportDescription = hockey.SportDescription;

            string SportDescriptionCheck = " game between two teams, each usually having six players, who wear skates and compete on an ice rink. " +
                "The object is to propel a vulcanized rubber disk, the puck, past a goal line and into a net guarded by a goaltender, or goalie.";

            Assert.AreEqual(SportDescription, SportDescriptionCheck);
        }
        [TestMethod]
        public void HockeyRosterSize()
        {
            Hockey hockey = new Hockey();
            int SportRosterSize = hockey.RosterSize;

            int SportRosterSizeCheck = 23;

            Assert.AreEqual(SportRosterSize, SportRosterSizeCheck);
        }

        [TestMethod]
        public void HockeyTeamName()
        {
            BlackHawks hawks = new BlackHawks();
            string hawksName = hawks.TeamName;

            string hawksCheck = "BlackHawks";

            Assert.AreEqual(hawksName, hawksCheck);
        }
        [TestMethod]
        public void HockeyTeamSize()
        {
            BlackHawks hawks = new BlackHawks();
            int hawksNum = hawks.TeamSize;

            int hawksCheck = 23;

            Assert.AreEqual(hawksNum, hawksCheck);
        }

    }
}
