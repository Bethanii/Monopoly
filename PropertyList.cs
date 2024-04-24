using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    internal class PropertyList
    {
        private Dictionary<int, Property> boardPositionToPropertyMap = new Dictionary<int, Property>();
        public PropertyList() 
        {
            

            //hard coding rent values for now
            //------------- Brown ------------------
            Property mediterraneanAvenue = new Street("Mediteranean Avenue", "brown", 2, 60, 2, 4, 10, 30, 90, 160, 250, 50, 1);
            boardPositionToPropertyMap.Add(mediterraneanAvenue.getBoardPosition(), mediterraneanAvenue);

            Property balticAvenue = new Street("Baltic Avenue", "brown", 2, 60, 4, 8, 20, 60, 180, 320, 450, 50, 3);
            boardPositionToPropertyMap.Add(balticAvenue.getBoardPosition(), balticAvenue);


            //------------- Light Blue------------------
            Property orientalAvenue = new Street("Oriental Avenue", "lightBlue", 3, 100, 6, 12, 30, 90, 270, 400, 550, 50, 6);
            boardPositionToPropertyMap.Add(orientalAvenue.getBoardPosition(), orientalAvenue);

            Property vermontAvenue = new Street("Vermont Avenue", "lightBlue", 3, 100, 6, 12, 30, 90, 270, 400, 550, 50, 8);
            boardPositionToPropertyMap.Add(vermontAvenue.getBoardPosition(), vermontAvenue);

            Property connecticutAvenue = new Street("Connecticut Avenue", "lightBlue", 3, 120, 8, 16, 40, 100, 300, 450, 600, 50, 9);
            boardPositionToPropertyMap.Add(connecticutAvenue.getBoardPosition(), connecticutAvenue);


            //------------- Magenta ------------------
            Property stCharlesPlace = new Street("St. Charles Place", "pink", 3, 140, 10, 20, 50, 150, 450, 625, 750, 100, 11);
            boardPositionToPropertyMap.Add(stCharlesPlace.getBoardPosition(), stCharlesPlace);

            Property statesAve = new Street("States Avenue", "pink", 3, 140, 10, 20, 50, 150, 450, 625, 750, 100, 13);
            boardPositionToPropertyMap.Add(statesAve.getBoardPosition(), statesAve);

            Property virginiaAve = new Street("Virginia Avenue", "pink", 3, 160, 12, 24, 60, 180, 500, 700, 900, 100, 14);
            boardPositionToPropertyMap.Add(virginiaAve.getBoardPosition(), virginiaAve);


            //------------- Orange ------------------
            Property stJamesPlace = new Street("St. James Place", "orange", 3, 180, 14, 28, 70, 200, 550, 750, 950, 100, 16);
            boardPositionToPropertyMap.Add(stJamesPlace.getBoardPosition(), stJamesPlace);

            Property tennesseeAve = new Street("Tennessee Avenue", "orange", 3, 180, 14, 28, 70, 200, 550, 750, 950, 100, 18);
            boardPositionToPropertyMap.Add(tennesseeAve.getBoardPosition(), tennesseeAve);

            Property newYorkAve = new Street("New York Avenue", "orange", 3, 200, 16, 32, 80, 220, 600, 800, 1000, 100, 19);
            boardPositionToPropertyMap.Add(newYorkAve.getBoardPosition(), newYorkAve);


            //------------- Red ------------------
            Property kentuckyAve = new Street("Kentucky Avenue", "red", 3, 220, 18, 36, 90, 250, 700, 875, 1050, 150, 21);
            boardPositionToPropertyMap.Add(kentuckyAve.getBoardPosition(), kentuckyAve);

            Property indianaAve = new Street("Indiana Avenue", "red", 3, 220, 18, 36, 90, 250, 700, 875, 1050, 150, 23);
            boardPositionToPropertyMap.Add(indianaAve.getBoardPosition(), indianaAve);

            Property illinoisAve = new Street("Illinois Avenue", "red", 3, 240, 20, 40, 100, 300, 750, 925, 1100, 150, 24);
            boardPositionToPropertyMap.Add(illinoisAve.getBoardPosition(), illinoisAve);


            //------------- Yellow ------------------
            Property atlanticAve = new Street("Atlantic Avenue", "yellow", 3, 260, 22, 44, 110, 330, 800, 975, 1150, 150, 26);
            boardPositionToPropertyMap.Add(atlanticAve.getBoardPosition(), atlanticAve);

            Property ventnorAve = new Street("Ventnor Avenue", "yellow", 3, 260, 22, 44, 110, 330, 800, 975, 1150, 150, 27);
            boardPositionToPropertyMap.Add(ventnorAve.getBoardPosition(), ventnorAve);

            Property marvinGardens = new Street("Marvin Gardens", "yellow", 3, 280, 24, 48, 120, 360, 850, 1025, 1200, 150, 29);
            boardPositionToPropertyMap.Add(marvinGardens.getBoardPosition(), marvinGardens);


            //------------- Green ------------------
            Property pacificAve = new Street("Pacific Avenue", "green", 3, 300, 26, 52, 130, 390, 900, 1100, 1275, 200, 31);
            boardPositionToPropertyMap.Add(pacificAve.getBoardPosition(), pacificAve);

            Property northCarolinaAve = new Street("North Carolina Avenue", "green", 3, 300, 26, 52, 130, 390, 900, 1100, 1275, 200, 32);
            boardPositionToPropertyMap.Add(northCarolinaAve.getBoardPosition(), northCarolinaAve);

            Property pennsylvaniaAve = new Street("Pennsylvania Avenue", "green", 3, 320, 28, 56, 150, 450, 1000, 1200, 1400, 200, 34);
            boardPositionToPropertyMap.Add(pennsylvaniaAve.getBoardPosition(), pennsylvaniaAve);


            //------------- Dark Blue ------------------
            Property parkPlace = new Street("Park Place", "darkBlue", 2, 350, 35, 70, 175, 500, 1100, 1300, 1500, 200, 37);
            boardPositionToPropertyMap.Add(parkPlace.getBoardPosition(), parkPlace);

            Property boardwalk = new Street("Boardwalk", "darkBlue", 2, 400, 50, 100, 200, 600, 1400, 1700, 2000, 200, 39);
            boardPositionToPropertyMap.Add(boardwalk.getBoardPosition(), boardwalk);

            //-------------- Rail Roads -----------------
            Property ReadingRailRoad = new RailRoad("Reading Rail Road", 200, 5);
            boardPositionToPropertyMap.Add(ReadingRailRoad.getBoardPosition(), ReadingRailRoad);

            Property PennsylvaniaRailRoad = new RailRoad("Pennsylvania Rail Road", 200, 15);
            boardPositionToPropertyMap.Add(PennsylvaniaRailRoad.getBoardPosition(), PennsylvaniaRailRoad);

            Property BAndORailRoad = new RailRoad("B&O Rail Road", 200, 25);
            boardPositionToPropertyMap.Add(BAndORailRoad.getBoardPosition(), BAndORailRoad);

            Property ShortLine = new RailRoad("Short Line", 200, 35);
            boardPositionToPropertyMap.Add(ShortLine.getBoardPosition(), ShortLine);

            //--------------- Utilities -----------------

            Property ElectricCompany = new Utility("Electric Company", 150, 12);
            boardPositionToPropertyMap.Add(ElectricCompany.getBoardPosition(), ElectricCompany);

            Property WaterWorks = new Utility("Water Works", 150, 28);
            boardPositionToPropertyMap.Add(WaterWorks.getBoardPosition(), WaterWorks);


        }

        public Dictionary<int, Property> getProperties()
        {
            return boardPositionToPropertyMap;
        }
    }
}
