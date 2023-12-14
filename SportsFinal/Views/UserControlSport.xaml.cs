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
        public Sport sport = new Sport(new Team(new Player()));

        
        public UserControlSport()
        {
            InitializeComponent();
            sv = new SportViewModel(new Sport(new Team(new Player())), new SportRepo())
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

      
    }
}
