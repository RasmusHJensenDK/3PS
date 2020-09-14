using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _3PS
{
    class Board
    {
        private Field[] field;
        private int tokennumber = 0;
        public Board()
        {
            this.field = new Field[9];
            for (int i = 0; i < 9; i++)
            {
                Field fields = new Field(Convert.ToChar(i));
                field[i] = fields;
            }
        }

        public void DrawBoard()
        {
            Console.WriteLine("| 0(" + field[0].GetPieceToken() + ") | 1(" + field[1].GetPieceToken() + ") | 2(" + field[2].GetPieceToken() + ") |");
            Console.WriteLine("| 3(" + field[3].GetPieceToken() + ") | 4(" + field[4].GetPieceToken() + ") | 5(" + field[5].GetPieceToken() + ") |");
            Console.WriteLine("| 6(" + field[6].GetPieceToken() + ") | 7(" + field[7].GetPieceToken() + ") | 8(" + field[8].GetPieceToken() + ") |");
        }

        public void MoveField(Player player, Player playertwo, int fieldToMove)
        {
            Field playermove = new Field(fieldToMove, player.GetPlayerToken(tokennumber));
            while (field[fieldToMove].GetToken() == player.GetPlayerToken(tokennumber) || field[fieldToMove].GetToken() == playertwo.GetPlayerToken(tokennumber))
            {
                Console.WriteLine("Spot allready taken, choose a new spot");
                fieldToMove = Convert.ToInt32(Console.ReadLine());
            }
            field[fieldToMove] = playermove;
            string IsPieceTokenNull = field[0].GetPieceToken();
            Thread.Sleep(500);
        }
        public bool CheckForWin(Player player)
        {
            //Figure out a way to check if fields contains Tokens before running this.
            //Vertical
            for (int i = 0; i < 3; i++)
            {
                if (field[i].GetToken() == player.GetPlayerToken(0) && field[i + 3].GetToken() == player.GetPlayerToken(0) && field[i + 6].GetToken() == player.GetPlayerToken(0))
                {
                    return true;
                }
                // Round 1 : 0 3 6 
                // Round 2 : 1 4 7
                // Round 3 : 2 5 8 
            }
            //Horizontal
            int newint = 0;
            for (int i = 0; i < 3; i++)
            {
                if (field[newint].GetToken() == player.GetPlayerToken(0) && field[newint + 1].GetToken() == player.GetPlayerToken(0) && field[newint + 2].GetToken() == player.GetPlayerToken(0))
                {
                    return true;
                }
                newint = newint + 3;
                // Round 1 : 0 1 3
                // Round 2 : 3 4 5
                // Round 3 : 6 7 8
            }
            //Diagonal
            if (field[0].GetToken() == player.GetPlayerToken(0) && field[4].GetToken() == player.GetPlayerToken(0) && field[8].GetToken() == player.GetPlayerToken(0))
            {
                return true;
            }
            if (field[2].GetToken() == player.GetPlayerToken(0) && field[4].GetToken() == player.GetPlayerToken(0) && field[6].GetToken() == player.GetPlayerToken(0))
            {
                return true;
            }
            return false;
        }
    }
}
