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

            value = (((percentWin - 7.28) / (39.05 - 7.28)) * 30 * risk) + ((potSize / (/*potSize +*/costToPlay + 2)) * risk * 2) + (((double)ourPosition / (double)totalPlayers) * 10);

            return value;


        }

        public string preFlopDecision(double value, double costToPlay)
        {
            if (value < 21)
            {
                if (costToPlay == 0)
                {
                    return "Let's see a flop. (Check)\r\n\r";
                }
                else
                {
                    return "Fold\r\n\r";
                }
            }
            else if (value >= 24)
            {
                return "Raise\r\n\r";
            }
            else
            {
                return "A simple call will work here\r\n\r";
            }
        }

        public string postFlopDecision(Hand currentHand)
        {
            int value = currentHand.getHandValue();

            if (value == 0)
            {
                return "You only have a high card, check or fold to a raise\r\n\r";
            }
            if (value == 1)
            {
                return "You have a pair, call raises up to 1/4 of the pot\r\n\r";
            }
            if (value == 2)
            {
                return "Two pair is a strong hand, call any raise up to 1/3 of the pot. If there are no raises, raise 1/4 of the pot.\r\n\r";
            }
            if (value == 3)
            {
                return "Trips, raise up to 1/2 the pot. Play strong.\r\n\r";
            }
            if (value == 4)
            {
                return "Straight, bet hard against any large raises. Raise 1/2 the pot in early position.\r\n\r";
            }
            if (value == 5)
            {
                return "Flush, call all raises. Raise 1/2 the pot in early position.\r\n\r";
            }
            if (value == 6)
            {
                return "Full house, call all raises. Slow play your full house, you most likely have the nuts.\r\n\r";
            }
            if (value == 7)
            {
                return "You have a monster, encourage betting from other players. Do not raise too much to scare off action.\r\n\r";
            }
            if (value == 8)
            {
                return "You have a monster, encourage betting from other players. Do not raise too much to scare off action.\r\n\r";
            }
            else
            {
                return "You have the best hand in poker!!! Try to encourage action and bask in the glory of a hand that comes only a few times in a lifetime.\r\n\r";
            }
        }









    }
}
