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
        ISport sport;
        Lacrosse lacrosse = new Lacrosse();
        Chrome chrome = new Chrome();
        [TestMethod]
        public void ValueSportLacrosse()
        {
            string defaultLacrosseAbout = lacrosse.About();

            Assert.AreEqual(defaultLacrosseAbout, lacrosse.About());
        }
        [TestMethod]
        public void LacrosseDescription()
        {
            Lacrosse lacrosse = new Lacrosse();
            string SportDescription = lacrosse.SportDescription;

            string SportDescriptionCheck = " two teams of players use long-handled, racketlike implements (crosses) to catch, carry, or throw a " +
                "ball down the field or into the opponents’ goal. The goal is defined by uprights and a crossbar framing a loose net.";

            Assert.AreEqual(SportDescription, SportDescriptionCheck);
        }
        [TestMethod]
        public void LacrosseRosterSize()
        {
            Lacrosse lacrosse = new Lacrosse();
            int SportRosterSize = lacrosse.RosterSize;

            int SportRosterSizeCheck = 25;

            Assert.AreEqual(SportRosterSize, SportRosterSizeCheck);
        }

        [TestMethod]
        public void LacrosseTeamName()
        {
            Chrome chrome = new Chrome();   
            string chromeName = chrome.TeamName;

            string chromeCheck = "Chrome";

            Assert.AreEqual(chromeName, chromeCheck);
        }
        [TestMethod]
        public void LacrosseTeamSize()
        {
            Chrome chrome = new Chrome();
            int chromeNum = chrome.TeamSize;

            int chromeCheck = 25;

            Assert.AreEqual(chromeNum, chromeCheck);
        }

    }
}
