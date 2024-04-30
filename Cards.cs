﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MonopolyGame
{
    public class Cards
    {
        Gameplay gameplay = new Gameplay();
        public void DrawChestCard(Player currentPlayer, Dictionary<Player, PictureBox> playerPieces, PictureBox[] spaces, PropertyList propertyList, Gameboard gameboard)
        {
            int pos = 0;
            int DrawnCard = 0;
            List<Action> chestCards = new List<Action> { AdvToGO, BankError, DrFee, StockSale, FreeJailEscape, GoToJail, HolodayFund, TaxRefund, InsuranceMatures, HospitalFee, SchoolFee, Consultancy, StreetRepair, BeautyContest, Inherit };

            DrawnCard = RandomNumberGenerator.GetInt32(14);
            Action ResolveCard = chestCards[DrawnCard];
            ResolveCard();



            //chest cards
            void AdvToGO()
            {
                MessageBox.Show("Advance to Go (Collect $200)");
                pos = 40;
                if (currentPlayer.getBoardPosition() > pos)
                    {
                    pos += 40;
                    }

                gameplay.movePiece(currentPlayer, pos - currentPlayer.getBoardPosition(), playerPieces, spaces, propertyList, gameboard, 1);
            }

            void BankError()
            {
                MessageBox.Show("Bank error in your favor. Collect $200");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
            }

            void DrFee()
            {
                MessageBox.Show("Doctor’s fee. Pay $50");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 50);
            }

            void StockSale()
            {
                MessageBox.Show("From sale of stock you get $50");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 50);
            }

            void FreeJailEscape()
            {
                MessageBox.Show("Get Out of Jail Free Card");
                currentPlayer.setJailCardValue(true);
            }

            void GoToJail()
            {
                MessageBox.Show("Go to Jail. Go directly to jail, do not pass Go, do not collect $200");
                gameplay.goToJail(currentPlayer, playerPieces, spaces, gameboard);
            }

            void HolodayFund()
            {
                MessageBox.Show("Holiday fund matures. Receive $100");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 100);
            }

            void TaxRefund()
            {
                MessageBox.Show("Income tax refund. Collect $20");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 20);
            }

            void InsuranceMatures()
            {
                MessageBox.Show("Life insurance matures. Collect $100");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 100);
            }

            void HospitalFee()
            {
                MessageBox.Show("Pay hospital fees of $100");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 100);
            }

            void SchoolFee()
            {
                MessageBox.Show("Pay school fees of $50");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 50);
            }

            void Consultancy()
            {
                MessageBox.Show("Receive $25 consultancy fee");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 25);
            }

            void StreetRepair()
            {
                int totalHouse = 0;
                int totalHotel = 0;

                MessageBox.Show("You are assessed for street repair. $40 per house. $115 per hotel");

                foreach (Property property in currentPlayer.getProperties())
                {
                    if (property.getHouseCount() == 5)
                    {
                        totalHotel = totalHotel + 1;
                    }
                    else
                    {
                        totalHouse = totalHouse + property.getHouseCount();
                    }
                   
                }
                currentPlayer.setMoneyBalance((currentPlayer.getMoneyBalance() - (totalHouse * 40)) - (totalHotel * 115));
            }

            void BeautyContest()
            {
                MessageBox.Show("You have won second prize in a beauty contest. Collect $10");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 10);
            }

            void Inherit()
            {
                MessageBox.Show("You inherit $100");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 100);
            }

        }



        //chance cards
        public void DrawChanceCard(Player currentPlayer, Dictionary<Player, PictureBox> playerPieces, PictureBox[] spaces, PropertyList propertyList, Gameboard gameboard)
        {
            int pos = 0;
            int DrawnCard = 0;
            List<Action> chanceCards = new List<Action> { AdvToBoardwalk, AdvToGO, AdvToIllinosis, AdvToStCharles, AdvToNxtRailroad, AdvToNxtUtility, Dividend, FreeJailEscape, BackTrack, GoToJail, GeneralRepairs, SpeedTicket, AdvToReadingRailRoad, LoanMatures };

            DrawnCard = RandomNumberGenerator.GetInt32(13);

            Action ResolveCard = chanceCards[DrawnCard];
            ResolveCard();


            void AdvToBoardwalk()
            {
                MessageBox.Show("Advance to Boardwalk");

                pos = 39;
                if (currentPlayer.getBoardPosition() > pos)
                {
                    pos += 40;
                }

                gameplay.movePiece(currentPlayer, pos - currentPlayer.getBoardPosition(), playerPieces, spaces, propertyList, gameboard, 1);
            }

            void AdvToGO()
            {
                MessageBox.Show("Advance to Go (Collect $200)");

                pos = 40;
                if (currentPlayer.getBoardPosition() > pos)
                {
                    pos += 40;
                }

                gameplay.movePiece(currentPlayer, pos - currentPlayer.getBoardPosition(), playerPieces, spaces, propertyList, gameboard, 1);
            }

            void AdvToIllinosis()
            {
                MessageBox.Show("Advance to Illinois Avenue. If you pass Go, collect $200");

                pos = 24;
                if (currentPlayer.getBoardPosition() > pos)
                {
                    pos += 40;
                }

                gameplay.movePiece(currentPlayer, pos - currentPlayer.getBoardPosition(), playerPieces, spaces, propertyList, gameboard, 1);
            }

            void AdvToStCharles()
            {
                MessageBox.Show("Advance to St. Charles Place. If you pass Go, collect $200");

                pos = 11;
                if (currentPlayer.getBoardPosition() > pos)
                {
                    pos += 40;
                }

                gameplay.movePiece(currentPlayer, pos - currentPlayer.getBoardPosition(), playerPieces, spaces, propertyList, gameboard, 1);
            }

            void AdvToNxtRailroad()
            {
                MessageBox.Show("Advance to the nearest Railroad. If unowned, you may buy it from the Bank. \nIf owned, pay wonder twice the rental to which they are otherwise entitled");

                if (currentPlayer.getBoardPosition() < 5 || currentPlayer.getBoardPosition() > 35)
                {
                    pos = 5;
                }
                else if (currentPlayer.getBoardPosition() < 15)
                {
                    pos = 15; 
                }
                else if (currentPlayer.getBoardPosition() < 25)
                {
                    pos = 25;
                }
                else if (currentPlayer.getBoardPosition() < 35)
                {
                    pos = 35;
                }

                if (currentPlayer.getBoardPosition() > pos)
                {
                    pos += 40;
                }

                gameplay.movePiece(currentPlayer, pos - currentPlayer.getBoardPosition(), playerPieces, spaces, propertyList, gameboard, 2);
            }

            void AdvToNxtUtility()
            {
                MessageBox.Show("Advance to the nearest Utility. If unowned, you may buy it from the Bank. \nIf owned, throw dice and pay owner a total ten times amount thrown.");

                if (currentPlayer.getBoardPosition() < 12 || currentPlayer.getBoardPosition() > 28)
                {
                    pos = 12;
                }

                else if (currentPlayer.getBoardPosition() < 28)
                {
                    pos = 28;
                }


                if (currentPlayer.getBoardPosition() > pos)
                {
                    pos += 40;
                }

                gameplay.movePiece(currentPlayer, pos - currentPlayer.getBoardPosition(), playerPieces, spaces, propertyList, gameboard, 0);
            }

            void Dividend()
            {
                MessageBox.Show("Bank pays you dividend of $50");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 50);

            }

            void FreeJailEscape()
            {
                MessageBox.Show("Get Out of Jail Free Card");
                //need to know proper variable to check to give a get out of jail free card to
                currentPlayer.setJailCardValue(true);
            }

            void BackTrack()
            {
                MessageBox.Show("Go Back 3 Spaces");

                gameplay.movePiece(currentPlayer, currentPlayer.getBoardPosition() - (currentPlayer.getBoardPosition() + 3), playerPieces, spaces, propertyList, gameboard, 1);
            }

            void GoToJail()
            {
                MessageBox.Show("Go to Jail. Go directly to Jail, do not pass Go, do not collect $200");
                gameplay.goToJail(currentPlayer, playerPieces, spaces, gameboard);
            }


            void GeneralRepairs()
            {
                int totalHouse = 0;
                int totalHotel = 0;

                MessageBox.Show("Make general repairs on all your property. For each house pay $25. For each hotel pay $100");

                foreach (Property property in currentPlayer.getProperties())
                {
                    if (property.getHouseCount() == 5)
                    {
                        totalHotel = totalHotel + 1;
                    }
                    else
                    {
                        totalHouse = totalHouse + property.getHouseCount();
                    }

                }
                currentPlayer.setMoneyBalance((currentPlayer.getMoneyBalance() - (totalHouse * 25)) - (totalHotel * 100));
            }

            void SpeedTicket()
            {
                MessageBox.Show("Speeding fine $15");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 15);

            }

            void AdvToReadingRailRoad()
            {
                MessageBox.Show("Take a trip to Reading Railroad. If you pass Go, collect $200");

                pos = 5;
                if (currentPlayer.getBoardPosition() > pos)
                {
                    pos += 40;
                }

                gameplay.movePiece(currentPlayer, pos - currentPlayer.getBoardPosition(), playerPieces, spaces, propertyList, gameboard, 1);
            }


            void LoanMatures()
            {
                Console.WriteLine("LoanMatures ");
                MessageBox.Show("Your building loan matures. Collect $150");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 150);
            }

        }
    }
}


