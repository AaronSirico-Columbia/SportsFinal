using SportsFinal;
using SportsFinal.Models;
using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Unity;
using Unity.Injection;

namespace OOPFlyingVehicleCore
{
    public class UnityBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ISport, Hockey>();
            container.RegisterType<Sport, Hockey>();
            container.RegisterType<ITeam, BlackHawks>();

            container.RegisterType<ISport, Lacrosse>();
            container.RegisterType<Sport, Lacrosse>();
            container.RegisterType<ITeam, Chrome>();

            container.RegisterType<ITeam, BlackHawks>();
            container.RegisterType<ITeam, BlackHawks>();
            container.RegisterType<IPlayer, HockeyPlayer>();

            container.RegisterType<ITeam, Chrome>();
            container.RegisterType<ITeam, Chrome>();
            container.RegisterType<IPlayer, LacrossePlayer>();
            
            container.RegisterType<Team>(new InjectionConstructor(new Sport()));
            
            

        }
    }
}
