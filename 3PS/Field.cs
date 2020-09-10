using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Field
    {
        private Token token { get; set; }
        private int tokenPosition;
        public Field(int tokenPosition, Token token = null)
        {
            this.token = token;
            this.tokenPosition = tokenPosition;
        }

        public string GetPieceToken()
        {
            if( token == null)
            {
                return "";
            }
            return token.GetTokenValue();
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
