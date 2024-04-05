using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    internal class Street : Property
    {
        private String colorGroup;
        private int colorGroupSize;
        private int baseRent;
        private int wholeGroupRent;
        private int oneHouseRent;
        private int twoHouseRent;
        private int threeHouseRent;
        private int fourHouseRent;
        private int hotelRent;
        private int housePrice;
        private int houseCount;

        public Street(String name, String ColorGroup, int colorGroupSize, int cost, int baseRent, int wholeGroupRent, int oneHouseRent, int twoHouseRent, int threeHouseRent, int fourHouseRent, int hotelRent, int housePrice, int boardPosition)
        {
            this.name = name;
            this.colorGroup = ColorGroup;
            this.colorGroupSize = colorGroupSize;
            this.cost = cost;
            this.baseRent = baseRent;
            this.wholeGroupRent = wholeGroupRent;
            this.oneHouseRent = oneHouseRent;
            this.twoHouseRent = twoHouseRent;
            this.threeHouseRent = threeHouseRent;
            this.fourHouseRent = fourHouseRent;
            this.hotelRent = hotelRent;
            this.housePrice = housePrice;
            this.houseCount = 0;
            this.boardPosition = boardPosition;
            this.type = "street";
        }

        public override String getColorGroup()
        {
            return colorGroup;
        }

        public int getRent()
        {
            int colorGroupOwned = 0;

            foreach (Property property in owner.getProperties())
            {
                if (property.getColorGroup() == colorGroup)
                {
                    colorGroupOwned++;
                }   
            }
            if (colorGroupOwned == colorGroupSize)
            {
                switch (houseCount)
                {
                    case 0:
                        return wholeGroupRent;
                    case 1:
                        return oneHouseRent;
                    case 2:
                        return twoHouseRent;
                    case 3:
                        return threeHouseRent;
                    case 4:
                        return fourHouseRent;
                    default:
                        return wholeGroupRent;
                }
            }
            else
            {
                return baseRent;
            }
        }
        public int getHousePrice()
        {
            return housePrice;
        }
        public int getHouseCount()
        {
            return houseCount;
        }
        public void setHouseCount(int houseCount)
        {
            this.houseCount = houseCount;
        }
    }


}
