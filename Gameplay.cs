using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            int newBoardPosition = (currentPlayer.getBoardPosition() + total) % spaces.Length;
            currentPlayer.setBoardPosition(newBoardPosition);

            PictureBox pieceToMove = playerPieces[currentPlayer];
            PictureBox currentSpace = spaces[newBoardPosition];

            int targetX = (currentSpace.Width - pieceToMove.Width) / 2;
            int targetY = (currentSpace.Height - pieceToMove.Height) / 2;

            pieceToMove.Location = new System.Drawing.Point(targetX, targetY);
            currentSpace.Controls.Add(pieceToMove);

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
