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
    /// Логика взаимодействия для CongratulationWindow.xaml
    /// </summary>
    public partial class CongratulationWindow : Window
    {

        public CongratulationWindow(string name)
        {
            InitializeComponent();
            congratulation_textBlock.Text = $"Congratulation, {name}!!! You've won the match!!";
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.DialogResult = false;
            else if (e.Key == Key.Enter)
                this.DialogResult = true;
        }

        private void okay_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
