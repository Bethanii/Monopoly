using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    internal class RailRoad : Property
    {
        public RailRoad(String name, int cost, int boardPosition)
        {
            this.name = name;
            this.cost = cost;
            this.boardPosition = boardPosition;
            this.type = "RailRoad";
        }
        public override int getRent(int roll)
        {
            int railRoadsOwned = 0;
            foreach (Property property in owner.getProperties())
            {
                if (property.getType() == "RailRoad")
                {
                    railRoadsOwned++;
                }
            }
            switch (railRoadsOwned)
            {
                case 1:
                    return 25;
                case 2:
                    return 50;
                case 3:
                    return 100;
                case 4:
                    return 200;
                default:
                    return 0;
            }
        }
    }
}