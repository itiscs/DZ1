using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;
            ConsoleKeyInfo userKey;
            int locationX = 0;
            int locationY = 0;
            int prevlocationX = 0;
            int prevlocationY = 0;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.Clear();

            while (gameRunning)
            {
                // Process the game data here
                //    1. Update inputs
                //    2. Update game logic
                //    3. Draw new updates

                userKey = Console.ReadKey(true);
                prevlocationX = locationX;
                prevlocationY = locationY;

                switch (userKey.Key)
                {

                    case ConsoleKey.LeftArrow:
                        // See if we can move left
                        if (locationX > 0)
                        {
                            // Move ourself left
                            locationX = locationX - 1;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        // See if we can move right
                        if (locationX < 78)
                        {
                            // Read the System Caret section for
                            // more information on why you should 
                            // use 78 instead of the 79 here.
                            locationX = locationX + 1;
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        // See if we can move up
                        if (locationY > 0)
                        {
                            // Move ourself up
                            locationY = locationY - 1;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        // See if we can move down
                        if (locationY < 24)
                        {
                            // Move ourself down
                            locationY = locationY + 1;
                        }
                        break;

                    case ConsoleKey.Escape:
                        // Exit the game when pressed
                        gameRunning = false;
                        break;
                }

                Console.SetCursorPosition(prevlocationX, prevlocationY);
                Console.Write(" ");
                Console.SetCursorPosition(locationX, locationY);
                Console.Write("@");
                





            }







        }
    }
}
