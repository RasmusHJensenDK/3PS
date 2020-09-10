using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    public enum tokenValue { X, O, E}
    class Token
    {
        private string tokenValue;
        public Token(tokenValue value)
        {
            this.tokenValue = value.ToString();
        }
        public string GetTokenValue()
        {
            return tokenValue;
        }
    }
}
