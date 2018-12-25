using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidding_Tic_Tac_Toe_Console_App
{
    static class StepAnalysis
    {
        /*Give more suitable access to fields in methods*/
        static char[,] field { get; set; }
        static int field_length { get; set; }
        static GameState current_game { get; set; }

        static bool player1_turn;
        internal static int steps = 0;


        static void UpdateFields(ref char[,] Field, ref int Field_length, ref GameState Current_game, ref bool Player1_turn)
        {
            field = Field;
            field_length = Field_length;
            current_game = Current_game;
            player1_turn = Player1_turn;
        }
        static void UpdateGameState(ref GameState Current_game)
        {
            Current_game = current_game;
        }


        public static void AnalyzeStep(ref char[,] Field, ref int Field_length, ref GameState Current_game, ref bool Player1_turn)
        {
            UpdateFields(ref Field, ref Field_length, ref Current_game, ref Player1_turn);

            CheckField();

            UpdateGameState(ref Current_game);
        }

        static void CheckField()
        {
            /*First checking victory by rows*/
            CheckRows();

            if (current_game != GameState.InProcess)
                return;


            /*Checking victory by columns*/
            CheckColumns();

            if (current_game != GameState.InProcess)
                return;

            /*Checking victory combinatinations in cross*/
            CheckFieldCross();

            if (current_game != GameState.InProcess)
                return;


            /*Checking possible victory by main diagonal*/
            CheckMainDiagonal();

            if (current_game != GameState.InProcess)
                return;

            /*Checking victory by side diagonal*/
            CheckSideDiagonal();

            if (current_game != GameState.InProcess)
                return;


            /*Checking if we filled all cells of field*/
            steps++;

            if (steps == 9)
                current_game = GameState.Ended_Draw;
        }

        static void CheckRows()
        {
            for (int i = 0; i < field_length; i++)
            {
                current_game = player1_turn ? GameState.Player1_Win : GameState.Player2_Win;
                for (int j = 1; j < field_length; j++)
                {
                    if (field[i, j - 1] != field[i, j] || field[i, j - 1] == '-')
                    {
                        current_game = GameState.InProcess;
                        break;
                    }
                }

                if (current_game != GameState.InProcess)
                    return;
            }
        }

        static void CheckColumns()
        {
            for (int j = 0; j < field_length; j++)
            {
                current_game = player1_turn ? GameState.Player1_Win : GameState.Player2_Win;

                for (int i = 1; i < field_length; i++)
                {
                    if (field[i - 1, j] != field[i, j] || field[i - 1, j] == '-')
                    {
                        current_game = GameState.InProcess;
                        break;
                    }
                }

                if (current_game != GameState.InProcess)
                    return;
            }
        }

        static void CheckFieldCross()
        {
            current_game = player1_turn ? GameState.Player1_Win : GameState.Player2_Win;

            for (int i = 1; i < field_length; i++)
            {
                if (field[i - 1, 1] != field[i, 1] || field[i - 1, 1] == '-')
                {
                    current_game = GameState.InProcess;
                    break;
                }
            }
        }

        static void CheckMainDiagonal()
        {
            current_game = player1_turn ? GameState.Player1_Win : GameState.Player2_Win;

            for (int i = 1; i < field_length; i++)
            {
                if (field[i - 1, i - 1] != field[i, i] || field[i - 1, i - 1] == '-')
                {
                    current_game = GameState.InProcess;
                    break;
                }
            }
        }

        static void CheckSideDiagonal()
        {
            current_game = player1_turn ? GameState.Player1_Win : GameState.Player2_Win;

            for (int i = 1; i < field_length; i++)
            {
                if (field[i - 1, field_length - i] != field[i, field_length - i - 1] || field[i - 1, field_length - i] == '-')
                {
                    current_game = GameState.InProcess;
                    break;
                }
            }
        }
    }
}
