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

    public partial class SetPlayerName : Window
    {
        public bool turn = false;
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public SetPlayerName()
        {
            InitializeComponent();
            textBox.Focus();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.Key != Key.Enter)
                SetName(textBox.Text);
        }

        private void enter_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DialogResult = true;
        }
        
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.DialogResult = false;
            else if (e.Key == Key.Enter)
                this.DialogResult = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBlock_name.Text = $"Player{(Player.player_number.ToString())} please enter your name.";
            textBox.Text = null;
        }
    }
}





