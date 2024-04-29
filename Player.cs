using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class Player
    {
        private string name;
        private string piece;
        private string color;
        private int boardPosition;
        private int moneyBalance;
        private List<Property> properties = new List<Property>();
        private int inJailCounter;
        private bool getOutOfJailFree;
   

        public Player(string name, string piece, string color)
        {
            this.name = name;
            this.piece = piece;
            this.color = color;
            this.boardPosition = 0;
            this.moneyBalance = 1500;
            this.inJailCounter = 0;
            this.getOutOfJailFree = false;
        }

        public string getName()
        {
            return name;
        }
        public string getPiece()
        {
            return piece;
        }
        public string getColor()
        {
            return color;
        }
        public int getBoardPosition()
        {
            return boardPosition;
        }
        public void setBoardPosition(int position)
        {
            boardPosition = position;
        }
        public int getMoneyBalance()
        {
            return moneyBalance;
        }
        public void setMoneyBalance(int balance)
        {
            moneyBalance = balance;
        }
        public int getInJailCounter()
        {
            return inJailCounter;
        }
        public void setInJailCounter(int counter)
        {
            inJailCounter = counter;
        }
        public bool getJailCardValue()
        {
            return getOutOfJailFree;
        }
        public void setJailCardValue(bool value)
        {
            getOutOfJailFree = value;
        }
        public List<Property> getProperties()
        {
            return properties;
        }
        public void addProperties(Property property)
        {
            properties.Add(property);
            property.setOwner(this);
        }
        public void removeProperties(Property property)
        {
            properties.Remove(property);
            property.setOwner(null);
        }
    }
}
