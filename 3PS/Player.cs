using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Player
    {
        private bool playerturn { get; set; }
        private string playerName;
        private Token token;
        List<object> playertokens = new List<object>();
        public Player(string playerName, bool playerturn, Token token)
        {
            this.playerName = playerName;
            this.playerturn = playerturn;
            this.token = token;
            for(int i = 0; i < 3; i++)
            {
                token = new Token();
                playertokens.Add(token);
            }
        }
        public string GetPlayerName()
        {
            return playerName;
        }
        public Token GetPlayerToken(int i)
        {
            return token[i];
        }
        public void SetPlayerTurn(bool b)
        {
            playerturn = b;
        }
        public bool GetPlayerTurn()
        {
            return playerturn;
        }
    }
}
