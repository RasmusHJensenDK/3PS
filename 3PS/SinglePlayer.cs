using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _3PS
{
    class SinglePlayer
    {
        public bool win { get; set; }
        private Board board;
        public SinglePlayer(Board board)
        {
            this.board = board;
        }
        public void Run()
        {
            Console.WriteLine("Player name?");
            string playername = Console.ReadLine();

            Random random = new Random();
            Token tokenplayer = new Token(tokenValue.X);
            Player player = new Player(playername, false, tokenplayer);
            Token tokenbot = new Token(tokenValue.O);
            Player bot = new Player("bot", true, tokenbot);

            do
            {
                if (!player.GetPlayerTurn())
                {
                    Console.Clear();
                    board.DrawBoard();
                    Console.WriteLine(playername + " your move");
                    int playermove = Convert.ToInt32(Console.ReadLine());
                    board.MoveField(player, playermove);
                    bot.SetPlayerTurn(false);
                }
                if (!bot.GetPlayerTurn())
                {
                    Console.Clear();
                    board.DrawBoard();
                    Console.WriteLine("Bot is thinking...");
                    Thread.Sleep(400);
                    int botmove = random.Next(0, 8);
                    board.MoveField(bot, botmove);
                    player.SetPlayerTurn(false);
                }
            } while (!win);
            Console.ReadKey();
        }
    }
}