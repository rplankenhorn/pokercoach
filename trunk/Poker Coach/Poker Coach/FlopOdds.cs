using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * For Hand Value attribute:
 * High Card = 0;
 * Pair = 1;
 * Twopair = 2;
 * Trips = 3;
 * Straight = 4;
 * Flush = 5;
 * Fullhouse = 6;
 * Quads = 7;
 * Straight Flush = 8;
 * Royal Flush = 9;
 */ 

namespace Poker_Coach
{
    class FlopOdds
    {
        /**
         * Determines if there is a pair made on the flop.  Includes if there was a pair
         * made not including the holecards.
         * 
         */
        public Hand determinePair(List<Card> holecards, List<Card> community)
        {
            List<Card> sorted = sortHoleAndCommunity(holecards, community);
            Hand r = new Hand(sorted);

            /**
             * Since the list is sorted, there are only two possible full house configurations.
             * AAAAX, X2222
             */
            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[1].getValueInt() == sorted[2].getValueInt()
                && sorted[2].getValueInt() == sorted[3].getValueInt())
            {
                r.setQuads(true);
                r.setHighestCardIndex(0);
                r.setHandValue(7);
                return r;
            }

            if (sorted[1].getValueInt() == sorted[2].getValueInt() && sorted[2].getValueInt() == sorted[3].getValueInt()
                && sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                r.setQuads(true);
                r.setHighestCardIndex(1);
                r.setHandValue(7);
                return r;
            }

            /**
             * Since the list is sorted, there are only two possible full house configurations.
             */ 

            /**
             * Example: AAAKK
             */ 
            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[0].getValueInt() == sorted[2].getValueInt()
                && sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                r.setFullHouse(true);
                r.setHighestCardIndex(0);
                r.setHandValue(6);
                return r;
            }

            /**
             * Example: KK222
             */ 
            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[2].getValueInt() == sorted[3].getValueInt()
                && sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                r.setFullHouse(true);
                r.setHighestCardIndex(2);
                r.setHandValue(6);
                return r;
            }

            /**
             * Again, since it is sorted, only 3 possible trip configurations.
             * AAAXY, XJJJY, XY222.
             */

            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[0].getValueInt() == sorted[2].getValueInt()
                && sorted[3].getValueInt() != sorted[4].getValueInt())
            {
                if (sorted[3].getValueInt() == 1)
                {
                    r.setTrips(true);
                    r.setKicker(3);
                    r.setHighestCardIndex(0);
                    r.setHandValue(3);
                    return r;
                }
                else if (sorted[4].getValueInt() == 1)
                {
                    r.setTrips(true);
                    r.setKicker(4);
                    r.setHighestCardIndex(0);
                    r.setHandValue(3);
                    return r;
                }
                else if (sorted[3].getValueInt() > sorted[4].getValueInt())
                {
                    r.setTrips(true);
                    r.setKicker(3);
                    r.setHighestCardIndex(0);
                    r.setHandValue(3);
                    return r;
                }
                else
                {
                    r.setTrips(true);
                    r.setKicker(4);
                    r.setHighestCardIndex(0);
                    r.setHandValue(3);
                    return r;
                }
            }

            if (sorted[1].getValueInt() == sorted[2].getValueInt() && sorted[1].getValueInt() == sorted[3].getValueInt()
                && sorted[0].getValueInt() != sorted[4].getValueInt())
            {
                if (sorted[0].getValueInt() == 1)
                {
                    r.setTrips(true);
                    r.setKicker(3);
                    r.setHighestCardIndex(1);
                    r.setHandValue(3);
                    return r;
                }
                else if (sorted[4].getValueInt() == 1)
                {
                    r.setTrips(true);
                    r.setKicker(4);
                    r.setHighestCardIndex(1);
                    r.setHandValue(3);
                    return r;
                }
                else if (sorted[0].getValueInt() > sorted[4].getValueInt())
                {
                    r.setTrips(true);
                    r.setKicker(0);
                    r.setHighestCardIndex(1);
                    r.setHandValue(3);
                    return r;
                }
                else
                {
                    r.setTrips(true);
                    r.setKicker(4);
                    r.setHighestCardIndex(1);
                    r.setHandValue(3);
                    return r;
                }
            }

            if (sorted[2].getValueInt() == sorted[3].getValueInt() && sorted[2].getValueInt() == sorted[4].getValueInt()
                && sorted[0].getValueInt() != sorted[1].getValueInt())
            {
                if (sorted[0].getValueInt() == 1)
                {
                    r.setTrips(true);
                    r.setKicker(0);
                    r.setHighestCardIndex(2);
                    r.setHandValue(3);
                    return r;
                }
                else if (sorted[1].getValueInt() == 1)
                {
                    r.setTrips(true);
                    r.setKicker(1);
                    r.setHighestCardIndex(2);
                    r.setHandValue(3);
                    return r;
                }
                else if (sorted[0].getValueInt() > sorted[1].getValueInt())
                {
                    r.setTrips(true);
                    r.setKicker(0);
                    r.setHighestCardIndex(2);
                    r.setHandValue(3);
                    return r;
                }
                else
                {
                    r.setTrips(true);
                    r.setKicker(1);
                    r.setHighestCardIndex(2);
                    r.setHandValue(3);
                    return r;
                }
            }

            /**
             * Only three possible two pair configurations
             * XXYYZ, ZXXYY, XXZYY
             */

            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[2].getValueInt() == sorted[3].getValueInt())
            {
                r.setTwoPair(true);
                r.setKicker(4);
                r.setHighestCardIndex(0);
                r.setHandValue(2);
                return r;
            }

            if (sorted[1].getValueInt() == sorted[2].getValueInt() && sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                r.setTwoPair(true);
                r.setKicker(0);

                if (sorted[3].getValueInt() == 1)
                {
                    r.setHighestCardIndex(3);
                }
                else
                {
                    r.setHighestCardIndex(1);
                }

                r.setHandValue(2);
                return r;
            }

            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                r.setTwoPair(true);
                r.setKicker(2);

                if (sorted[3].getValueInt() == 1)
                {
                    r.setHighestCardIndex(3);
                }
                else
                {
                    r.setHighestCardIndex(0);
                }

                r.setHandValue(2);
                return r;
            }

            /*
             * Again, since list is sorted, there are only four possible positions for pairs.
             * AAXYZ, XKKYZ, XYJJZ, XYZ22
             */
            if (sorted[0].getValueInt() == sorted[1].getValueInt())
            {
                List<Card> temp = new List<Card>(3);
                temp.Add(sorted[2]);
                temp.Add(sorted[3]);
                temp.Add(sorted[4]);

                r.setPair(true);
                r.setKicker(Card.maxIndex(temp)+2);
                r.setHighestCardIndex(0);
                r.setHandValue(1);
                return r;
            }

            if (sorted[1].getValueInt() == sorted[2].getValueInt())
            {
                List<Card> temp = new List<Card>(3);
                temp.Add(sorted[0]);
                temp.Add(sorted[3]);
                temp.Add(sorted[4]);

                r.setPair(true);
                r.setKicker(Card.maxIndex(temp)+2);
                r.setHighestCardIndex(1);
                r.setHandValue(1);
                return r;
            }

            if (sorted[2].getValueInt() == sorted[3].getValueInt())
            {
                List<Card> temp = new List<Card>(3);
                temp.Add(sorted[0]);
                temp.Add(sorted[1]);
                temp.Add(sorted[4]);

                r.setPair(true);
                r.setKicker(Card.maxIndex(temp)+2);
                r.setHighestCardIndex(2);
                r.setHandValue(1);
                return r;
            }

            if (sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                List<Card> temp = new List<Card>(3);
                temp.Add(sorted[0]);
                temp.Add(sorted[1]);
                temp.Add(sorted[2]);

                r.setPair(true);
                r.setKicker(Card.maxIndex(temp) + 2);
                r.setHighestCardIndex(3);
                r.setHandValue(1);
                return r;
            }

            r.setHighCard(true);

            if (sorted[4].getValueInt() == 1)
            {
                r.setKicker(4);
                r.setHighestCardIndex(4);
                r.setHandValue(0);
            }
            else
            {
                r.setKicker(0);
                r.setHighestCardIndex(0);
                r.setHandValue(0);
            }

            return r;
        }

        public Hand determineStraight(List<Card> holecards, List<Card> community)
        {
            List<Card> sorted = sortHoleAndCommunity(holecards, community);
            Hand r = new Hand(sorted);

            if (sorted[0].getValueInt() == 13 && sorted[1].getValueInt() == 12 && sorted[2].getValueInt() == 11
                && sorted[3].getValueInt() == 10 && sorted[4].getValueInt() == 1)
            {
                r.setStraight(true);
                r.setHighestCardIndex(4);
                r.setHandValue(4);
                return r;
            }

            if (sorted[0].getValueInt() == sorted[1].getValueInt() + 1 && sorted[1].getValueInt() == sorted[2].getValueInt() + 1
                && sorted[2].getValueInt() == sorted[3].getValueInt() + 1 && sorted[3].getValueInt() == sorted[4].getValueInt() + 1)
            {
                r.setStraight(true);
                r.setHighestCardIndex(0);
                r.setHandValue(4);
                return r;
            }

            r.setStraight(false);
            return r;
        }

        public Hand determineFlush(List<Card> holecards, List<Card> community)
        {
            List<Card> sorted = sortHoleAndCommunity(holecards, community);
            int temp = sorted[0].getSuitInt();
            Hand r = new Hand(sorted);

            for (int i = 1; i < sorted.Count; i++)
            {
                if (sorted[i].getSuitInt() != temp)
                {
                    r.setFlush(false);
                    return r;
                }
            }

            r.setFlush(true);

            if (sorted[4].getValueInt() == 1)
            {
                r.setHighestCardIndex(4);
            }
            else
            {
                r.setHighestCardIndex(0);
            }
            
            r.setHandValue(5);
            return r;
        }

        public Hand determineFlushDraw(List<Card> holecards, List<Card> community)
        {
            List<Card> sorted = sortHoleAndCommunitySuits(holecards, community);
            Hand r = new Hand(sorted);

            if (sorted[0].getSuitInt() == sorted[1].getSuitInt() && sorted[1].getSuitInt() == sorted[2].getSuitInt()
                && sorted[2].getSuitInt() == sorted[3].getSuitInt())
            {
                r.setFlushDraw(true);
                r.setFlushOuts(9);
                return r;
            }
            else if (sorted[1].getSuitInt() == sorted[2].getSuitInt() && sorted[2].getSuitInt() == sorted[3].getSuitInt()
                && sorted[3].getSuitInt() == sorted[4].getSuitInt())
            {
                r.setFlushDraw(true);
                r.setFlushOuts(9);
                return r;
            }
            else
            {
                r.setFlushDraw(false);
                return r;
            }
        }

        /**
         * Up and Down straight draw and gapped straight draw
         */ 
        public Hand determineStraightDraw(List<Card> holecards, List<Card> community)
        {
            List<Card> sorted = sortHoleAndCommunity(holecards, community);
            Hand r = new Hand(sorted);

            if (sorted[0].getValueInt() == 13 && sorted[1].getValueInt() == 12 && sorted[2].getValueInt() == 11
                && sorted[4].getValueInt() == 1)
            {
                r.setFourCardStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            else if(sorted[0].getValueInt()-1 == sorted[1].getValueInt() && 
                sorted[1].getValueInt()-1 == sorted[2].getValueInt() && sorted[2].getValueInt()-1 == sorted[3].getValueInt())
            {
                r.setFourCardStraight(true);
                r.setStraightOuts(8);
                return r;
            }
            else if (sorted[1].getValueInt() - 1 == sorted[2].getValueInt() &&
                sorted[2].getValueInt() - 1 == sorted[3].getValueInt() && sorted[3].getValueInt() - 1 == sorted[4].getValueInt())
            {
                r.setFourCardStraight(true);
                r.setStraightOuts(8);
                return r;
            }
            else if (sorted[0].getValueInt() == 13 && sorted[1].getValueInt() == 11 && sorted[2].getValueInt() == 10
                && sorted[4].getValueInt() == 1)
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            else if (sorted[0].getValueInt() == 12 && sorted[1].getValueInt() == 11 && sorted[2].getValueInt() == 10
                && sorted[4].getValueInt() == 1)
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            else if (sorted[0].getValueInt() == 13 && sorted[1].getValueInt() == 12 && sorted[2].getValueInt() == 10
                && sorted[4].getValueInt() == 1)
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            /*
             * X6432
             */ 
            else if (sorted[1].getValueInt()-2 == sorted[2].getValueInt() &&
                sorted[2].getValueInt()-1 == sorted[3].getValueInt() && sorted[3].getValueInt()-1 == sorted[4].getValueInt())
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            /*
             * 6432X
             */
            else if (sorted[0].getValueInt()-2 == sorted[1].getValueInt() &&
                sorted[1].getValueInt()-1 == sorted[2].getValueInt() && sorted[2].getValueInt()-1 == sorted[3].getValueInt())
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            /*
             * X6532
             */
            else if (sorted[1].getValueInt()-1 == sorted[2].getValueInt() &&
                sorted[2].getValueInt()-2 == sorted[3].getValueInt() && sorted[3].getValueInt()-1 == sorted[4].getValueInt())
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            /*
             * 6532X
             */
            else if (sorted[0].getValueInt()-1 == sorted[1].getValueInt() &&
                sorted[1].getValueInt()-2 == sorted[2].getValueInt() && sorted[2].getValueInt()-1 == sorted[3].getValueInt())
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            /*
             * X6542
             */
            else if (sorted[1].getValueInt()-1 == sorted[2].getValueInt() &&
                sorted[2].getValueInt()-1 == sorted[3].getValueInt() && sorted[3].getValueInt()-2 == sorted[4].getValueInt())
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            /*
             * 6542X
             */
            else if (sorted[0].getValueInt() - 1 == sorted[1].getValueInt() &&
                sorted[1].getValueInt() - 1 == sorted[2].getValueInt() && sorted[2].getValueInt() - 2 == sorted[3].getValueInt())
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(true);
                r.setStraightOuts(4);
                return r;
            }
            else
            {
                r.setFourCardStraight(false);
                r.setGappedStraight(false);
                return r;
            }
        }

        public Hand determineStraightFlush(List<Card> holecards, List<Card> community)
        {
            Hand isflush = determineFlush(holecards, community);
            Hand isstraight = determineStraight(holecards, community);

            if (isflush.getFlush() && isstraight.getStraight())
            {
                List<Card> sorted = isflush.getBestHand();

                if (sorted[0].getValueInt() == 13 && sorted[1].getValueInt() == 12 && sorted[2].getValueInt() == 11
                    && sorted[3].getValueInt() == 10 && sorted[4].getValueInt() == 1)
                {
                    isflush.setStraight(true);
                    isflush.setRoyalFlush(true);
                    isflush.setHighestCardIndex(4);
                    isflush.setHandValue(9);

                    return isflush;
                }

                isflush.setHighestCardIndex(0);
                isflush.setHandValue(8);
                isflush.setStraight(true);
                return isflush;
            }
            else if (isflush.getFlush())
            {
                return isflush;
            }
            else if (isstraight.getStraight())
            {
                return isstraight;
            }
            else
            {
                return isflush;
            }
        }

        public List<Card> sortHoleAndCommunity(List<Card> holecards, List<Card> community)
        {
            List<Card> total = new List<Card>(holecards);
            total.AddRange(community);
            List<Card> totalSorted = new List<Card>(5);
            int maxindex = 0;

            while (total.Count > 0)
            {
                for (int i = 0; i < total.Count; i++)
                {
                    if (total[i].getValue() > total[maxindex].getValue())
                    {
                        maxindex = i;
                    }
                }

                totalSorted.Add(total[maxindex]);
                total.RemoveAt(maxindex);
                maxindex = 0;
            }

            return totalSorted;
        }

        public List<Card> sortHoleAndCommunitySuits(List<Card> holecards, List<Card> community)
        {
            List<Card> total = new List<Card>(holecards);
            total.AddRange(community);
            List<Card> totalSorted = new List<Card>(5);
            int maxindex = 0;

            while (total.Count > 0)
            {
                for (int i = 0; i < total.Count; i++)
                {
                    if (total[i].getSuit() > total[maxindex].getSuit())
                    {
                        maxindex = i;
                    }
                }

                totalSorted.Add(total[maxindex]);
                total.RemoveAt(maxindex);
                maxindex = 0;
            }

            return totalSorted;
        }
    }
}
