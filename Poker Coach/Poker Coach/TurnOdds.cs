using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Poker_Coach
{
    class TurnOdds
    {
        /**
         * Console for debugging
         */ 
        [DllImport("kernel32")]
        static extern bool AllocConsole();

        public Hand determineBestHand(List<Card> holecards, List<Card> community)
        {
            /**
             * Show Debug console
             */ 
            //AllocConsole();

            Debug.Assert(community.Count == 4);
            Debug.Assert(holecards.Count == 2);

            FlopOdds flp = new FlopOdds();

            Hand h1, h2, h3, h4, h5, h6;

            List<Card> hole1 = new List<Card>(holecards);
            List<Card> com1 = new List<Card>();
            com1.Add(community[0]);
            com1.Add(community[1]);
            com1.Add(community[2]);

            List<Card> hole2 = new List<Card>(holecards);
            List<Card> com2 = new List<Card>(community);
            com2.RemoveAt(2);

            List<Card> hole3 = new List<Card>(holecards);
            List<Card> com3 = new List<Card>(community);
            com3.RemoveAt(1);

            List<Card> hole4 = new List<Card>(holecards);
            List<Card> com4 = new List<Card>(community);
            com4.RemoveAt(0);

            List<Card> hole5 = new List<Card>();
            List<Card> com5 = new List<Card>();
            hole5.Add(holecards[0]);
            hole5.Add(community[0]);
            com5.Add(community[1]);
            com5.Add(community[2]);
            com5.Add(community[3]);

            List<Card> hole6 = new List<Card>();
            List<Card> com6 = new List<Card>();
            hole6.Add(holecards[1]);
            hole6.Add(community[0]);
            com6.Add(community[1]);
            com6.Add(community[2]);
            com6.Add(community[3]);

            Debug.Assert(hole1.Count == 2);
            Debug.Assert(com1.Count == 3);

            Debug.Assert(hole2.Count == 2);
            Debug.Assert(com2.Count == 3);

            Debug.Assert(hole3.Count == 2);
            Debug.Assert(com3.Count == 3);

            Debug.Assert(hole4.Count == 2);
            Debug.Assert(com4.Count == 3);

            Debug.Assert(hole5.Count == 2);
            Debug.Assert(com5.Count == 3);

            Debug.Assert(hole6.Count == 2);
            Debug.Assert(com6.Count == 3);

            h1 = flp.determineStraightFlush(hole1, com1);

            if (!h1.getFlush() && !h1.getStraight() && !h1.getRoyalFlush())
            {
                h1 = flp.determinePair(hole1, com1);
            }

            h2 = flp.determineStraightFlush(hole2, com2);

            if (!h2.getFlush() && !h2.getStraight() && !h2.getRoyalFlush())
            {
                h2 = flp.determinePair(hole1, com1);
            }

            h3 = flp.determineStraightFlush(hole3, com3);

            if (!h3.getFlush() && !h3.getStraight() && !h3.getRoyalFlush())
            {
                h3 = flp.determinePair(hole1, com1);
            }

            h4 = flp.determineStraightFlush(hole4, com4);

            if (!h4.getFlush() && !h4.getStraight() && !h4.getRoyalFlush())
            {
                h4 = flp.determinePair(hole1, com1);
            }

            h5 = flp.determineStraightFlush(hole5, com5);

            if (!h5.getFlush() && !h5.getStraight() && !h5.getRoyalFlush())
            {
                h1 = flp.determinePair(hole1, com1);
            }

            h6 = flp.determineStraightFlush(hole6, com6);

            if (!h6.getFlush() && !h6.getStraight() && !h6.getRoyalFlush())
            {
                h6 = flp.determinePair(hole1, com1);
            }

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
                best = h5;
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

            return best;
        }
    }
}
