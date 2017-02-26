using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;
using System.Windows.Controls;

namespace FightClubGame.ViewModels
{


    class MainWindowViewModel : INotifyPropertyChanged
    {
        private RelayCommand exitCommand;

        private UserControl _hostContent;
        public UserControl HostContent
        {
            get { return _hostContent; }
            set
            {
                _hostContent = value;
                OnPropertyChanged("HostContent");
            }
        }
        public ICommand ExitCommand
        {
            get
            {
                return exitCommand ??
                  (exitCommand = new RelayCommand(obj =>
                 {
                     Environment.Exit(1);
                 }));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
