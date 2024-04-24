using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    internal class Utility : Property
    {
        public Utility(String name, int cost, int boardPosition)
        {
            this.name = name;
            this.cost = cost;
            this.boardPosition = boardPosition;
            this.type = "utility";
        }

        public override int getRent(int roll)
        {
            int utilitiesOwned = 0;
            int rent = 0;
            foreach (Property property in owner.getProperties())
            {
                if (property.getType() == "utility")
                {
                    utilitiesOwned++;
                }
            }

            if (utilitiesOwned == 1)
            {
                rent = roll * 4;
            }
            else if (utilitiesOwned == 2)
            {
                rent = roll * 10;
            }

            return rent;

        }
    }
}