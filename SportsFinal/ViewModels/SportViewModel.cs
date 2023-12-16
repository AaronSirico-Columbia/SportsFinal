using SportsFinal.Models;
using SportsFinal.SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SportsFinal.ViewModels
{
    public class SportViewModel : BaseViewModel
    {
        

        public ISport sport { get; set; }

        public ISportRepo repo { get; set; } 

        public ICommand ShowSportCommand {  get; set; }

     

        

        public SportViewModel(ISport sport, ISportRepo repo)
        {
            this.repo = repo;
            this.sport = sport;
            ShowSportCommand = new BasicCommand(OnShowSportCommand, ShowSportCommandCanExecute);
            

        }

        public string SportName
        {
            get
            {
                return sport.SportName;
            }
            set
            {
                sport.SportName = value;
                RaisePropertyChangedEvent();
            }
        }

        public string SportDescription
        {
            get
            {
                return sport.SportDescription;
            }
            set
            {
                sport.SportDescription = value;
                RaisePropertyChangedEvent();
            }
        }

        public int RosterSize
        {
            get
            {
                return sport.RosterSize;
            }
            set
            {
                sport.RosterSize = value;
                RaisePropertyChangedEvent();
            }
        }


        private bool ShowSportCommandCanExecute(object parameter)
        {
            return true;
        }

        private void OnShowSportCommand(object parameter)
        {
            this.sport.ShowSports();
            RaisePropertyChangedEvent("SportName");
        }

         internal void ShowSports()
        {
            this.sport.ShowSports();
            RaisePropertyChangedEvent("SportName");
        }

    }
}
