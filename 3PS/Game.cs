using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Game
    {
        public Game()
        {
        }

        public void NewGame()
        {
            Board board = new Board();
            Console.WriteLine("Velkommen til 3 på Stribe");
            Console.WriteLine("(S)ingle eller (M)ultiplayer?");
            char gamemode = Console.ReadKey().KeyChar;

            switch (gamemode)
            {
                case 'S':
                    SinglePlayer singleplayer = new SinglePlayer(board);
                    singleplayer.Run();
                    break;
                case 'M':
                    Multiplayer multiplayer = new Multiplayer(board);
                    multiplayer.Run();
                    break;
            }
        }
    }
}
