using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _3PS
{
    class SinglePlayer
    {
        public bool win { get; set; }
        public SinglePlayer()
        {
            Board board = new Board();
            Token token = new Token(tokenValue.E);
            Token tokenplayer = new Token(tokenValue.X);
            Token tokenbot = new Token(tokenValue.O);
            Random random = new Random();
            Console.WriteLine("Player name?");
            string playername = Console.ReadLine();
            Player player = new Player(playername, false, tokenplayer);
            Player bot = new Player("bot", true, tokenbot);

            do
            {
                Console.Clear();
                board.DrawBoard();

                if(!player.GetPlayerTurn())
                {
                    Console.WriteLine(playername + " your move");
                    int playermove = Convert.ToInt32(Console.ReadLine());
                    board.MoveField(player, playermove);
                    bot.SetPlayerTurn(false);
                }
                if(!bot.GetPlayerTurn())
                {
                    Console.WriteLine("Bot is thinking...");
                    Thread.Sleep(400);
                    int botmove = random.Next(0, 9);
                    board.MoveField(bot, botmove);
                    player.SetPlayerTurn(false);
                }

            } while (!win);
            Console.ReadKey();
        }

        public void Run()
        {

        }
    }
}