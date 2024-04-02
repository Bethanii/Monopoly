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
    }
}
