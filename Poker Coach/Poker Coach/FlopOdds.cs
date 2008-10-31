using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Coach
{
    class FlopOdds
    {
        /**
         * Determines if there is a pair made on the flop.  Includes if there was a pair
         * made not including the holecards.
         * 
         */
        public String determinePair(List<Card> holecards, List<Card> community)
        {
            List<Card> sorted = sortHoleAndCommunity(holecards, community);
            String r = "";
            Boolean fullhouse = false;
            Boolean pair = false;
            Boolean trips = false;
            Boolean quads = false;

            int[] pairIndexStore = new int[5];

            for (int j = 0; j < sorted.Count; j++)
            {
                for (int i = j+1; i < sorted.Count; i++)
                {
                    if (sorted[j].getValue().Equals(sorted[i].getValue()))
                    {
                        pairIndexStore[j]++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            /**
             * Since the list is sorted, there are only two possible full house configurations.
             * AAAAX, X2222
             */
            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[1].getValueInt() == sorted[2].getValueInt()
                && sorted[2].getValueInt() == sorted[3].getValueInt())
            {
                return "Quad " + sorted[0].formatCardValuePlural();
            }

            if (sorted[1].getValueInt() == sorted[2].getValueInt() && sorted[2].getValueInt() == sorted[3].getValueInt()
                && sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                return "Quad " + sorted[1].formatCardValuePlural();
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
                return sorted[0].formatCardValuePlural() + " full of " + sorted[3].formatCardValuePlural();
            }

            /**
             * Example: KK222
             */ 
            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[2].getValueInt() == sorted[3].getValueInt()
                && sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                return sorted[3].formatCardValuePlural() + " full of " + sorted[0].formatCardValuePlural();
            }

            /**
             * Again, since it is sorted, only 3 possible trip configurations.
             * AAAXY, XJJJY, XY222.
             */

            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[0].getValueInt() == sorted[2].getValueInt()
                && sorted[3].getValueInt() != sorted[4].getValueInt())
            {
                if (sorted[3].getValueInt() == 1 || sorted[4].getValueInt() == 1)
                {
                    return "Trip " + sorted[0].formatCardValuePlural() + " with an Ace Kicker";
                }
                else if (sorted[3].getValueInt() > sorted[4].getValueInt())
                {
                    return "Trip " + sorted[0].formatCardValuePlural() + " with " + sorted[3].formatCardValue() + " Kicker";
                }
                else
                {
                    return "Trip " + sorted[0].formatCardValuePlural() + " with " + sorted[4].formatCardValue() + " Kicker";
                }
            }

            if (sorted[1].getValueInt() == sorted[2].getValueInt() && sorted[1].getValueInt() == sorted[3].getValueInt()
                && sorted[0].getValueInt() != sorted[4].getValueInt())
            {
                if (sorted[0].getValueInt() == 1 || sorted[4].getValueInt() == 1)
                {
                    return "Trip " + sorted[1].formatCardValuePlural() + " with an Ace Kicker";
                }
                else if (sorted[0].getValueInt() > sorted[4].getValueInt())
                {
                    return "Trip " + sorted[1].formatCardValuePlural() + " with " + sorted[0].formatCardValue() + " Kicker";
                }
                else
                {
                    return "Trip " + sorted[1].formatCardValuePlural() + " with " + sorted[4].formatCardValue() + " Kicker";
                }
            }

            if (sorted[2].getValueInt() == sorted[3].getValueInt() && sorted[2].getValueInt() == sorted[4].getValueInt()
                && sorted[0].getValueInt() != sorted[1].getValueInt())
            {
                if (sorted[0].getValueInt() == 1 || sorted[1].getValueInt() == 1)
                {
                    return "Trip " + sorted[2].formatCardValuePlural() + " with an Ace Kicker";
                }
                else if (sorted[0].getValueInt() > sorted[1].getValueInt())
                {
                    return "Trip " + sorted[2].formatCardValuePlural() + " with " + sorted[0].formatCardValue() + " Kicker";
                }
                else
                {
                    return "Trip " + sorted[2].formatCardValuePlural() + " with " + sorted[1].formatCardValue() + " Kicker";
                }
            }

            /**
             * Only three possible two pair configurations
             * XXYYZ, ZXXYY, XXZYY
             */

            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[2].getValueInt() == sorted[3].getValueInt())
            {
                if (sorted[0].getValueInt() > sorted[2].getValueInt())
                {
                    return "Two pair of " + sorted[0].formatCardValuePlural() + " and " + sorted[2].formatCardValuePlural()
                        + " with " + sorted[4].formatCardValue() + " Kicker";
                }
                else
                {
                    return "Two pair of " + sorted[2].formatCardValuePlural() + " and " + sorted[0].formatCardValuePlural()
                        + " with " + sorted[4].formatCardValue() + " Kicker";
                }
            }

            if (sorted[1].getValueInt() == sorted[2].getValueInt() && sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                if (sorted[1].getValueInt() > sorted[3].getValueInt())
                {
                    return "Two pair of " + sorted[1].formatCardValuePlural() + " and " + sorted[3].formatCardValuePlural()
                        + " with " + sorted[0].formatCardValue() + " Kicker";
                }
                else
                {
                    return "Two pair of " + sorted[3].formatCardValuePlural() + " and " + sorted[1].formatCardValuePlural()
                        + " with " + sorted[0].formatCardValue() + " Kicker";
                }
            }

            if (sorted[0].getValueInt() == sorted[1].getValueInt() && sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                if (sorted[1].getValueInt() > sorted[3].getValueInt())
                {
                    return "Two pair of " + sorted[1].formatCardValuePlural() + " and " + sorted[3].formatCardValuePlural()
                        + " with " + sorted[2].formatCardValue() + " Kicker";
                }
                else
                {
                    return "Two pair of " + sorted[3].formatCardValuePlural() + " and " + sorted[1].formatCardValuePlural()
                        + " with " + sorted[2].formatCardValue() + " Kicker";
                }
            }

            /*
             * Again, since list is sorted, there are only four possible positions for pairs.
             * AAXYZ, XKKYZ, XYJJZ, XYZ22
             */
            if (sorted[0].getValueInt() == sorted[1].getValueInt())
            {
                return "A pair of " + sorted[0].formatCardValuePlural() + " with a " + (sorted[2].maxOfThree(sorted[3], 
                    sorted[4])).formatCardValue() + " kicker";
            }

            if (sorted[1].getValueInt() == sorted[2].getValueInt())
            {
                return "A pair of " + sorted[1].formatCardValuePlural() + " with a " + (sorted[0].maxOfThree(sorted[3],
                    sorted[4])).formatCardValue() + " kicker";
            }

            if (sorted[2].getValueInt() == sorted[3].getValueInt())
            {
                return "A pair of " + sorted[2].formatCardValuePlural() + " with a " + (sorted[0].maxOfThree(sorted[1],
                    sorted[4])).formatCardValue() + " kicker";
            }

            if (sorted[3].getValueInt() == sorted[4].getValueInt())
            {
                return "A pair of " + sorted[3].formatCardValuePlural() + " with a " + (sorted[0].maxOfThree(sorted[1],
                    sorted[2])).formatCardValue() + " kicker";
            }

            return null;
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
    }
}
