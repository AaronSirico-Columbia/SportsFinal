using SportsFinal.Models;
using SportsFinal.SportsLibrary;
using SportsFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportsFinal.Views
{
    /// <summary>
    /// Interaction logic for UserControlHockey.xaml
    /// </summary>
    public partial class UserControlHockey : UserControl
    {
        HockeyViewModel hv;
        public Hockey hockey = new Hockey();
        public BlackHawks hawks = new BlackHawks();
        public UserControlHockey()
        {
            InitializeComponent();
            hv = new HockeyViewModel(new BlackHawks())
            {

            };
            this.DataContext = hv;
        }

        private void ShowTeam_Click(object sender, RoutedEventArgs e)
        {
            string AllTeams = "";
            foreach (ITeam t in hockey.HockeyTeams)
            {
                AllTeams += t.TeamName + "\n";
            }
            TeamLabel.Text = AllTeams;
        }

        private void AddTeam_Click(object sender, RoutedEventArgs e)
        {
            ITeam t = hockey.HockeyTeams[0];
            hockey.HockeyTeams.Add(t);
        }

        private void RemoveTeam_Click(object sender, RoutedEventArgs e)
        {
            ITeam t = hockey.HockeyTeams[0];
            hockey.HockeyTeams.Remove(t);
        }
    }
}
