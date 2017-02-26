using FightClubGame.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace FightClubGame.ViewModels
{
    class OptionsViewModel : INotifyPropertyChanged
    {
        private string _playerName;


        private readonly List<string> _characters = new List<string>();
        private string _character;
        private int _roundDuration;
        private RelayCommand _saveCommand;
        private System.Windows.Visibility _visibility = System.Windows.Visibility.Visible;
        public System.Windows.Visibility Visibility
        {
            get { return _visibility; }
            set
            {
                if (_visibility == value) return;
                _visibility = value;
                OnPropertyChanged("Visibility");
            }
        }
        public List<string> Characters
        {
            get { return _characters; }
        }

        public string Character
        {
            get { return _character; }
            set
            {
                if (_character == value) return;
                _character = value;
                OnPropertyChanged("Character");
            }
        }
        public string PlayerName
        {
            get { return _playerName; }
            set
            {
                _playerName = value;
                OnPropertyChanged("PlayerName");
            }
        }
        public int RoundDuration
        {
            get { return _roundDuration; }
            set
            {
                _roundDuration = value;
                OnPropertyChanged("RoundDuration");
            }
        }
        public OptionsViewModel()
        {
            string dir = System.IO.Path.GetDirectoryName(
      System.Reflection.Assembly.GetExecutingAssembly().Location);

            string file = dir + @"\Settings.txt";
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    PlayerName = sr.ReadLine();
                    Character = sr.ReadLine();
                    RoundDuration = Convert.ToInt32(sr.ReadLine());
                }
            }
            catch
            {
                return;
            }

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetCustomAttributes(typeof(CharacterTypeAttribute), true).Length > 0)
                {
                    Characters.Add(type.Name);
                }
            }
        }
        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                  (_saveCommand = new RelayCommand(obj =>
                  {
                      string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                      string file = dir + @"\Settings.txt";
                      using (StreamWriter sw = new StreamWriter(file))
                      {

                          sw.WriteLine(PlayerName);
                          sw.WriteLine(Character);
                          sw.WriteLine(RoundDuration);
                          Visibility = System.Windows.Visibility.Hidden;
                      }
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
