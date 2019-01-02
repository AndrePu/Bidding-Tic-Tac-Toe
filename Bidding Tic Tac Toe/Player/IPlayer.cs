using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidding_Tic_Tac_Toe
{
    interface IPlayer
    {
        string Name { get; set; }
        List<int> Bidding_points { get; set; }
        
        int Round_bid { get; set; }

        char Playing_symbol { get; set; }    // symbol that will be used in the game against opponent
        bool Turn { get; set; }              // tells whether its player's turn to make a move
        bool Draw_advantage { get; set; }    // tells whether player wins in case of the draw of bidding round
        bool Victory { get; set; }           // whether player has won the match

        bool ZeroPoints { get; set; }        // tells whether player has no points to make a bid

        bool IsBot();                        // tells whether current class is bot

        void MakeBid();

        void MakeMove();
    }
}
