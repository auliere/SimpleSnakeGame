﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnakeGame
{
    public class Menu
    {

        private static string logo = "\r\n     _______..__   __.      ___       __  ___  _______ \r\n    /       ||  \\ |  |     /   \\     |  |/  / |   ____|\r\n   |   (----`|   \\|  |    /  ^  \\    |  \'  /  |  |__   \r\n    \\   \\    |  . `  |   /  /_\\  \\   |    <   |   __|  \r\n.----)   |   |  |\\   |  /  _____  \\  |  .  \\  |  |____ \r\n|_______/    |__| \\__| /__/     \\__\\ |__|\\__\\ |_______|\r\n                                                       \r\n";

        public static int Show()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.WriteLine(logo);
            Console.WriteLine("Press ENTER to start game. Press any other key to exit");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
                return 1;
            return 0;
        }

    }
}
