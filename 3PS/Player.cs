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
        public Player(string playerName, bool playerturn, Token token)
        {
            this.playerName = playerName;
            this.playerturn = playerturn;
            this.token = token;
        }
        public string GetPlayerName()
        {
            return playerName;
        }
        public Token GetPlayerToken()
        {
            return token;
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
