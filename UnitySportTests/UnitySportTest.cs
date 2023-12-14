using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using SportsFinal;
using OOPFlyingVehicleCore;
using SportsFinal.SportsLibrary;
using SportsFinal.Models;

namespace UnitySportTests
{
    [TestClass]
    public class InjectTests
    {
        IUnityContainer unityContainer;
        public InjectTests()
        {
            unityContainer = new UnityContainer();
            UnityBootstrap.RegisterTypes(unityContainer);
        }

        [TestMethod]
        public void UnitySportHockey()
        {
            ISport sport;

            sport = unityContainer.Resolve<Hockey>();

            Assert.IsInstanceOfType(sport.Team, typeof(Team));
        }

        [TestMethod]
        public void UnitySportLacrosse()
        {
            ISport sport;

            sport = unityContainer.Resolve<Lacrosse>();

            Assert.IsInstanceOfType(sport.Team, typeof(Team));
        }

        [TestMethod]
        public void UnitySportBlackHawks()
        {
            ITeam team;

            team = unityContainer.Resolve<BlackHawks>();

            Assert.IsInstanceOfType(team, typeof(Team));
        }

        [TestMethod]
        public void UnitySportChrome()
        {
            ITeam team;

            team = unityContainer.Resolve<Chrome>();

            Assert.IsInstanceOfType(team, typeof(Team));
        }

       


    }
}