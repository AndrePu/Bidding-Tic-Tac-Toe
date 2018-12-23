using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding_Tic_Tac_Toe_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            ProgramLookout.App_Name = "Bidding Tic Tac Toe";
            Game new_game = new Game();
            new_game.StartProcess();
            
            Console.WriteLine("Do you want to play again?(y/n)");
            string answer = Console.ReadLine();

            while (answer != "y" && answer != "n")
            {
                Console.WriteLine("Please, reenter your answer again using only y/n signs:");
                Console.WriteLine("Do you want to play again?(y/n)");
                answer = Console.ReadLine();
            }


            if (answer == "y")
                Main(new string[] {});
        }
    }
}
