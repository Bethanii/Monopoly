using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Monopoly_Start
{
    class Program
    {

        static void Main(string[] args)
        {
            string method;
            Console.WriteLine("1 = chest 0 = chance");
            method = Console.ReadLine();

            CommunityChest NewChest = new CommunityChest();
            Chance NewChance = new Chance();

            if (method == "1")
            {
                NewChest.DrawChestCard();
            }
            else
            {
                NewChance.DrawChanceCard();
            }

        }
    }

    class GamePlay
    {
        public static string GetCurrentPlayer()
        {
            string name = "THE NAME";
            return name;
        }
    }

    class CommunityChest
    {

        GamePlay Current = new GamePlay();
        string Player = GamePlay.GetCurrentPlayer();

        public void DrawChestCard()
        {



            int DrawnCard = 0;
            List<Action> cards = new List<Action> { AdvToGO, BankError, DrFee, StockSale, FreeJailEscape, GoToJail, HolodayFund, TaxRefund, Birthday, InsuranceMatures, HospitalFee, SchoolFee, Consultancy, StreetRepair, BeautyContest, Inherit };

            DrawnCard = RandomNumberGenerator.GetInt32(15);

            Action ResolveCard = cards[DrawnCard];
            ResolveCard();
        }

        void AdvToGO()
        {
            Console.WriteLine("AdvToGO " + Player);
            //need to know the proper methods to call to move player position
        }

        void BankError()
        {
            Console.WriteLine("BankError " + Player);
            //need to know proper method to edit money
        }

        void DrFee()
        {
            Console.WriteLine("DrFee " + Player);
            //need to know proper method to edit money
        }

        void StockSale()
        {
            Console.WriteLine("StockSale " + Player);
            //need to know proper method to edit money
        }

        void FreeJailEscape()
        {
            Console.WriteLine("FreeJailEscape " + Player);
            //need to know proper variable to check to give a get out of jail free card to
        }

        void GoToJail()
        {
            Console.WriteLine("GoToJail " + Player);
            //need to know the proper methods to call to move player position
        }

        void HolodayFund()
        {
            Console.WriteLine("HolodayFund " + Player);
            //need to know proper method to edit money
        }

        void TaxRefund()
        {
            Console.WriteLine("TaxRefund " + Player);
            //need to know proper method to edit money
        }

        void Birthday()
        {
            Console.WriteLine("Birthday " + Player);
            //need to know proper method to edit money
        }

        void InsuranceMatures()
        {
            Console.WriteLine("InsuranceMatures " + Player);
            //need to know proper method to edit money
        }

        void HospitalFee()
        {
            Console.WriteLine("HospitalFee " + Player);
            //need to know proper method to edit money
        }

        void SchoolFee()
        {
            Console.WriteLine("SchoolFee " + Player);
            //need to know proper method to edit money
        }

        void Consultancy()
        {
            Console.WriteLine("Consultancy " + Player);
            //need to know proper method to edit money
        }

        void StreetRepair()
        {
            Console.WriteLine("StreetRepair " + Player);
            //need to know proper method to edit money
        }

        void BeautyContest()
        {
            Console.WriteLine("BeautyContest " + Player);
            //need to know proper method to edit money
        }

        void Inherit()
        {
            Console.WriteLine("Inherit " + Player);
            //need to know proper method to edit money
        }

    }

    class Chance
    {

        GamePlay Current = new GamePlay();
        string Player = GamePlay.GetCurrentPlayer();

        public void DrawChanceCard()
        {



            int DrawnCard = 0;
            List<Action> cards = new List<Action> { AdvToBoardwalk, AdvToGO, AdvToIllinosis, AdvToStCharles, AdvToNxtRailroad, AdvToNxtUtility, Dividend, FreeJailEscape, BackTrack, GoToJail, GeneralRepairs, SpeedTicket, AdvToReadingRailRoad, ElectedChairman, LoanMatures };

            DrawnCard = RandomNumberGenerator.GetInt32(14);

            Action ResolveCard = cards[DrawnCard];
            ResolveCard();
        }

        void AdvToBoardwalk()
        {
            Console.WriteLine("AdvToBoardwalk " + Player);
            //need to know the proper methods to call to move player position
        }

        void AdvToGO()
        {
            Console.WriteLine("AdvToGO " + Player);
            //need to know the proper methods to call to move player position
        }

        void AdvToIllinosis()
        {
            Console.WriteLine("AdvToIllinosis " + Player);
            //need to know the proper methods to call to move player position
        }

        void AdvToStCharles()
        {
            Console.WriteLine("AdvToStCharles " + Player);
            //need to know the proper methods to call to move player position
        }

        void AdvToNxtRailroad()
        {
            Console.WriteLine("AdvToNxtRailroad " + Player);
            //need to know the proper methods to call to move player position as well as if the property is own and how much it cost to land on it
        }

        void AdvToNxtUtility()
        {
            //need to know the proper methods to call to move player position as well as if the property is own and how much it cost to land on it
            int TotalRoll = 0;
            TotalRoll += RandomNumberGenerator.GetInt32(5) + 1;
            TotalRoll += RandomNumberGenerator.GetInt32(5) + 1;
            Console.WriteLine("AdvToNxtUtility " + Player + " Roll = " + TotalRoll);
        }

        void Dividend()
        {
            Console.WriteLine("Dividend " + Player);
            //need to know proper method to edit money
        }

        void FreeJailEscape()
        {
            Console.WriteLine("FreeJailEscape " + Player);
            //need to know proper variable to check to give a get out of jail free card to
        }

        void BackTrack()
        {
            Console.WriteLine("BackTrack " + Player);
            //need to know proper method to edit player position
        }

        void GoToJail()
        {
            Console.WriteLine("GoToJail " + Player);
            //need to know the proper methods to call to move player position
        }

        void GeneralRepairs()
        {
            Console.WriteLine("GeneralRepairs " + Player);
            //need to know proper method to edit money and view owned propertys with there houses and hotels
        }

        void SpeedTicket()
        {
            Console.WriteLine("SpeedTicket " + Player);
            //need to know proper method to edit money
        }

        void AdvToReadingRailRoad()
        {
            Console.WriteLine("AdvToReadingRailRoad " + Player);
            //need to know proper method to edit player position
        }
        void ElectedChairman()
        {
            Console.WriteLine("ElectedChairman " + Player);
            //need to know proper method to edit money
        }

        void LoanMatures()
        {
            Console.WriteLine("LoanMatures " + Player);
            //need to know proper method to edit money
        }
    }
}
