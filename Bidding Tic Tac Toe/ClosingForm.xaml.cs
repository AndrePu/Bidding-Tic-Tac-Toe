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
    /// Message Box that warns about closing app.
    /// </summary>
    public partial class ClosingForm : Window
    {
        //public I
        public ClosingForm()
        {
            InitializeComponent();
            MainMenu.close_init = true;
        }
        
        private void No_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ReturnToMainMenu();
        }

        private void Yes_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CloseApp();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                ReturnToMainMenu();
            else if (e.Key == Key.Enter)
                CloseApp();
        }

        private void CloseApp()
        {
            App.Current.Shutdown();
        }

        private void ReturnToMainMenu()
        {
            this.Close();
            MainMenu.close_init = false;
        }
    }
}
