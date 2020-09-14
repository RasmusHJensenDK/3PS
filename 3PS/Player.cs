using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Player
    {
        private bool playerturn { get; set; }
        private string playerName;
        private Token[] token = new Token[3];
        public Player(string playerName, bool playerturn, Token token)
        {
            this.playerName = playerName;
            this.playerturn = playerturn;

            for(int i = 0; i < 3; i++)
            {
                this.token[i] = token;
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
