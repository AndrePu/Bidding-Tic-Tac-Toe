using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidding_Tic_Tac_Toe_Console_App
{
    static class ProgramLookout
    {
        static string app_name;
        static int app_name_length;

        const int console_window_height = 40;
        const int console_window_width = 120;

        static char heading_frame_sign = '=';
        static int heading_frame_length;


        public static string App_Name
        {
            set
            {
                app_name = value;

                /*Installing values for fields dependent on App name*/
                app_name_length = app_name.Length;
                heading_frame_length = (console_window_width - app_name_length - 2) / 2;
            }
        }

        public static void UpdateProgramLookout()
        {
            Console.WindowHeight = console_window_height;
            Console.WindowWidth = console_window_width;
            ShowAppName();
        }

        private static void ShowAppName()
        {
            for (int i = 0; i < heading_frame_length; i++)
            {
                Console.Write(heading_frame_sign);
            }
            
            Console.Write($"|{app_name}|");

            for (int i = 0; i < heading_frame_length; i++)
            {
                Console.Write(heading_frame_sign);
            }

            Console.WriteLine('\n');
        }
    }
}
