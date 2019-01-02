using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidding_Tic_Tac_Toe
{
    class Bot : IPlayer
    {
        #region Автосвойства
        public string Name { get; set; } = "Bot";
        public List<int> Bidding_points { get; set; } = new List<int>() { 1, 2, 3, 4 };
        public int Round_bid { get; set; }
        public char Playing_symbol { get; set; }

        public bool Turn { get; set; } = false;              // tells whether its player's turn to make a move
        public bool Draw_advantage { get; set; } = false;    // tells whether player wins in case of the draw of bidding round
        public bool Victory { get; set; } = false;           // whether player has won the match
        public bool ZeroPoints { get; set; }
        #endregion


        public Bot(string bot_name, char playing_symbol)
        {
            Name = bot_name;
            Playing_symbol = playing_symbol;
        }
        public bool IsBot()
        {
            return true;
        }

        #region Логика Бота

        #region Логика бота при ставке
        public void MakeBid()
        {

        }
        #endregion

        #region Логика бота при ходе на поле
        public void MakeMove()
        {

        }
        #endregion

        #endregion

    }
}
