using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Coach
{
    public class Coach
    {
        private int risk;

        private double[] postFlopPercent;
        private double[] postFlopOdds;
        private double[] postTurnPercent;
        private double[] postTurnOdds;

        public Coach(int ourRisk)
        {
            risk = ourRisk;

            postFlopPercent = new double[21];
            postFlopOdds = new double[21];
            postTurnPercent = new double[21];
            postTurnOdds = new double[21];

            postFlopPercent[0] = 0;
            postFlopPercent[1] = 4.3;
            postFlopPercent[2] = 8.4;
            postFlopPercent[3] = 12.5;
            postFlopPercent[4] = 16.5;
            postFlopPercent[5] = 20.3;
            postFlopPercent[6] = 24.1;
            postFlopPercent[7] = 27.8;
            postFlopPercent[8] = 31.5;
            postFlopPercent[9] = 35.0;
            postFlopPercent[10] = 38.4;
            postFlopPercent[11] = 41.7;
            postFlopPercent[12] = 45.0;
            postFlopPercent[13] = 48.1;
            postFlopPercent[14] = 51.2;
            postFlopPercent[15] = 54.1;
            postFlopPercent[16] = 57.0;
            postFlopPercent[17] = 59.8;
            postFlopPercent[18] = 62.4;
            postFlopPercent[19] = 65.0;
            postFlopPercent[20] = 67.5;

            postFlopOdds[0] = 0;
            postFlopOdds[1] = 22.26;
            postFlopOdds[2] = 10.90;
            postFlopOdds[3] = 7.00;
            postFlopOdds[4] = 5.06;
            postFlopOdds[5] = 3.93;
            postFlopOdds[6] = 3.15;
            postFlopOdds[7] = 2.60;
            postFlopOdds[8] = 2.17;
            postFlopOdds[9] = 1.86;
            postFlopOdds[10] = 1.60;
            postFlopOdds[11] = 1.40;
            postFlopOdds[12] = 1.22;
            postFlopOdds[13] = 1.08;
            postFlopOdds[14] = 0.95;
            postFlopOdds[15] = 0.85;
            postFlopOdds[16] = 0.75;
            postFlopOdds[17] = 0.67;
            postFlopOdds[18] = 0.60;
            postFlopOdds[19] = 0.54;
            postFlopOdds[20] = 0.48;

            postTurnPercent[0] = 0;
            postTurnPercent[1] = 2.2;
            postTurnPercent[2] = 4.3;
            postTurnPercent[3] = 6.5;
            postTurnPercent[4] = 8.7;
            postTurnPercent[5] = 10.9;
            postTurnPercent[6] = 13.0;
            postTurnPercent[7] = 15.2;
            postTurnPercent[8] = 17.4;
            postTurnPercent[9] = 19.6;
            postTurnPercent[10] = 21.7;
            postTurnPercent[11] = 23.9;
            postTurnPercent[12] = 26.1;
            postTurnPercent[13] = 28.3;
            postTurnPercent[14] = 30.4;
            postTurnPercent[15] = 32.6;
            postTurnPercent[16] = 34.8;
            postTurnPercent[17] = 37.0;
            postTurnPercent[18] = 39.1;
            postTurnPercent[19] = 41.3;
            postTurnPercent[20] = 43.5;

            postTurnOdds[0] = 0;
            postTurnOdds[1] = 45.00;
            postTurnOdds[2] = 22.00;
            postTurnOdds[3] = 14.33;
            postTurnOdds[4] = 10.50;
            postTurnOdds[5] = 8.20;
            postTurnOdds[6] = 6.67;
            postTurnOdds[7] = 5.57;
            postTurnOdds[8] = 4.75;
            postTurnOdds[9] = 4.11;
            postTurnOdds[10] = 3.60;
            postTurnOdds[11] = 3.18;
            postTurnOdds[12] = 2.83;
            postTurnOdds[13] = 2.54;
            postTurnOdds[14] = 2.29;
            postTurnOdds[15] = 2.07;
            postTurnOdds[16] = 1.88;
            postTurnOdds[17] = 1.71;
            postTurnOdds[18] = 1.56;
            postTurnOdds[19] = 1.42;
            postTurnOdds[20] = 1.30;
        }

        public double drawingDecisionPostFlopPercent(int outs)
        {
            return postFlopPercent[outs];
        }

        public double drawingDecisionPostFlopOdds(int outs)
        {
            return postFlopOdds[outs];
        }

        public double drawingDecisionPostTurnPercent(int outs)
        {
            return postTurnPercent[outs];
        }

        public double drawingDecisionPostTurnOdds(int outs)
        {
            return postTurnOdds[outs];
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

        public string postFlopDecision(Hand currentHand, double potSize, double costToPlay, double stackSize)
        {
            int value = currentHand.getHandValue();
            int totalOuts = currentHand.getTotalOuts();
            double potOdds = potSize / costToPlay;
            double postFlopOdds = drawingDecisionPostFlopOdds(totalOuts);
            string decision = "";

            if ((potOdds - postFlopOdds) > 0.5 && !(costToPlay >= stackSize) && postFlopOdds > 0)
            {
                decision += "Since your odds are " + postFlopOdds + " to 1, and the pot odds are " + potOdds + " to 1, this is an automatic call if someone raised in front of you.\r\n";
                decision += "Other advice: " + afterPotOddsDecision(value) + "\r\n";

                return decision;
            }

            return generalDecision(value);
        }

        public string postTurnDecision(Hand currentHand, double potSize, double costToPlay, double stackSize)
        {
            int value = currentHand.getHandValue();
            int totalOuts = currentHand.getTotalOuts();
            double potOdds = potSize / costToPlay;
            double postTurnOdds = drawingDecisionPostTurnOdds(totalOuts);
            string decision = "";

            if ((potOdds - postTurnOdds) > 0.5 && !(costToPlay >= stackSize) && postTurnOdds > 0)
            {
                decision += "Since your odds are " + postTurnOdds + " to 1, and the pot odds are " + potOdds + " to 1, this is an automatic call if someone in front of you.\r\n\r\n";
                decision += "Other advice: " + afterPotOddsDecision(value) + "\r\n";

                return decision;
            }

            return generalDecision(value);
        }

        public string postRiverDecision(Hand currentHand, double potSize, double costToPlay, double stackSize)
        {
            int value = currentHand.getHandValue();
            int totalOuts = currentHand.getTotalOuts();
            double potOdds = potSize / costToPlay;
            double postTurnOdds = drawingDecisionPostTurnOdds(totalOuts);
            string decision = "";

            if ((potOdds - postTurnOdds) > 0.5 && !(costToPlay >= stackSize) && postTurnOdds > 0)
            {
                decision += "Since your odds are " + postTurnOdds + " to 1, and the pot odds are " + potOdds + " to 1, this is an automatic call if somone in front of you.\r\n\r\n";
                decision += "Other advice: " + afterPotOddsDecision(value) + "\r\n";
            }

            return generalDecision(value);
        }

        public string afterPotOddsDecision(int value)
        {
            if (value == 0)
            {
                return "If no raises, check here.\r\n\r";
            }
            if (value == 1)
            {
                return "If no raises, raise with top pair or over pair, check with other pairs.\r\n\r";
            }
            if (value == 2)
            {
                return "If no raises, two pair is a strong hand, raise 1/4 of the pot.\r\n\r";
            }
            if (value == 3)
            {
                return "If no raises, with trips, raise up to 1/2 the pot. Play strong.\r\n\r";
            }
            if (value == 4)
            {
                return "If no raises, with a straight, bet hard against any large raises. Raise 1/2 the pot in early position.\r\n\r";
            }
            if (value == 5)
            {
                return "If no raises, with a flush, raise 1/2 the pot in early position.\r\n\r";
            }
            if (value == 6)
            {
                return "If no raises, with a full house, slow play your full house because you most likely have the nuts.\r\n\r";
            }
            if (value == 7)
            {
                return "If no raises, you have a monster, encourage betting from other players. Do not raise too much to scare off action.\r\n\r";
            }
            if (value == 8)
            {
                return "If no raises, you have a monster, encourage betting from other players. Do not raise too much to scare off action.\r\n\r";
            }
            else
            {
                return "If no raises, try to encourage action and bask in the glory of a hand that comes only a few times in a lifetime.\r\n\r";
            }
        }

        public string generalDecision(int value)
        {
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
