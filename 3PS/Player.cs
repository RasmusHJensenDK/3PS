using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Player
    {
        private string playerName;
        private string playerToken;
        public Player(string playerName, string playerToken)
        {
            this.playerName = playerName;
            this.playerToken = playerToken;
        }
        public string GetPlayerName()
        {
            return playerName;
        }
        public string GetPlayerToken()
        {
            return playerToken;
        }
    }
}
