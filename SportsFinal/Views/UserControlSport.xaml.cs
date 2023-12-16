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
using Unity;


namespace SportsFinal.Views
{
    /// <summary>
    /// Interaction logic for UserControlSport.xaml
    /// </summary>
    public partial class UserControlSport : UserControl
    {
        public SportViewModel sv;
        public Sport sport = new Sport();
        public SportRepo repo = new SportRepo(new Sport());
        

        
        public UserControlSport()
        {
            InitializeComponent();
            sv = new SportViewModel(new Sport(), new SportRepo(new Sport()))
            {
                SportName = sport.SportName,
                RosterSize = sport.RosterSize,
                SportDescription = sport.SportDescription
                
            };
            this.DataContext = sv;
        }

        

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string AllSports = "";
            foreach (Sport s in repo.Sports)
            {
                AllSports += s.SportName + "\n";
            }
            SportLabel.Text = AllSports;    
        }

        private void AddSport_Click(object sender, RoutedEventArgs e)
        {
            Sport s = repo.Sports[0];   
            repo.Sports.Add(s);
        }

        private void RemoveSport_Click(object sender, RoutedEventArgs e)
        {
            Sport s = repo.Sports[0];
            repo.Sports.Remove(s);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
