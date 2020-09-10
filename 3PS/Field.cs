using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Field
    {
        private int[] fieldsForTokens = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        private Token token { get; set; }
        private int tokenPosition;
        public Field(Token token, int tokenPosition)
        {
            this.token = token;
            this.tokenPosition = tokenPosition;
        }

        public int GetPieceToken()
        {
            return tokenPosition;
        }

        public void SetField(int str)
        {
            tokenPosition = str;
        }

        public Token GetToken()
        {
            return token;
        }
    }
}
