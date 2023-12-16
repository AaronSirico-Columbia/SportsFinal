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
    /// Interaction logic for UserControlLacrosse.xaml
    /// </summary>
    public partial class UserControlLacrosse : UserControl
    {
        LacrosseViewModel lv;
        public Lacrosse lacrosse = new Lacrosse();
        public Chrome chrome = new Chrome();
        public UserControlLacrosse()
        {
            InitializeComponent();
            lv = new LacrosseViewModel(new Chrome())
            {
               
            };
            this.DataContext = lv;
        }

        private void ShowTeam_Click(object sender, RoutedEventArgs e)
        {
            string AllTeams = "";
            foreach (ITeam t in lacrosse.LacrosseTeams)
            {
                AllTeams += t.TeamName + "\n";
            }
            TeamLabel.Text = AllTeams;
        }

        private void AddTeam_Click(object sender, RoutedEventArgs e)
        {
            ITeam t = lacrosse.LacrosseTeams[0];
            lacrosse.LacrosseTeams.Add(t);
        }

        private void RemoveTeam_Click(object sender, RoutedEventArgs e)
        {
            ITeam t = lacrosse.LacrosseTeams[0];
            lacrosse.LacrosseTeams.Remove(t);
        }
    }
}
