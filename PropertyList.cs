using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class PropertyList
    {
        private List<Property> properties = new List<Property>();

        public PropertyList()
        {
            properties.Add(new Street("Mediteranean Avenue", "brown", 2, 60, 2, 4, 10, 30, 90, 160, 250, 50, 1));
            properties.Add(new Street("Baltic Avenue", "brown", 2, 60, 4, 8, 20, 60, 180, 320, 450, 50, 3));
            properties.Add(new Street("Oriental Avenue", "lightBlue", 3, 100, 6, 12, 30, 90, 270, 400, 550, 50, 6));
            properties.Add(new Street("Vermont Avenue", "lightBlue", 3, 100, 6, 12, 30, 90, 270, 400, 550, 50, 8));
            properties.Add(new Street("Connecticut Avenue", "lightBlue", 3, 120, 8, 16, 40, 100, 300, 450, 600, 50, 9));
            properties.Add(new Street("St. Charles Place", "pink", 3, 140, 10, 20, 50, 150, 450, 625, 750, 100, 11));
            properties.Add(new Street("States Avenue", "pink", 3, 140, 10, 20, 50, 150, 450, 625, 750, 100, 13));
            properties.Add(new Street("Virginia Avenue", "pink", 3, 160, 12, 24, 60, 180, 500, 700, 900, 100, 14));
            properties.Add(new Street("St. James Place", "orange", 3, 180, 14, 28, 70, 200, 550, 750, 950, 100, 16));
            properties.Add(new Street("Tennessee Avenue", "orange", 3, 180, 14, 28, 70, 200, 550, 750, 950, 100, 18));
            properties.Add(new Street("New York Avenue", "orange", 3, 200, 16, 32, 80, 220, 600, 800, 1000, 100, 19));
            properties.Add(new Street("Kentucky Avenue", "red", 3, 220, 18, 36, 90, 250, 700, 875, 1050, 150, 21));
            properties.Add(new Street("Indiana Avenue", "red", 3, 220, 18, 36, 90, 250, 700, 875, 1050, 150, 23));
            properties.Add(new Street("Illinois Avenue", "red", 3, 240, 20, 40, 100, 300, 750, 925, 1100, 150, 24));
            properties.Add(new Street("Atlantic Avenue", "yellow", 3, 260, 22, 44, 110, 330, 800, 975, 1150, 150, 26));
            properties.Add(new Street("Ventnor Avenue", "yellow", 3, 260, 22, 44, 110, 330, 800, 975, 1150, 150, 27));
            properties.Add(new Street("Marvin Gardens", "yellow", 3, 280, 24, 48, 120, 360, 850, 1025, 1200, 150, 29));
            properties.Add(new Street("Pacific Avenue", "green", 3, 300, 26, 52, 130, 390, 900, 1100, 1275, 200, 31));
            properties.Add(new Street("North Carolina Avenue", "green", 3, 300, 26, 52, 130, 390, 900, 1100, 1275, 200, 32));
            properties.Add(new Street("Pennsylvania Avenue", "green", 3, 320, 28, 56, 150, 450, 1000, 1200, 1400, 200, 34));
            properties.Add(new Street("Park Place", "darkBlue", 2, 350, 35, 70, 175, 500, 1100, 1300, 1500, 200, 37));
            properties.Add(new Street("Boardwalk", "darkBlue", 2, 400, 50, 100, 200, 600, 1400, 1700, 2000, 200, 39));
            properties.Add(new RailRoad("Reading Rail Road", 200, 5));
            properties.Add(new RailRoad("Pennsylvania Rail Road", 200, 15));
            properties.Add(new RailRoad("B&O Rail Road", 200, 25));
            properties.Add(new RailRoad("Short Line", 200, 35));
            properties.Add(new Utility("Electric Company", 150, 12));
            properties.Add(new Utility("Water Works", 150, 28));
        }

        public List<Property> getProperties()
        {
            return properties;
        }
    }
}
