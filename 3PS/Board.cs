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
            Token token = new Token(tokenValue.Y);
            this.field = new Field[9];
            int i;

            for (i = 0; i < field.Length; i++)
            {
                Field fields = new Field(token, i);
                field[i] = fields;
                i++;


                Console.WriteLine(field[i].GetPieceToken().ToString());
            }
        }
        public Field[] GetField()
        {
            return this.field;
        }

        public void SetField(int i, Field field)
        {
            this.field[i] = field;
        }

        public Field drawField()
        {
            Random random = new Random();
            int index = random.Next(0, (field.Length - 1));
            return field[index];
        }
    }
}
