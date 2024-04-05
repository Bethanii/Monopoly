using System.Security.Cryptography.X509Certificates;

namespace MonopolyGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Street mediterraneanAvenue = new Street("Mediteranean Avenue", "brown", 2, 60, 2, 4, 10, 30, 90, 160, 250, 50, 1);
            Street balticAvenue = new Street("Baltic Avenue", "brown", 2, 60, 4, 8, 20, 60, 180, 320, 450, 50, 3);
            Street orientalAvenue = new Street("Oriental Avenue", "lightBlue", 3, 100, 6, 12, 30, 90, 270, 400, 550, 50, 6);
            Street vermontAvenue = new Street("Vermont Avenue", "lightBlue", 3, 100, 6, 12, 30, 90, 270, 400, 550, 50, 8);
            Street connecticutAvenue = new Street("Connecticut Avenue", "lightBlue", 3, 120, 8, 16, 40, 100, 300, 450, 600, 50, 9);
            Street stCharlesPlace = new Street("St. Charles Place", "pink", 3, 140, 10, 20, 50, 150, 450, 625, 750, 100, 11);
            Street statesAvenue = new Street("States Avenue", "pink", 3, 140, 10, 20, 50, 150, 450, 625, 750, 100, 13);
            Street virginiaAvenue = new Street("Virginia Avenue", "pink", 3, 160, 12, 24, 60, 180, 500, 700, 900, 100, 14);
            Street stJamesPlace = new Street("St. James Place", "orange", 3, 180, 14, 28, 70, 200, 550, 750, 950, 100, 16);
            Street tennesseeAvenue = new Street("Tennessee Avenue", "orange", 3, 180, 14, 28, 70, 200, 550, 750, 950, 100, 18);
            Street newYorkAvenue = new Street("New York Avenue", "orange", 3, 200, 16, 32, 80, 220, 600, 800, 1000, 100, 19);
            Street kentuckyAvenue = new Street("Kentucky Avenue", "red", 3, 220, 18, 36, 90, 250, 700, 875, 1050, 150, 21);
            Street indianaAvenue = new Street("Indiana Avenue", "red", 3, 220, 18, 36, 90, 250, 700, 875, 1050, 150, 23);
            Street illinoisAvenue = new Street("Illinois Avenue", "red", 3, 240, 20, 40, 100, 300, 750, 925, 1100, 150, 24);
            Street atlanticAvenue = new Street("Atlantic Avenue", "yellow", 3, 260, 22, 44, 110, 330, 800, 975, 1150, 150, 26);
            Street ventnorAvenue = new Street("Ventnor Avenue", "yellow", 3, 260, 22, 44, 110, 330, 800, 975, 1150, 150, 27);
            Street marvinGardens = new Street("Marvin Gardens", "yellow", 3, 280, 24, 48, 120, 360, 850, 1025, 1200, 150, 29);
            Street pacificAvenue = new Street("Pacific Avenue", "green", 3, 300, 26, 52, 130, 390, 900, 1100, 1275, 200, 31);
            Street northCarolinaAvenue = new Street("North Carolina Avenue", "green", 3, 300, 26, 52, 130, 390, 900, 1100, 1275, 200, 32);
            Street pennsylvaniaAvenue = new Street("Pennsylvania Avenue", "green", 3, 320, 28, 56, 150, 450, 1000, 1200, 1400, 200, 34);
            Street parkPlace = new Street("Park Place", "darkBlue", 2, 350, 35, 70, 175, 500, 1100, 1300, 1500, 200, 37);
            Street boardwalk = new Street("Boardwalk", "darkBlue", 2, 400, 50, 100, 200, 600, 1400, 1700, 2000, 200, 39);
            RailRoad readingRailRoad = new RailRoad("Reading Rail Road", 200, 5);
            RailRoad pennsylvaniaRailRoad = new RailRoad("Pennsylvania Rail Road", 200, 15);
            RailRoad boRailRoad = new RailRoad("B&O Rail Road", 200, 25);
            RailRoad shortLine = new RailRoad("Short Line", 200, 35);
            Utility electricCompany = new Utility("Electric Company", 150, 12);
            Utility waterWorks = new Utility("Water Works", 150, 28);

            


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Gameboard());
        }
    }
}