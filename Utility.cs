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

        public int getRent()
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
                //set rent to dice roll for turn multiplied by 4
            }
            else if(utilitiesOwned == 2)
            {
                //set rent to dice roll for turn multiplied by 10
            }
            
            return rent;
            
        }
    }
}
