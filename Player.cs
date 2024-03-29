using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    internal class Player
    {
        private string name;
        private string piece;
        private string color;
        private int boardPosition;
        private int moneyBalance;
        private List<String> properties = new List<string>();
        private int inJailCounter;

        public Player(string name, string piece, string color, int boardPosition, int moneyBalance, int inJailCounter)
        {
            this.name = name;
            this.piece = piece;
            this.color = color;
            this.boardPosition = boardPosition;
            this.moneyBalance = moneyBalance;
            this.inJailCounter = inJailCounter;
        }
    }
}
