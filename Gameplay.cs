using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class Gameplay
    {
        public (int dice1, int dice2, int total) getDiceRollCount()
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int total = dice1 + dice2;

            return (dice1, dice2, total);
        }
        // pay rent, buy property, or draw card
        public (int propertyCost, Property propertyForSale) turnOptions(int playerPosition, PropertyList properties)
        {
            int propertyCost = 0;
            Property propertyForSale = new Property();
            foreach(Property property in properties.getProperties())
            {
                if (property.getBoardPosition() == playerPosition)
                {
                    propertyForSale = property;
                    if (property.getOwner() == null)
                    {
                        propertyCost = property.getCost();
                        break;
                    }
                }
            }
            return (propertyCost, propertyForSale);
        }
    }
}
