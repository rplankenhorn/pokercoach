using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Coach
{
    public class Hand
    {
        private List<Card> bestHand;
        private int kicker;
        private Boolean royalflush;
        private Boolean quads;
        private Boolean fullhouse;
        private Boolean flush;
        private Boolean straight;
        private Boolean trips;
        private Boolean twopair;
        private Boolean pair;
        private Boolean highcard;
        
        /*
         * Drawing Hands
         */
        private Boolean fourCardStraight;
        private Boolean gappedStraight;
        private Boolean flushDraw;

        private int[] numOfOuts;

        /**
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
        private int handvalue;

        /**
         * Stores the index of the highest card that is apart of the hand.
         * Example:
         * A2222 would store index 1 as highestCard because the 2 is what
         * makes the hand.
         * 
         * In the case of a full house, it sets the value of the trips.
         * Example:
         * AAKKK would store index 2 as highestCard.
         * 
         * This is used for hand comparisons where if you had two pair and the
         * river gave you a higher two pair.
         */ 
        private int highestCard;

        public Hand(List<Card> bestHand)
        {
            this.bestHand = new List<Card>(bestHand);
            kicker = -1;
            royalflush = false;
            quads = false;
            fullhouse = false;
            flush = false;
            straight = false;
            trips = false;
            twopair = false;
            pair = false;
            highcard = false;
            handvalue = 0;
            highestCard = -1;

            fourCardStraight = false;
            gappedStraight = false;
            flushDraw = false;

            numOfOuts = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numOfOuts[i] = 0;
            }
        }

        public Boolean getFlushDraw()
        {
            return flushDraw;
        }

        public void setFlushDraw(Boolean fd)
        {
            flushDraw = fd;
        }

        public Boolean getGappedStraight()
        {
            return gappedStraight;
        }

        public void setGappedStraight(Boolean gap)
        {
            gappedStraight = gap;
        }

        public void setRoyalFlushOuts(int outs)
        {
            numOfOuts[9] = outs;
        }

        public int getRoyalFlushOuts()
        {
            return numOfOuts[9];
        }

        public void setStraightFlushOuts(int outs)
        {
            numOfOuts[8] = outs;
        }

        public int getStraightFlushOuts()
        {
            return numOfOuts[8];
        }

        public void setQuadOuts(int outs)
        {
            numOfOuts[7] = outs;
        }

        public int getQuadOuts()
        {
            return numOfOuts[7];
        }

        public void setFullHouseOuts(int outs)
        {
            numOfOuts[6] = outs;
        }

        public int getFullHouseOuts()
        {
            return numOfOuts[6];
        }

        public void setFlushOuts(int outs)
        {
            numOfOuts[5] = outs;
        }

        public int getFlushOuts()
        {
            return numOfOuts[5];
        }

        public void setStraightOuts(int outs)
        {
            numOfOuts[4] = outs;
        }

        public int getStraightOuts()
        {
            return numOfOuts[4];
        }

        public void setTripOuts(int outs)
        {
            numOfOuts[3] = outs;
        }

        public int getTripOuts()
        {
            return numOfOuts[3];
        }

        public void setTwoPairOuts(int outs)
        {
            numOfOuts[2] = outs;
        }

        public int getTwoPairOuts()
        {
            return numOfOuts[2];
        }

        public void setPairOuts(int outs)
        {
            numOfOuts[1] = outs;
        }

        public int getPairOuts()
        {
            return numOfOuts[1];
        }

        public int getHandValue()
        {
            return handvalue;
        }

        public void setHandValue(int hv)
        {
            handvalue = hv;
        }

        public int getHighestCardIndex()
        {
            return highestCard;
        }

        public void setHighestCardIndex(int hc)
        {
            highestCard = hc;
        }

        public override string ToString()
        {
            if (royalflush)
            {
                return "Royal Flush baby!!!";
            }
            else if (flush && straight)
            {
                return "Straight Flush to the " + bestHand[0].formatCardValue();
            }
            else if (quads)
            {
                if (bestHand[0].getValueInt() == bestHand[1].getValueInt())
                {
                    return "Quad " + bestHand[0].formatCardValuePlural();
                }
                else
                {
                    return "Quad " + bestHand[4].formatCardValuePlural();
                }
            }
            else if (fullhouse)
            {
                if (bestHand[0].getValueInt() == bestHand[2].getValueInt())
                {
                    return bestHand[0].formatCardValuePlural() + " full of " + bestHand[3].formatCardValuePlural();
                }
                else
                {
                    return bestHand[2].formatCardValuePlural() + " full of " + bestHand[0].formatCardValuePlural();
                }
            }
            else if (flush)
            {
                if (bestHand[4].getValueInt() == 1)
                {
                    return "Ace high flush";
                }
                else
                {
                    return bestHand[0].formatCardValue() + " high flush";
                }
            }
            else if (straight)
            {
                if (bestHand[0].getValueInt() == 13 && bestHand[4].getValueInt() == 1)
                {
                    return "Straight to the Ace";
                }
                else
                {
                    return "Straight to the " + bestHand[0].getValueInt();
                }
            }
            else if (trips)
            {
                if (bestHand[0].getValueInt() == bestHand[2].getValueInt())
                {
                    return "Trip " + bestHand[0].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue() + " kicker";
                }
                else if(bestHand[1].getValueInt() == bestHand[3].getValueInt())
                {
                    return "Trip " + bestHand[1].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue() + " kicker";
                }
                else
                {
                    return "Trip " + bestHand[2].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue() + " kicker";
                }
            }
            else if (twopair)
            {
                if(bestHand[0].getValueInt() == bestHand[1].getValueInt() && bestHand[2].getValueInt() == bestHand[3].getValueInt())
                {
                    return "Two pair " +  bestHand[0].formatCardValuePlural() + " and " + bestHand[2].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue();
                }
                else if(bestHand[0].getValueInt() == bestHand[1].getValueInt() && bestHand[3].getValueInt() == bestHand[4].getValueInt())
                {
                    return "Two pair " +  bestHand[0].formatCardValuePlural() + " and " + bestHand[3].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue();
                }
                else
                {
                    return "Two pair " +  bestHand[1].formatCardValuePlural() + " and " + bestHand[3].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue();
                }
            }
            else if (pair)
            {
                if(bestHand[0].getValueInt() == bestHand[1].getValueInt())
                {
                    return "A pair of " + bestHand[0].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue() + " kicker";
                }
                else if(bestHand[1].getValueInt() == bestHand[2].getValueInt())
                {
                    return "A pair of " + bestHand[1].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue() + " kicker";
                }
                else if(bestHand[2].getValueInt() == bestHand[3].getValueInt())
                {
                    return "A pair of " + bestHand[2].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue() + " kicker";
                }
                else
                {
                    return "A pair of " + bestHand[3].formatCardValuePlural() + " with " + bestHand[kicker].formatCardValue() + " kicker";
                }
            }
            else
            {
                return bestHand[kicker].formatCardValue() + " high";
            }
        }

        public List<Card> getBestHand()
        {
            return new List<Card>(bestHand);
        }

        public void setBestHand(List<Card> bestHand)
        {
            this.bestHand = new List<Card>(bestHand);
        }

        public int getKicker()
        {
            return kicker;
        }

        public void setKicker(int k)
        {
            kicker = k;
        }

        public Boolean getRoyalFlush()
        {
            return royalflush;
        }

        public void setRoyalFlush(Boolean rf)
        {
            royalflush = rf;
        }

        public Boolean getQuads()
        {
            return quads;
        }

        public void setQuads(Boolean q)
        {
            quads = q;
        }

        public Boolean getFullHouse()
        {
            return fullhouse;
        }

        public void setFullHouse(Boolean fh)
        {
            fullhouse = fh;
        }

        public Boolean getFlush()
        {
            return flush;
        }

        public void setFlush(Boolean f)
        {
            flush = f;
        }

        public Boolean getStraight()
        {
            return straight;
        }

        public void setStraight(Boolean str)
        {
            straight = str;
        }

        public Boolean getTrips()
        {
            return trips;
        }

        public void setTrips(Boolean trps)
        {
            trips = trps;
        }


        public Boolean getTwoPair()
        {
            return twopair;
        }
        public void setTwoPair(Boolean twpr)
        {
            twopair = twpr;
        }

        public Boolean getPair()
        {
            return pair;
        }

        public void setPair(Boolean pr)
        {
            pair = pr;
        }

        public Boolean getHighCard()
        {
            return highcard;
        }

        public void setHighCard(Boolean hCard)
        {
            highcard = hCard;
        }

        public Boolean getFourCardStraight()
        {
            return fourCardStraight;
        }

        public void setFourCardStraight(Boolean str)
        {
            fourCardStraight = str;
        }
    }
}
