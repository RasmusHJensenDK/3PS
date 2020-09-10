using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Board
    {
        private Field[] field;
        List<object> myfields = new List<object>();
        public Board()
        {
            Token token = new Token(tokenValue.Y);
            this.field = new Field[9];
            int i;

            for (i = 0; i < 9; i++)
            {
                Field fields = new Field(token, i);
                myfields.Add(fields);
            }
            DrawBoard(field);
        }

        public void DrawBoard(Field[] field)
        {
            Console.WriteLine("| " + myfields[0].ToString() + " | " + myfields[1].ToString() + " | " + myfields[2].ToString() + " |");
            Console.WriteLine("| " + myfields[3].ToString() + " | " + myfields[4].ToString() + " | " + myfields[5].ToString() + " |");
            Console.WriteLine("| " + myfields[6].ToString() + " | " + myfields[7].ToString() + " | " + myfields[8].ToString() + " |");
        }
        public Field[] GetField()
        {
            return this.field;
        }
         
        public void SetField(int i, Field field)
        {
            this.field[i] = field;
        }

        public Field drawField(int i)
        {
            return field[i];
        }
    }
}
