using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void movePiece(Player currentPlayer, int total, Dictionary<Player, PictureBox> playerPieces, PictureBox[] spaces, PropertyList propertyList)
        {
            int previousBoardPosition = currentPlayer.getBoardPosition();
            int newBoardPosition = (currentPlayer.getBoardPosition() + 1) % spaces.Length;
            currentPlayer.setBoardPosition(newBoardPosition);

            PictureBox pieceToMove = playerPieces[currentPlayer];
            PictureBox currentSpace = spaces[newBoardPosition];

            int targetX = (currentSpace.Width - pieceToMove.Width) / 2;
            int targetY = (currentSpace.Height - pieceToMove.Height) / 2;

            pieceToMove.Location = new System.Drawing.Point(targetX, targetY);
            currentSpace.Controls.Add(pieceToMove);
            //income tax
            if(newBoardPosition == 4)
            {
                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 200);
                MessageBox.Show("You paid $200 in income tax.");
            }
            //luxury tax
            if (newBoardPosition == 38)
            {
                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - 100);
                MessageBox.Show("You paid $200 in luxury tax.");
            }
            //Comunity Chest
            if (newBoardPosition == 2 || newBoardPosition ==  17 || newBoardPosition == 33) 
            {
                //call comunity chest method here
            }
            //Chance Card
            if (newBoardPosition == 7 || newBoardPosition == 22 || newBoardPosition == 36)
            {
                //call chance card method here
            }
            // Charge player rent if they land on square owned by other players
            if (propertyList.getProperties().TryGetValue(newBoardPosition, out Property currentProperty))
            {
                if (currentProperty.getOwner() != null)
                {
                    if(currentProperty.getOwner().getPiece() != currentPlayer.getPiece())    
                    {
                        if (currentProperty.getRent(total) < currentPlayer.getMoneyBalance())
                        {
                            int rentDue = currentProperty.getRent(total);
                            currentProperty.getOwner().setMoneyBalance(currentProperty.getOwner().getMoneyBalance() + rentDue);
                            currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - rentDue);
                            MessageBox.Show("You paid " + currentProperty.getOwner().getName() + " $" + currentProperty.getRent(total) + " for rent.");
                        }
                        else
                        {
                            // add bankrupcy logic here
                        }
                    }
                }
            }


            // pay player for passing go
            if (previousBoardPosition > newBoardPosition)
            {
                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
            }
        }
    }
}
