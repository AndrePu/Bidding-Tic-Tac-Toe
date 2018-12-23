using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding_Tic_Tac_Toe_Console_App
{
    public class Player : IPlayer
    {
        internal static int player_number = 0;

        string name = "Player";

        public List<int> bidding_points = new List<int>() { 1, 2, 3, 4 };
        public int round_bid;

        public bool turn = false;              // tells whether its player's turn to make a move
        public bool draw_advantage = false;    // tells whether player wins in case of the draw of bidding round
        public bool victory = false;           // whether player has won the match

        public Player(string name)
        {
            player_number++;
            this.name += player_number.ToString();

            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != String.Empty)
                    name = value;
            }
        }
    }
}
