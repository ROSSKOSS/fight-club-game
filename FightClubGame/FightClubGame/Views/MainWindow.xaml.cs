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
using FightClubGame.ViewModels;
namespace FightClubGame.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
        #region Dragging the form
        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        #endregion
        private void PlayButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            host.Children.Add(new Play());
        }

        private void OptionsButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            host.Children.Add(new Options());
        }


    }
}
