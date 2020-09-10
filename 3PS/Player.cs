using System;
using System.Collections.Generic;
using System.Text;

namespace _3PS
{
    class Player
    {
        private string playerName;

        public Player(string playerName)
        {
            this.playerName = playerName;
        }
        public string GetPlayerName()
        {
            return playerName;
        }
    }
}
