using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

        public void movePiece(Player currentPlayer, int total, Dictionary<Player, PictureBox> playerPieces, PictureBox[] spaces, PropertyList propertyList, Gameboard gameboard)
        {
            int previousBoardPosition = currentPlayer.getBoardPosition();
            int newBoardPosition = (currentPlayer.getBoardPosition() + total) % spaces.Length;
            currentPlayer.setBoardPosition(newBoardPosition);

            PictureBox pieceToMove = playerPieces[currentPlayer];
            PictureBox currentSpace = spaces[newBoardPosition];

            int targetX = (currentSpace.Width - pieceToMove.Width) / 2;
            int targetY = (currentSpace.Height - pieceToMove.Height) / 2;

            pieceToMove.Location = new System.Drawing.Point(targetX, targetY);
            currentSpace.Controls.Add(pieceToMove);
            //income tax
            if (newBoardPosition == 4)
            {
                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 200);
                MessageBox.Show("You paid $200 in income tax.");
            }
            //luxury tax
            if (newBoardPosition == 38)
            {
                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 100);
                MessageBox.Show("You paid $100 in luxury tax.");
            }
            //Go to jail
            if (newBoardPosition == 30)
            {
                goToJail(currentPlayer, playerPieces, spaces,gameboard);
            }
            // Charge player rent if they land on square owned by other players
            if (propertyList.getProperties().TryGetValue(newBoardPosition, out Property currentProperty))
            {
                if (currentProperty.getOwner() != null)
                {
                    if (currentProperty.getOwner().getPiece() != currentPlayer.getPiece())
                    {

                        int rentDue = currentProperty.getRent(total);
                        currentProperty.getOwner().setMoneyBalance(currentProperty.getOwner().getMoneyBalance() + rentDue);
                        currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - rentDue);
                        MessageBox.Show("You paid " + currentProperty.getOwner().getName() + " $" + currentProperty.getRent(total) + " for rent.");
                    }
                }
            }
            // pay player for passing go
            if (previousBoardPosition > newBoardPosition)
            {
                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
            }
            Cards cards = new Cards();
            //if lands on chest space
            if (currentPlayer.getBoardPosition() == 2 || currentPlayer.getBoardPosition() == 17 || currentPlayer.getBoardPosition() == 33)
            {
                cards.DrawChestCard(currentPlayer, playerPieces, spaces, propertyList, gameboard);
            }

            //if lands on chance space
            if (currentPlayer.getBoardPosition() == 7 || currentPlayer.getBoardPosition() == 22 || currentPlayer.getBoardPosition() == 36)
            {
                Console.WriteLine("chance");
                cards.DrawChanceCard(currentPlayer, playerPieces, spaces, propertyList, gameboard);
            }
            gameboard.balanceTextBox.Text = "$" + currentPlayer.getMoneyBalance();

        }
        public void goToJail(Player currentPlayer, Dictionary<Player, PictureBox> playerPieces, PictureBox[] spaces, Gameboard gameboard)
        {
            gameboard.doublesCount = 0;
            MessageBox.Show("Go to Jail!");

            int newBoardPosition = (10) % spaces.Length;
            currentPlayer.setBoardPosition(newBoardPosition);

            PictureBox pieceToMove = playerPieces[currentPlayer];
            PictureBox currentSpace = spaces[newBoardPosition];

            int targetX = (currentSpace.Width - pieceToMove.Width) / 2;
            int targetY = (currentSpace.Height - pieceToMove.Height) / 2;

            pieceToMove.Location = new System.Drawing.Point(targetX, targetY);
            currentSpace.Controls.Add(pieceToMove);

            currentPlayer.setInJailCounter(3);
        }

        public void jailCounter(Player currentPlayer, int dice1, int dice2, Gameboard gameBoard, Dictionary<Player, PictureBox> playerPieces, PictureBox[] spaces, PropertyList propertyList)
        {
            gameBoard.rollCount = 1;

            if (dice1 == dice2)
            {
                MessageBox.Show("Congradulations you rolled doubles and escaped from jail.");
                (dice1, dice2, int total) = getDiceRollCount();

                gameBoard.diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
                gameBoard.diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");

                currentPlayer.setInJailCounter(0);
                movePiece(currentPlayer, total, playerPieces, spaces, propertyList, gameBoard);
            }
            else
            {
                currentPlayer.setInJailCounter(currentPlayer.getInJailCounter() - 1);

                if (currentPlayer.getInJailCounter() > 1)
                {
                    MessageBox.Show("You still have " + currentPlayer.getInJailCounter() + " turns left in jail.");
                }
                else if (currentPlayer.getInJailCounter() == 1)
                {
                    MessageBox.Show("You still have " + currentPlayer.getInJailCounter() + " turn left in jail.");
                }
                else
                {
                    MessageBox.Show("This is your last turn in jail.");
                }
            }
        }
    }
}
