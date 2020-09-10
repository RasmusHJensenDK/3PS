using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Board
    {
        private Field[] field;
        Token token = new Token(tokenValue.E);
        public Board()
        {
            this.field = new Field[9];
            for (int i = 0; i < 9; i++)
            {
                Field fields = new Field(token, Convert.ToChar(i));
                field[i] = fields;
            }
            DrawBoard();
            Console.Clear();
        }

        public void DrawBoard()
        {
            //::IMPORTANT:: Figure out why the tokenvalue is not printed??!
            Console.WriteLine();
            Console.WriteLine("| 0(" + field[0].GetPieceToken().ToString() + ") | 1(" + field[1].GetPieceToken().ToString() + ") | 2(" + field[2].GetPieceToken().ToString() + ") |");
            Console.WriteLine("| 3(" + field[3].GetPieceToken().ToString() + ") | 4(" + field[4].GetPieceToken().ToString() + ") | 5(" + field[5].GetPieceToken().ToString() + ") |");
            Console.WriteLine("| 6(" + field[6].GetPieceToken().ToString() + ") | 7(" + field[7].GetPieceToken().ToString() + ") | 8(" + field[8].GetPieceToken().ToString() + ") |");
        }
        public Field[] GetField()
        {
            return this.field;
        }

        public void MoveField(Player player, int fieldToMove)
        {
            //::IMPLEMENT::Check if token is allready there.
            Field fields = new Field(player.GetPlayerToken(), fieldToMove);
            field[fieldToMove] = fields;
        }
        public Field DrawField(int i)
        {
            return field[i];
        }

        //::IMPLEMENT::Check for 3 on a row horizontal vertical diagonal.
        public bool CheckForWin()
        {
            return false;
        }
    }
}
