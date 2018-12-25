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
    /// <summary>
    /// Логика взаимодействия для NewGame_Menu.xaml
    /// </summary>
    public partial class NewGame_Menu : Window
    {
        public NewGame_Menu()
        {
            InitializeComponent();
            this.Activate();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            ReturnToMainMenu();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                ReturnToMainMenu();
        }
        private void ReturnToMainMenu()
        {
            MainMenu mainForm = new MainMenu();
            mainForm.Show();
            this.Close();
        }
    }
}
