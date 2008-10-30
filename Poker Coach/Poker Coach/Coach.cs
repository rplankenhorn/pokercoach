using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Coach
{
    public class Coach
    {
        private int risk;


        public Coach(int ourRisk)
        {
            risk = ourRisk;
        }

        public double preFlopCalc(double percentWin, double ourStack, double potSize, int ourPosition, double costToPlay, int totalPlayers)
        {
            double value;

            value = (((percentWin - 7.28) / (39.05 - 7.28)) * 30 * risk) + ((potSize / (/*potSize +*/costToPlay + 1)) * risk * 2) + (((double)ourPosition / (double)totalPlayers) * 4);

            return value;


        }

        public string preFlopDecision(double value, double costToPlay)
        {
            if (value < 21)
            {
                if (costToPlay == 0)
                {
                    return "Let's see a flop. (Check)\r\n";
                }
                else
                {
                    return "Fold that garbage\r\n";
                }
            }
            else if (value >= 24)
            {
                return "Raise\r\n";
            }
            else
            {
                return "A simple call will work here\r\n";
            }
        }




    }
}
