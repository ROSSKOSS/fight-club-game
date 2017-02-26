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
namespace FightClubGame.Views
{
    /// <summary>
    /// Interaction logic for Play.xaml
    /// </summary>
    public partial class Play : UserControl
    {
        List<IFighter> chars = new List<IFighter>();
        public Play()
        {
            InitializeComponent();
            chars.Add(new Centaur());
            chars.Add(new Human());
            chars.Add(new Ogre());
            chars.Add(new Orc());
            chars.Add(new Siren());
            chars.Add(new Vampire());
            BeginFight();
        }
        IActor opponent = new Computer();

        BrushConverter _bc = new BrushConverter();

        private void BeginFight()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            List<Type> charactersList = new List<Type>();

            int selectedOpponentNumber = random.Next(0, chars.Count);
            opponent.Character = chars[selectedOpponentNumber];

            //System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(selectedOpponentName);

            SetButtons(true);
        }
        private void SetButtons(bool attack)
        {
            int i = 1;
            foreach (var bodypart in opponent.Character.bodyparts)
            {
                var kek = new CustomButton.Button();
                kek.Name = "Button" + i.ToString();
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
        }
        public void PartHandler(object sender, MouseEventArgs e)
        {

        }


    }
}
