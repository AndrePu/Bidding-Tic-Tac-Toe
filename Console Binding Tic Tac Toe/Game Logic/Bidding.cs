using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding_Tic_Tac_Toe_Console_App
{
    static class Bidding
    {
        public static void BiddingProcess(ref Player player1, ref Player player2)
        {
            Console.Clear();
            ProgramLookout.UpdateProgramLookout();
            Console.WriteLine("Now, making bids..\n");

            MakeBid(ref player1);
            ControlTransferMessage();           
            MakeBid(ref player2);

            PrintRevealedBids(ref player1, ref player2);
            DefineWinner(ref player1, ref player2);
        }


        
        
        /*Methods for tunning fields of classes*/
        static void MakeBid(ref Player player)
        {
            while (true) // while we're not entered right bid value
            {
                Console.Write($"Please, make a bid, {player.Name} ");
                PrintAccesibleBids(ref player);

                while (!int.TryParse(Console.ReadLine(), out player.round_bid))
                {
                    Console.WriteLine("Set bid by numeral value!!");
                    Console.Write($"Please, make a bid, {player.Name} ");

                    PrintAccesibleBids(ref player);
                }

                if (player.bidding_points.Contains(player.round_bid) || (player.bidding_points.Count == 0 && player.round_bid == 0))
                    break;

                Console.WriteLine($"You can't make such bid, {player.Name}!");
            }

            Console.Clear();
            ProgramLookout.UpdateProgramLookout();
        }

        static void DefineWinner(ref Player player1, ref Player player2)
        {
            if (player1.round_bid > player2.round_bid)
            {
                Console.WriteLine($"{player1.Name} has won the round!");

                player1.turn = true;
                player2.turn = false;

                player1.bidding_points.Remove(player1.round_bid);
                player2.bidding_points.Add(player1.round_bid);
            }
            else if (player1.round_bid == player2.round_bid)
            {
                if (player1.draw_advantage)
                {
                    player1.turn = true;
                    player2.turn = false;

                    Console.WriteLine($"Draw! By bidding advantage {player1.Name} makes a move.");

                    player1.bidding_points.Remove(player1.round_bid);
                    player2.bidding_points.Add(player1.round_bid);

                    player1.draw_advantage = false; // changing draw advantage
                    player2.draw_advantage = true;
                }
                else
                {
                    player1.turn = false;
                    player2.turn = true;

                    Console.WriteLine($"Draw! By bidding advantage {player2.Name} makes a move.");

                    player1.bidding_points.Add(player2.round_bid);
                    player2.bidding_points.Remove(player2.round_bid);

                    player1.draw_advantage = true; // changing bidding advantage
                    player2.draw_advantage = false;
                }
            }
            else
            {
                Console.WriteLine($"{player2.Name} has won the round!");

                player1.turn = false;
                player2.turn = true;

                player1.bidding_points.Add(player2.round_bid);
                player2.bidding_points.Remove(player2.round_bid);
            }

            Console.WriteLine("\nPress any key to continue..");
            Console.ReadKey();
        }

        

        /*Methods for printing current state of bidding*/
        static void PrintAccesibleBids(ref Player player)
        {
            Console.Write("(Possible bids:");
            for (int i = 0; i < player.bidding_points.Count; i++)
            {
                Console.Write($" {player.bidding_points[i]}");

                if (i != player.bidding_points.Count - 1)
                    Console.Write(",");
            }

            if (player.bidding_points.Count == 0)
                Console.Write(" 0");

            Console.WriteLine("):");
        }

        static void PrintRevealedBids(ref Player player1, ref Player player2)
        {
            Console.WriteLine("Bids are done. Made bids:");
            Console.WriteLine($"({player1.Name}) {player1.round_bid} : {player2.round_bid} ({player2.Name})\n");
        }

        static void ControlTransferMessage()
        {
            Console.WriteLine("Now it's time for second player to make a bid.");
            Console.WriteLine("Please, give the opportunity to make a bid another player.\n");
            Console.WriteLine("Press any key if player2 is here..");
            Console.ReadKey();
        }
    }
}
