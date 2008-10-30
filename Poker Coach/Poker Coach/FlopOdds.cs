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

            for (int k = 0; k < 5; k++)
            {
                switch(pairIndexStore[k])
                {
                    case 1:
                        r += " a Pair of " + sorted[k].getValue().ToString();
                        break;
                    case 2:
                        r += " Trip " + sorted[k].getValue().ToString();
                        break;
                    case 3:
                        r += " Quad " + sorted[k].getValue().ToString();
                        break;
                  
                }
            }

            return r;
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
