using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidding_Tic_Tac_Toe_Console_App
{
    class Game : IGame
    {
        int field_length = 3;
        char[,] field = null;

        GameState current_game;

        Player player1;
        Player player2;

        public Game()
        {
            InitializeField();
            current_game = GameState.InProcess;
            StepAnalysis.steps = 0;
        }
        void InitializeField()
        {
            field = new char[field_length, field_length];
            for (int i = 0; i < field_length; i++)
            {
                for (int j = 0; j < field_length; j++)
                {
                    field[i, j] = '-';
                }
            }
        }

        public void StartProcess()
        {
            ProgramLookout.UpdateProgramLookout();

            PreparePlayers();

            while (current_game == GameState.InProcess)
            {
                Bidding.BiddingProcess(ref player1, ref player2);

                PrintField();

                MakeStep();

                PrintField();
                
                Console.WriteLine("\nPress any key to continue..");
                Console.ReadKey();

                StepAnalysis.AnalyzeStep(ref field, ref field_length, ref current_game, ref player1.turn);

                if (current_game != GameState.InProcess)
                {
                    if (current_game == GameState.Player1_Win)
                        PrintCongratulation(ref player1);
                    else if (current_game == GameState.Ended_Draw)
                        PrintDrawOutcome();
                    else
                        PrintCongratulation(ref player2);
                }
            }

        }
        void PreparePlayers()
        {
            Console.WriteLine("Player1, please, enter your name:");
            player1 = new Player(Console.ReadLine());
            player1.draw_advantage = true;

            Console.WriteLine("\nPlayer2, please, enter your name:");
            player2 = new Player(Console.ReadLine());
        }

        void MakeStep() // one of players does a step to take one cell
        {
            if (player1.turn)
            {
                Console.WriteLine($"\nNow, it's {player1.Name}'s turn.");
            }
            else
                Console.WriteLine($"\nNow, it's {player2.Name}'s turn.");

            Console.WriteLine("\nPlease Enter your position x,y (0-2,0-2):\n");


            int x = DefineStepCoordinate('x');
            int y = DefineStepCoordinate('y');

            if (field[x, y] != '-')
            {
                Console.WriteLine($"( {x}, {y}) position has been already taken!! \n");

                MakeStep();
                return;
            }

            if (player1.turn)
            {
                field[x, y] = 'X';
            }
            else
                field[x, y] = 'O';
        }


        int DefineStepCoordinate(char coord_symb)
        {
            int coord;

            Console.Write($"{coord_symb}: ");

            if (!int.TryParse(Console.ReadLine(), out coord))
            {
                Console.WriteLine("You must choose among the numbers(0-2)!!!\n");
                coord = DefineStepCoordinate(coord_symb);
            }

            if (coord < 0 || coord > 2)
            {
                Console.WriteLine("You must choose correct coordinate (0-2 number)!!");
                coord = DefineStepCoordinate(coord_symb);
            }

            return coord;
        }

        void PrintField()
        {
            Console.Clear();
            ProgramLookout.UpdateProgramLookout();

            for (int i = 0; i < field_length; i++)
            {
                for (int j = 0; j < field_length; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        void PrintDrawOutcome()
        {
            Console.WriteLine("\nIt seems to be draw now! :/ \n");
        }

        void PrintCongratulation(ref Player player)
        {
            Console.WriteLine($"\nCongratulations {player.Name}!!! You've won the game!:D\n");
        }
    }
}
