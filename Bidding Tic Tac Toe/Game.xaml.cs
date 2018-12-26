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
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        GameInterrupt iForm;
        public static bool iForm_init = false;    // tells whether GameInterrupt form initialized


        public Game()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                OpenInterruptForm();
        }

        private void OpenInterruptForm()
        {
            iForm = new GameInterrupt();
            iForm.Show();
            
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (iForm_init)
            {
                System.Media.SystemSounds.Beep.Play();
                iForm.Activate();
                return;
            }

            this.DragMove();
        }
    }
}
