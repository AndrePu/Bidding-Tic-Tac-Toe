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
using System.Windows.Shapes;

namespace Bidding_Tic_Tac_Toe
{

    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void newGame_Button_Click(object sender, RoutedEventArgs e)
        {
            NewGame_Menu newGameForm = new NewGame_Menu();
            newGameForm.Show();
            this.Close();            
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void exit_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenClosingWindow();
        }
        
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                OpenClosingWindow();
        }

        private void OpenClosingWindow()
        {
            ClosingWindow cw = new ClosingWindow();

            if (cw.ShowDialog() == true)
                App.Current.Shutdown();
        }
    }
}
