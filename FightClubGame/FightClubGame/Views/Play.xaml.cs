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
using System.Diagnostics;
using System.Reflection;
using FightClubGame.Core;
using FightClubGame.Fighters;
using System.Threading;
using System.IO;

namespace FightClubGame.Views
{
    /// <summary>
    /// Interaction logic for Play.xaml
    /// </summary>
    public partial class Play : UserControl
    {
        List<Type> chars = new List<Type>();
        List<IFighter> charsInstances = new List<IFighter>();
       
        string _playerName;
        string _playersCharacterName;
        IFighter _playersCharacter;
        Player player;
        int _roundDuration;
        int counter;
        Timer t;
        public Play()
        {
            InitializeComponent();
            BeginFight();
        }
        IActor opponent = new Computer();

        BrushConverter _bc = new BrushConverter();

        private void BeginFight()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int selectedOpponentNumber = random.Next(0, chars.Count);
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file = dir + @"\Settings.txt";
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    _playerName = sr.ReadLine();
                    _playersCharacterName = sr.ReadLine();
                    _roundDuration = Convert.ToInt32(sr.ReadLine());
                }
            }
            catch
            {
                return;
            }
            #region Creating an instance of players character
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetCustomAttributes(typeof(CharacterTypeAttribute), true).Length > 0)
                {
                    if (type.Name == _playersCharacterName)
                    {
                        _playersCharacter = (IFighter)Activator.CreateInstance(type);
                    }
                }
            }
            #endregion
            #region Parsing IFighters into the List
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetCustomAttributes(typeof(CharacterTypeAttribute), true).Length > 0)
                {
                    chars.Add(type);
                }
            }
            #endregion
            foreach (var type in chars)
            {
                charsInstances.Add((IFighter)Activator.CreateInstance(type));
            }
            opponent.Character = charsInstances[selectedOpponentNumber];
            SetButtons(true);
            counter = _roundDuration;
            Time.Content = _roundDuration;
            PlayerName.Content = $"{_playerName} ({_playersCharacterName})";
            OpponentName.Content = $"Opponent ({opponent.Character.Name})";
            player = new Player();
            player.Name = _playerName;
            player.Character = _playersCharacter;
            player.opponent = opponent;
            t = new Timer(new TimerCallback(Tick));
            t.Change(1000, 1000);
        }
        private void Tick(object state)
        {
            if (counter >= 0)
            {
                counter--;
                this.Dispatcher.BeginInvoke(new Action(() => Time.Content = counter));
            }
            else
            {
                t.Change(Timeout.Infinite, Timeout.Infinite);
                MessageBox.Show("GG!");
            }
           
        }
        private void SetButtons(bool attack)
        {
            int i = 1;
            #region Creating array of buttons
            foreach (var bodypart in opponent.Character.bodyparts)
            {
                var kek = new CustomButton.Button();
                kek.Name = bodypart.Value.Replace(" ", String.Empty);
                kek.Text = bodypart.Value;
                kek.FillColor = (Brush)_bc.ConvertFromString("#FF40382C");
                kek.Foreground = (Brush)_bc.ConvertFromString("#FF40382C");
                kek.ForegroundColor = (Brush)_bc.ConvertFromString("#FFCDCDCD");
                kek.HoverColor = (Brush)_bc.ConvertFromString("#FF7C8100");
                kek.SecondColor = (Brush)_bc.ConvertFromString("#FFACACAC");
                kek.StrokeColor = (Brush)_bc.ConvertFromString("#FF000000");
                kek.Width = 400;
                kek.RoundX = 5;
                kek.RoundY = 5;
                kek.HorizontalAlignment = HorizontalAlignment.Center;
                kek.MouseLeftButtonUp += PartHandler;
                radioButtonHost.Children.Add(kek);
                i++;
            }
            #endregion
        }
        public void PartHandler(object sender, MouseEventArgs e)
        {
           MessageBox.Show(((CustomButton.Button)sender).Text);
           player.hitActor(opponent.Character.bodyparts.FirstOrDefault(x => x.Value == $"{((CustomButton.Button)sender).Text}").Key);
            MessageBox.Show(opponent.Character.Health + ";" + player.Character.Health);
        }
       

    }
}
