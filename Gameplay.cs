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

        public void movePiece(Player currentPlayer, int total, Dictionary<Player, PictureBox> playerPieces, PictureBox[] spaces)
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

            if (previousBoardPosition > newBoardPosition)
            {
                currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() + 200);
            }
        }
    }
}
