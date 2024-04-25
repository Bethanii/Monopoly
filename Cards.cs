using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MonopolyGame
{
    public class Cards
    {



            public void DrawChestCard(Player currentPlayer)
            {

                int DrawnCard = 0;
                List<Action> chestCards = new List<Action> { AdvToGO, BankError, DrFee, StockSale, FreeJailEscape, GoToJail, HolodayFund, TaxRefund, InsuranceMatures, HospitalFee, SchoolFee, Consultancy, StreetRepair, BeautyContest, Inherit };

                DrawnCard = RandomNumberGenerator.GetInt32(14);
                Action ResolveCard = chestCards[DrawnCard];
                ResolveCard();



            //chest cards
                void AdvToGO()
                {
                    
                    //need way to move Icon

                    MessageBox.Show("Advance to Go (Collect $200)");
                    currentPlayer.setBoardPosition(0);
                    currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);

              

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
                    //need to know proper variable to check to give a get out of jail free card to
                    MessageBox.Show("Get Out of Jail Free Card");  
            }

                void GoToJail()
                {
                    //need to know the proper method to set player in jail
                    MessageBox.Show("Go to Jail. Go directly to jail, do not pass Go, do not collect $200");
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
                    //need to find hotel count
                    int totalHouse = 0;
                    int totalHotel = 0;

                    MessageBox.Show("You are assessed for street repair. $40 per house. $115 per hotel");

                    foreach (Property property in currentPlayer.getProperties())
                    {
                        totalHouse = totalHouse + property.getHouseCount();
                    }
                    currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - (totalHouse * 40));
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
        public void DrawChanceCard(Player currentPlayer)
        {

            int DrawnCard = 0;
            List<Action> chanceCards = new List<Action> { AdvToBoardwalk, AdvToGO, AdvToIllinosis, AdvToStCharles, AdvToNxtRailroad, AdvToNxtUtility, Dividend, FreeJailEscape, BackTrack, GoToJail, GeneralRepairs, SpeedTicket, AdvToReadingRailRoad, LoanMatures };

            DrawnCard = RandomNumberGenerator.GetInt32(13);

            Action ResolveCard = chanceCards[DrawnCard];
            ResolveCard();


            void AdvToBoardwalk()
            {
                MessageBox.Show("Advance to Boardwalk");
                //need way to move icon

                if (currentPlayer.getBoardPosition() > 39)
                {
                    currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
                }
                currentPlayer.setBoardPosition(39);
            }

            void AdvToGO()
            {
                MessageBox.Show("Advance to Go (Collect $200)");
                //need way to move icon
                currentPlayer.setBoardPosition(0);
                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
            }

            void AdvToIllinosis()
            {
                MessageBox.Show("Advance to Illinois Avenue. If you pass Go, collect $200");
                //need way to move icon


                if (currentPlayer.getBoardPosition() > 24)
                {
                    currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
                }
                currentPlayer.setBoardPosition(24);
            }

            void AdvToStCharles()
            {
                MessageBox.Show("Advance to St. Charles Place. If you pass Go, collect $200");
                //need way to move icon


                if (currentPlayer.getBoardPosition() > 11)
                {
                    currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
                }
                currentPlayer.setBoardPosition(11);
            }

            void AdvToNxtRailroad()
            {
                MessageBox.Show("Advance to the nearest Railroad. If unowned, you may buy it from the Bank. \nIf owned, pay wonder twice the rental to which they are otherwise entitled");
                //need way to move icon and buy

                if (currentPlayer.getBoardPosition() < 5)
                {
                    currentPlayer.setBoardPosition(5);
                }

                else if (currentPlayer.getBoardPosition() < 15)
                {
                    currentPlayer.setBoardPosition(15);
                }

                else if (currentPlayer.getBoardPosition() < 25)
                {
                    currentPlayer.setBoardPosition(25);
                }

                else if (currentPlayer.getBoardPosition() < 35)
                {
                    currentPlayer.setBoardPosition(35);
                }

                else
                {
                    currentPlayer.setBoardPosition(5);
                    currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
                }
            }

                void AdvToNxtUtility()
                {
                MessageBox.Show("Advance to the nearest Utility. If unowned, you may buy it from the Bank. \nIf owned, throw dice and pay owner a total ten times amount thrown.");
                //need way to move icon and buy

                int TotalRoll = 0;
                    TotalRoll += RandomNumberGenerator.GetInt32(5) + 1;
                    TotalRoll += RandomNumberGenerator.GetInt32(5) + 1;


                    if (currentPlayer.getBoardPosition() < 12)
                    {
                        currentPlayer.setBoardPosition(12);
                    }

                    else if (currentPlayer.getBoardPosition() < 28)
                    {
                        currentPlayer.setBoardPosition(28);
                    }

                    else
                    {
                        currentPlayer.setBoardPosition(12);
                        currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
                }

                    currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - (TotalRoll * 10));

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
            }

                void BackTrack()
                {
                MessageBox.Show("Go Back 3 Spaces");
                //need way to move icon
                currentPlayer.setBoardPosition(currentPlayer.getBoardPosition() - 3);
                }

                void GoToJail()
                {
                MessageBox.Show("Go to Jail. Go directly to Jail, do not pass Go, do not collect $200");
                //need to know the proper methods to call to move player position
            }


                void GeneralRepairs()
                {
                    //need to find hotel count
                    int totalHouse = 0;
                    int totalHotel = 0;

                MessageBox.Show("Make general repairs on all your property. For each house pay $25. For each hotel pay $100");

                foreach (Property property in currentPlayer.getProperties())
                    {
                        totalHouse = totalHouse + property.getHouseCount();
                    }
                    currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - (totalHouse * 25));
                }

                void SpeedTicket()
                {
                MessageBox.Show("Speeding fine $15");

                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 15);

                }

                void AdvToReadingRailRoad()
                {
                MessageBox.Show("Take a trip to Reading Railroad. If you pass Go, collect $200");
                //need way to move Icon

                if (currentPlayer.getBoardPosition() > 5)
                    {
                        currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
                    }
                currentPlayer.setBoardPosition(5);
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


