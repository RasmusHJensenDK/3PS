using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Multiplayer
    {
        private bool win { get; set; }
        private Board board;
        public Multiplayer(Board board)
        {
            this.board = board;
        }

        public void Run()
        {
            Console.WriteLine("First player name?");
            string playername = Console.ReadLine();
            Console.WriteLine("Second player name?");
            string secondplayername = Console.ReadLine();

            Token tokenplayer = new Token(tokenValue.X);
            Token tokensecondplayer = new Token(tokenValue.O);
            Player player = new Player(playername, false, tokenplayer);
            Player secondplayer = new Player(secondplayername, true, tokensecondplayer);

            do
            {
                if (!player.GetPlayerTurn())
                {
                    Console.Clear();
                    board.DrawBoard();
                    Console.WriteLine(playername + " your move");
                    int playermove = Convert.ToInt32(Console.ReadLine());
                    board.MoveField(player, secondplayer, playermove);
                    secondplayer.SetPlayerTurn(false);
                }
                if (!secondplayer.GetPlayerTurn())
                {
                    Console.Clear();
                    board.DrawBoard();
                    Console.WriteLine(secondplayername + " your move");
                    int playermove = Convert.ToInt32(Console.ReadLine());
                    board.MoveField(secondplayer, player, playermove);
                    player.SetPlayerTurn(false);
                }
            } while (!win);
            Console.ReadKey();
        }
    }
}
