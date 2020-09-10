using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Board
    {
        private Field[] field;
        public Board()
        {
            this.field = new Field[9];
            for (int i = 0; i < 9; i++)
            {
                Field fields = new Field(Convert.ToChar(i));
                field[i] = fields;
            }
            Console.Clear();
        }

        public void DrawBoard()
        {
            Console.WriteLine();
            Console.WriteLine("| 0(" + field[0].GetPieceToken() + ") | 1(" + field[1].GetPieceToken() + ") | 2(" + field[2].GetPieceToken() + ") |");
            Console.WriteLine("| 3(" + field[3].GetPieceToken() + ") | 4(" + field[4].GetPieceToken() + ") | 5(" + field[5].GetPieceToken() + ") |");
            Console.WriteLine("| 6(" + field[6].GetPieceToken() + ") | 7(" + field[7].GetPieceToken() + ") | 8(" + field[8].GetPieceToken() + ") |");
        }
        public Field[] GetField()
        {
            return this.field;
        }

        public void MoveField(Player player, int fieldToMove)
        {
//::IMPLEMENT::Check if token is allready there.
            Field fields = new Field(fieldToMove, player.GetPlayerToken());
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
