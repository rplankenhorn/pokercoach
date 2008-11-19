using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Poker_Coach
{
    class RiverOdds
    {
        public Hand determineBestHand(List<Card> holecards, List<Card> community)
        {
            Debug.Assert(holecards.Count == 2);
            Debug.Assert(community.Count == 5);

            TurnOdds trnodds = new TurnOdds();

            Hand h1, h2, h3, h4, h5, h6, h7;

            List<Card> hole1 = new List<Card>(holecards);
            List<Card> com1 = new List<Card>(community);
            com1.RemoveAt(4);

            List<Card> hole2 = new List<Card>(holecards);
            List<Card> com2 = new List<Card>(community);
            com2.RemoveAt(3);

            List<Card> hole3 = new List<Card>(holecards);
            List<Card> com3 = new List<Card>(community);
            com3.RemoveAt(2);

            List<Card> hole4 = new List<Card>(holecards);
            List<Card> com4 = new List<Card>(community);
            com4.RemoveAt(1);

            List<Card> hole5 = new List<Card>(holecards);
            List<Card> com5 = new List<Card>(community);
            com5.RemoveAt(0);

            List<Card> hole6 = new List<Card>();
            List<Card> com6 = new List<Card>();
            hole6.Add(holecards[0]);
            hole6.Add(community[0]);
            com6.Add(community[1]);
            com6.Add(community[2]);
            com6.Add(community[3]);
            com6.Add(community[4]);

            List<Card> hole7 = new List<Card>();
            List<Card> com7 = new List<Card>();
            hole7.Add(holecards[1]);
            hole7.Add(community[0]);
            com7.Add(community[1]);
            com7.Add(community[2]);
            com7.Add(community[3]);
            com7.Add(community[4]);

            h1 = trnodds.determineBestHand(hole1, com1);
            h2 = trnodds.determineBestHand(hole2, com2);
            h3 = trnodds.determineBestHand(hole3, com3);
            h4 = trnodds.determineBestHand(hole4, com4);
            h5 = trnodds.determineBestHand(hole5, com5);
            h6 = trnodds.determineBestHand(hole6, com6);
            h7 = trnodds.determineBestHand(hole7, com7);

            Hand best = h1;

            if (best.getHandValue() < h2.getHandValue())
            {
                best = h2;
            }
            else if (best.getHandValue() == h2.getHandValue())
            {
                if (best.getHighestCardValue() < h2.getHighestCardValue())
                {
                    best = h2;
                }
                else if (best.getHighestCardValue() == h2.getHighestCardValue() && best.getHandValue() < 4)
                {
                    if (best.getKickerValue() < h2.getKickerValue())
                    {
                        best = h2;
                    }
                }
            }

            if (best.getHandValue() < h3.getHandValue())
            {
                best = h3;
            }
            else if (best.getHandValue() == h3.getHandValue())
            {
                if (best.getHighestCardValue() < h3.getHighestCardValue())
                {
                    best = h3;
                }
                else if (best.getHighestCardValue() == h3.getHighestCardValue() && best.getHandValue() < 4)
                {
                    if (best.getKickerValue() < h3.getKickerValue())
                    {
                        best = h3;
                    }
                }
            }

            if (best.getHandValue() < h4.getHandValue())
            {
                best = h4;
            }
            else if (best.getHandValue() == h4.getHandValue())
            {
                if (best.getHighestCardValue() < h4.getHighestCardValue())
                {
                    best = h4;
                }
                else if (best.getHighestCardValue() == h4.getHighestCardValue() && best.getHandValue() < 4)
                {
                    if (best.getKickerValue() < h4.getKickerValue())
                    {
                        best = h4;
                    }
                }
            }

            if (best.getHandValue() < h5.getHandValue())
            {
                best = h5;
            }
            else if (best.getHandValue() == h5.getHandValue())
            {
                if (best.getHighestCardValue() < h5.getHighestCardValue())
                {
                    best = h5;
                }
                else if (best.getHighestCardValue() == h5.getHighestCardValue() && best.getHandValue() < 4)
                {
                    if (best.getKickerValue() < h5.getKickerValue())
                    {
                        best = h5;
                    }
                }
            }

            if (best.getHandValue() < h6.getHandValue())
            {
                best = h6;
            }
            else if (best.getHandValue() == h6.getHandValue())
            {
                if (best.getHighestCardValue() < h6.getHighestCardValue())
                {
                    best = h6;
                }
                else if (best.getHighestCardValue() == h6.getHighestCardValue() && best.getHandValue() < 4)
                {
                    if (best.getKickerValue() < h6.getKickerValue())
                    {
                        best = h6;
                    }
                }
            }

            if (best.getHandValue() < h7.getHandValue())
            {
                best = h7;
            }
            else if (best.getHandValue() == h7.getHandValue())
            {
                if (best.getHighestCardValue() < h7.getHighestCardValue())
                {
                    best = h7;
                }
                else if (best.getHighestCardValue() == h7.getHighestCardValue() && best.getHandValue() < 4)
                {
                    if (best.getKickerValue() < h7.getKickerValue())
                    {
                        best = h7;
                    }
                }
            }

            return best;
        }
    }
}
