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
    /// Логика взаимодействия для GameInterrupt.xaml
    /// </summary>
    public partial class GameInterrupt : Window
    {
        public bool returnToMenu = false;

        public GameInterrupt()
        {
            InitializeComponent();
        }

        private void Yes_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DialogResult = true;
        }

        private void No_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DialogResult = false;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.DialogResult = false;
        }
    }
}
