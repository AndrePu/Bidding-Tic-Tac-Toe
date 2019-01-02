using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidding_Tic_Tac_Toe
{
    public class Player : IPlayer
    {

        public static int player_number = 1;

        #region Автосвойства класса
        public string Name { get; set; } = "Player";
        public List<int> Bidding_points { get; set; } = new List<int>() { 1, 2, 3, 4 };
        public int Round_bid { get; set; }
        public char Playing_symbol { get; set; }

        public bool Turn { get; set; } = false;              // tells whether its player's turn to make a move
        public bool Draw_advantage { get; set; } = true;    // tells whether player wins in case of the draw of bidding round
        public bool Victory { get; set; } = false;           // whether player has won the match
        public bool ZeroPoints { get; set; }
        #endregion

        #region Конструкторы класса

        public Player(string name, char playing_symbol)
        {
            Name += player_number.ToString();

            player_number++;

            Playing_symbol = playing_symbol;

            if (name != null)
                Name = name;
        }

        #endregion

        public bool IsBot()
        {
            return false;
        }

        #region Пока не нужные методы
        public void MakeBid(){ }
        public void MakeMove() { }
        #endregion
    }

}
