using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
   public class Winning
    {
        public int findWinner(int playr,int Budget,int bet, int winngBike , int bike) {
            if (playr == 1 && winngBike == bike)
            {
                return Budget += bet;
            }
            else {
                return Budget -= bet;
            }

        }
    }
}
