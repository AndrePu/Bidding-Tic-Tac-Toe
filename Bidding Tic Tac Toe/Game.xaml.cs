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

    public partial class Game : Window
    {
        private bool game_with_Bot = false;
        private char move_symbol = 'X';
        private GameProcess game_process = GameProcess.Bidding;

        private int field_size = 3;
        private bool[,] fieldCell_filled;   // indicates whether cell of field is already filled

        private char[,] field;

        IPlayer player1;
        IPlayer player2;   // we don't know yet if it's Bot player or not


        private bool bid_waiting_process = false;
        
        public Game(bool game_with_Bot)
        {
            InitializeComponent();
            this.game_with_Bot = game_with_Bot;
            Player.player_number = 1;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!game_with_Bot)
                SetOptionsTwoMan();
            else
                SetOptionsOneMan();

            playground.IsEnabled = false;

            InitializeField();
            StartBidRound();
        }

        private void InitializeField()
        {
            field = new char[field_size, field_size];
            fieldCell_filled = new bool[field_size, field_size];

            for (int i = 0; i < field_size; i++)
            {
                for (int j = 0; j < field_size; j++)
                {
                    field[i, j] = ' ';
                }
            }
        }
        
        #region Tunning players for current game
        private void SetOptionsOneMan()
        {
            Random rand = new Random();

            int move = rand.Next() % 2;

            if (move == 0)
            {
                SetPlayerName p_name = new SetPlayerName();
                p_name.ShowDialog();
                player1 = new Player(p_name.GetName(), 'X');

                player2 = new Bot("Bot", 'O');
            }
            else
            {
                SetPlayerName p_name = new SetPlayerName();
                p_name.ShowDialog();
                player2 = new Player(p_name.GetName(), 'X');

                player1 = new Bot("Bot", 'O');
            }
        }
        private void SetOptionsTwoMan()
        {
            SetPlayerName p_name1 = new SetPlayerName();
            p_name1.ShowDialog();
            player1 = new Player(p_name1.GetName(), 'X');

            SetPlayerName p_name2 = new SetPlayerName();
            p_name2.ShowDialog();
            player2 = new Player(p_name2.GetName(), 'O');
        }
        #endregion


        #region Интерактивные методы

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (bid_waiting_process)
            {
                bid_waiting_process = false;
                bidGrid.Visibility = Visibility.Visible;
                swapPlayersGrid.Visibility = Visibility.Hidden;

                RoundSecondBid();
            }

            if (e.Key == Key.Escape)
                OpenInterruptWindow();
        }

        private void OpenInterruptWindow()
        {
            GameInterrupt iForm = new GameInterrupt();

            if (iForm.ShowDialog() == true)
                EndGame();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void rectangle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                OpenInterruptWindow();
            }
        }

        private void EndGame()
        {
            NewGame_Menu newGame_menu = new NewGame_Menu();
            newGame_menu.Show();
            this.Close();
        }

        private void Back_Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenInterruptWindow();
        }
        #endregion

        #region Логика игры

        #region Раунд ставок

        private void StartBidRound() // start game point
        {
            playground.IsEnabled = false;
            bid_info_block.Text = $"{player1.Name} makes a bid. Please choose your bid:";
            RoundFirstBid();
        }

        private void RoundFirstBid()
        {
            turn_textBlock.Text = $"{player1.Name}'s bid";
            player1.Turn = true;
            player2.Turn = false;

            if (player1.IsBot() == true)
            {
                waitBot_block.Visibility = Visibility.Visible;
                player1.MakeBid();
                waitBot_block.Visibility = Visibility.Visible;
                EndPlayerBid();
            }
            else
            {
                FirstPlayerBid();
            }
        }

        private void RoundSecondBid()
        {
            turn_textBlock.Text = $"{player2.Name}'s bid";
            bid_info_block.Text = $"{ player2.Name} makes a bid.";
            player1.Turn = false;
            player2.Turn = true;

            if (player2.IsBot() == true)
            {
                waitBot_block.Visibility = Visibility.Visible;
                player2.MakeBid();
            }
            else
            {
                bid_info_block.Text += " Please choose your bid: ";
                SecondPlayerBid();
            }
        }

        #region Ставка раунда человеком
        private void FirstPlayerBid()
        {
            player1.ZeroPoints = false;

            if (player1.Bidding_points.Count == 8)
            {
                bid8.Text = player1.Bidding_points[7].ToString();
                bid8.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 6)
            {
                bid7.Text = player1.Bidding_points[6].ToString();
                bid7.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 5)
            {
                bid6.Text = player1.Bidding_points[5].ToString();
                bid6.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 4)
            {
                bid5.Text = player1.Bidding_points[4].ToString();
                bid5.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 3)
            {
                bid4.Text = player1.Bidding_points[3].ToString();
                bid4.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 2)
            {
                bid3.Text = player1.Bidding_points[2].ToString();
                bid3.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 1)
            {
                bid2.Text = player1.Bidding_points[1].ToString();
                bid2.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 0)
            {
                bid1.Text = player1.Bidding_points[0].ToString();
                bid1.Visibility = Visibility.Visible;
            }
            else
                player1.ZeroPoints = true;
        }

        private void SecondPlayerBid()
        {
            player1.ZeroPoints = false;

            if (player1.Bidding_points.Count == 8)
            {
                bid8.Text = player1.Bidding_points[7].ToString();
                bid8.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 6)
            {
                bid7.Text = player1.Bidding_points[6].ToString();
                bid7.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 5)
            {
                bid6.Text = player1.Bidding_points[5].ToString();
                bid6.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 4)
            {
                bid5.Text = player1.Bidding_points[4].ToString();
                bid5.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 3)
            {
                bid4.Text = player1.Bidding_points[3].ToString();
                bid4.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 2)
            {
                bid3.Text = player1.Bidding_points[2].ToString();
                bid3.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 1)
            {
                bid2.Text = player1.Bidding_points[1].ToString();
                bid2.Visibility = Visibility.Visible;
            }

            if (player1.Bidding_points.Count > 0)
            {
                bid1.Text = player1.Bidding_points[0].ToString();
                bid1.Visibility = Visibility.Visible;
            }
            else
                player1.ZeroPoints = true;
        }
        #endregion

        #region Окончание ставки одного из игроков
        private void EndPlayerBid() // завершить процесс ставки одного из игроков
        {
            if (player1.Turn == true)
            {
                // тут мы делаем паузу для обмена очереди игры игроков
                swapPlayersGrid.Visibility = Visibility.Visible;
                bidGrid.Visibility = Visibility.Hidden;
                moveGrid.Visibility = Visibility.Hidden;
                bid_waiting_process = true;
            }
            else
            {
                EndBidRound();
            }
        }

        private void EndBidRound()              // заканчиваем раунд ставок
        {
            moveGrid.Visibility = Visibility.Visible;
            bidGrid.Visibility = Visibility.Hidden;

            playground.IsEnabled = true;

            game_process = GameProcess.Step;

            if (player1.Round_bid > player2.Round_bid)
            {
                PlayerOneBidWin();
                SetCommentBidResult(player1.Name, false);
            }
            else if (player1.Round_bid < player2.Round_bid)
            {
                PlayerTwoBidWin();
                SetCommentBidResult(player2.Name, false);
            }
            else
            {
                if (player1.Draw_advantage)
                {
                    player1.Draw_advantage = false;
                    player2.Draw_advantage = true;
                    PlayerOneBidWin();

                    SetCommentBidResult(player1.Name, true);
                }
                else
                {
                    player1.Draw_advantage = true;
                    player2.Draw_advantage = false;
                    PlayerTwoBidWin();

                    SetCommentBidResult(player2.Name, true);
                }
            }

            SetRoundBidScore();
            StartMoveRound();
        }

        #region Настройка игроков при расчете ставок 
        private void PlayerOneBidWin()
        {
            player1.Turn = true;
            player2.Turn = false;

            // if first player wins match he makes a move and his bid point transfers to another player/bot
            player2.Bidding_points.Add(player1.Round_bid);
            player1.Bidding_points.Remove(player1.Round_bid);

            move_symbol = player1.Playing_symbol;
            turn_textBlock.Text = $"{player2.Name}'s bid";
        }

        private void PlayerTwoBidWin()
        {
            player1.Turn = false;
            player2.Turn = true;

            player1.Bidding_points.Add(player1.Round_bid);
            player2.Bidding_points.Remove(player1.Round_bid);

            move_symbol = player2.Playing_symbol;
            turn_textBlock.Text = $"{player2.Name}'s move";
        }
        #endregion

        private void SetRoundBidScore()
        {
            bidResult_Textblock.Text = $"({player1.Name}) {player1.Round_bid} : {player2.Round_bid} ({player2.Name})";
            
        }

        private void SetCommentBidResult(string winner_name, bool draw_win)
        {
            // bool draw win - tells whether winner has won the round by draw advantage
            if (draw_win)
                comment_bidResult_Textblock.Text = $"By bidding advantage, {winner_name} makes a move.";
            else
                comment_bidResult_Textblock.Text = $"Now, {winner_name} makes a move.";
        }
        
        #endregion

        #region Интерактивная часть ставки (Человек)
        private void bid8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (player1.Turn)
            {
                player1.Round_bid = int.Parse(bid8.Text);
            }
            else
            {
                player2.Round_bid = int.Parse(bid8.Text);
            }
            EndPlayerBid();
        }

        private void bid7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (player1.Turn)
            {
                player1.Round_bid = int.Parse(bid7.Text);
            }
            else
            {
                player2.Round_bid = int.Parse(bid7.Text);
            }
            EndPlayerBid();
        }

        private void bid6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (player1.Turn)
            {
                player1.Round_bid = int.Parse(bid6.Text);
            }
            else
            {
                player2.Round_bid = int.Parse(bid6.Text);
            }
            EndPlayerBid();
        }

        private void bid5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (player1.Turn)
            {
                player1.Round_bid = int.Parse(bid5.Text);
            }
            else
            {
                player2.Round_bid = int.Parse(bid5.Text);
            }
            EndPlayerBid();
        }

        private void bid4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (player1.Turn)
            {
                player1.Round_bid = int.Parse(bid4.Text);
            }
            else
            {
                player2.Round_bid = int.Parse(bid4.Text);
            }
            EndPlayerBid();
        }

        private void bid3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (player1.Turn)
            {
                player1.Round_bid = int.Parse(bid3.Text);
            }
            else
            {
                player2.Round_bid = int.Parse(bid3.Text);
            }
            EndPlayerBid();
        }

        private void bid2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (player1.Turn)
            {
                player1.Round_bid = int.Parse(bid2.Text);
            }
            else
            {
                player2.Round_bid = int.Parse(bid2.Text);
            }
            EndPlayerBid();
        }

        private void bid1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (player1.Turn)
            {
                player1.Round_bid = int.Parse(bid1.Text);
            }
            else
            {
                player2.Round_bid = int.Parse(bid1.Text);
            }
            EndPlayerBid();
        }

        #endregion

        #endregion


        #region Игра на поле
        private void StartMoveRound()
        {
            if (player1.Turn == true)
            {
                if (player1.IsBot() == true)
                {
                    playground.IsEnabled = false;
                    player1.MakeMove();
                    AnalyzeStep();
                }
            }
            else
            {
                if (player2.IsBot() == true)
                {
                    playground.IsEnabled = false;
                    player2.MakeMove();
                    AnalyzeStep();
                }
            }
        }

        #region Анализ сделанного хода
        private void AnalyzeStep()
        {
            AnalyzeByRows();
            AnalyzeByColumns();
            AnalyzeByDiagonals();
        }
        #endregion

        #region Ход человека

        #region 0 0 cell
        private void cell0_0_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[0, 0] == true)
                return;
            cell0_0.Text = move_symbol.ToString();
        }

        private void cell0_0_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[0, 0] == true)
                return;
            cell0_0.Text = String.Empty;
        }

        private void cell0_0_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fieldCell_filled[0, 0] == true)
                return;
            field[0, 0] = move_symbol;

            fieldCell_filled[0, 0] = true;
            AnalyzeStep();
        }
        #endregion

        #region 0 1 cell
        private void cell0_1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[0, 1] == true)
                return;
            cell0_1.Text = move_symbol.ToString();
        }

        private void cell0_1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[0, 1] == true)
                return;
            cell0_1.Text = String.Empty;
        }

        private void cell0_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fieldCell_filled[0, 1] == true)
                return;
            field[0, 1] = move_symbol;

            fieldCell_filled[0, 1] = true;
            AnalyzeStep();
        }
        #endregion

        #region 0 2 cell
        private void cell0_2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[0, 2] == true)
                return;
            cell0_2.Text = move_symbol.ToString();
        }

        private void cell0_2_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[0, 2] == true)
                return;
            cell0_2.Text = String.Empty;
        }

        private void cell0_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fieldCell_filled[0, 2] == true)
                return;
            field[0, 2] = move_symbol;

            fieldCell_filled[0, 2] = true;
            AnalyzeStep();
        }
        #endregion

        #region 1 0 cell
        private void cell1_0_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[1, 0] == true)
                return;
            cell1_0.Text = move_symbol.ToString();
        }

        private void cell1_0_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[1, 0] == true)
                return;
            cell1_0.Text = String.Empty;
        }

        private void cell1_0_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fieldCell_filled[1, 0] == true)
                return;
            field[1, 0] = move_symbol;

            fieldCell_filled[1, 0] = true;
            AnalyzeStep();
        }
        #endregion

        #region 1 1 cell
        private void cell1_1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[1, 1] == true)
                return;
            cell1_1.Text = move_symbol.ToString();
        }

        private void cell1_1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[1, 1] == true)
                return;
            cell1_1.Text = String.Empty;
        }

        private void cell1_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fieldCell_filled[1, 1] == true)
                return;
            field[1, 1] = move_symbol;

            fieldCell_filled[1, 1] = true;
            AnalyzeStep();
        }
        #endregion

        #region 1 2 cell
        private void cell1_2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[1, 2] == true)
                return;
            cell1_2.Text = move_symbol.ToString();
        }

        private void cell1_2_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[1, 2] == true)
                return;
            cell1_2.Text = String.Empty;
        }

        private void cell1_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fieldCell_filled[1, 2] == true)
                return;
            field[1, 2] = move_symbol;

            fieldCell_filled[1, 2] = true;
            AnalyzeStep();
        }
        #endregion

        #region 2 0 cell
        private void cell2_0_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[2, 0] == true)
                return;
            cell2_0.Text = move_symbol.ToString();
        }

        private void cell2_0_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[2, 0] == true)
                return;
            cell2_0.Text = String.Empty;
        }

        private void cell2_0_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fieldCell_filled[2, 0] == true)
                return;
            field[2, 0] = move_symbol;

            fieldCell_filled[2, 0] = true;
            AnalyzeStep();
        }
        #endregion

        #region 2 1 cell
        private void cell2_1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[2, 1] == true)
                return;
            cell2_1.Text = move_symbol.ToString();
        }

        private void cell2_1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[2, 1] == true)
                return;
            cell2_1.Text = String.Empty;
        }

        private void cell2_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fieldCell_filled[2, 1] == true)
                return;
            field[2, 1] = move_symbol;

            fieldCell_filled[2, 1] = true;
            AnalyzeStep();
        }
        #endregion

        #region 2 2 cell
        private void cell2_2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[2, 2] == true)
                return;
            cell2_2.Text = move_symbol.ToString();
        }

        private void cell2_2_MouseLeave(object sender, MouseEventArgs e)
        {
            if (fieldCell_filled[2, 2] == true)
                return;
            cell2_2.Text = String.Empty;
        }

        private void cell2_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fieldCell_filled[2, 2] == true)
                return;
            field[2, 2] = move_symbol;
            fieldCell_filled[2, 2] = true;
            AnalyzeStep();
        }
        #endregion

        #endregion

        #endregion

        #endregion


    }
}

