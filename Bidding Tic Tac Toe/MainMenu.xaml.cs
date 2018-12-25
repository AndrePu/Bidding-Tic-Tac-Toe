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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        ClosingForm closingForm;
        static public bool close_init = false;     // if we initialized unclosed window for this form

        public MainMenu()
        {
            InitializeComponent();
            this.Activate();
        }

        private void newGame_Button_Click(object sender, RoutedEventArgs e)
        {
            if (close_init)
            {
                System.Media.SystemSounds.Beep.Play();
                closingForm.Activate();
                return;
            }

            NewGame_Menu newGameForm = new NewGame_Menu();
            newGameForm.Show();
            this.Close();
            
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (close_init)
            {
                System.Media.SystemSounds.Beep.Play();
                closingForm.Activate();
                return;
            }

            this.DragMove();
        }

        private void exit_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenClosingForm();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (close_init)
            {
                System.Media.SystemSounds.Exclamation.Play();
                closingForm.Activate();
                return;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                OpenClosingForm();
        }

        private void OpenClosingForm()
        {
            closingForm = new ClosingForm();
            closingForm.Show();
        }
    }
}
