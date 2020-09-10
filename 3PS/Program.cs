using System;

namespace _3PS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game();
            //game.Run();
            Board board = new Board();
            Token token = new Token(tokenValue.X);
            Token tokenY = new Token(tokenValue.Y);
            Field field = new Field(token, 4);
            Field field2 = new Field(token, 7);
            Field field3 = new Field(token, 4);

            board.SetField(0, field2);
            board.SetField(1, field);
            board.SetField(2, field2);
            board.SetField(3, field);
            board.SetField(4, field2);
            board.SetField(5, field);
            board.SetField(6, field2);
            board.SetField(7, field);
            board.SetField(8, field2);

            Console.WriteLine();

        }
    }
}
