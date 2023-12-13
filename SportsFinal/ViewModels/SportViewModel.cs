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

        public ICommand ShowSportCommand {  get; set; }

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

        public SportViewModel(ISport sport)
        {
            this.sport = sport;
            ShowSportCommand = new BasicCommand(OnShowSportCommand, ShowSportCommandCanExecute);
            
        }

        private bool ShowSportCommandCanExecute(object parameter)
        {
            return true;
        }

        private void OnShowSportCommand(object parameter)
        {
            this.sport.ShowSport();
            RaisePropertyChangedEvent("SportName");
        }

         internal void ShowSportName()
        {
            this.sport.ShowSport();
            RaisePropertyChangedEvent("SportName");
        }
    }
}
