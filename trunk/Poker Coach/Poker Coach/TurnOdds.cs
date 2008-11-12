using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Coach
{
    class TurnOdds
    {
        public Hand determineBestHand(List<Card> holecards, List<Card> community)
        {
            FlopOdds flpodds = new FlopOdds();

            List<Card> sorted = flpodds.sortHoleAndCommunity(holecards, community);
            List<Card> comb0 = new List<Card>(sorted);
            comb0.RemoveAt(0);

            List<Card> comb1 = new List<Card>(sorted);
            comb1.RemoveAt(1);

            List<Card> comb2 = new List<Card>(sorted);
            comb2.RemoveAt(2);

            List<Card> comb3 = new List<Card>(sorted);
            comb3.RemoveAt(3);

            List<Card> comb4 = new List<Card>(sorted);
            comb4.RemoveAt(4);

            Hand pos0;
            Hand pos1;
            Hand pos2;
            Hand pos3;
            Hand pos4;

            List<Card> tempHoleCards = new List<Card>(2);
            List<Card> tempCommunityCards = new List<Card>(3);

            tempHoleCards.Add(comb0[0]);
            tempHoleCards.Add(comb0[1]);
            tempCommunityCards.Add(comb0[2]);
            tempCommunityCards.Add(comb0[3]);
            tempCommunityCards.Add(comb0[4]);

            pos0 = flpodds.determineStraightFlush(tempHoleCards, tempCommunityCards);

            if (!pos0.getFlush() && !pos0.getStraight() && !pos0.getRoyalFlush())
            {
                pos0 = flpodds.determinePair(tempHoleCards, tempCommunityCards);
            }

            tempHoleCards = new List<Card>(2);
            tempCommunityCards = new List<Card>(3);

            tempHoleCards.Add(comb1[0]);
            tempHoleCards.Add(comb1[1]);
            tempCommunityCards.Add(comb1[2]);
            tempCommunityCards.Add(comb1[3]);
            tempCommunityCards.Add(comb1[4]);

            pos1 = flpodds.determineStraightFlush(tempHoleCards, tempCommunityCards);

            if (!pos1.getFlush() && !pos1.getStraight() && !pos1.getRoyalFlush())
            {
                pos1 = flpodds.determinePair(tempHoleCards, tempCommunityCards);
            }

            tempHoleCards = new List<Card>(2);
            tempCommunityCards = new List<Card>(3);

            tempHoleCards.Add(comb2[0]);
            tempHoleCards.Add(comb2[1]);
            tempCommunityCards.Add(comb2[2]);
            tempCommunityCards.Add(comb2[3]);
            tempCommunityCards.Add(comb2[4]);

            pos2 = flpodds.determineStraightFlush(tempHoleCards, tempCommunityCards);

            if (!pos2.getFlush() && !pos2.getStraight() && !pos2.getRoyalFlush())
            {
                pos2 = flpodds.determinePair(tempHoleCards, tempCommunityCards);
            }

            tempHoleCards = new List<Card>(2);
            tempCommunityCards = new List<Card>(3);

            tempHoleCards.Add(comb3[0]);
            tempHoleCards.Add(comb3[1]);
            tempCommunityCards.Add(comb3[2]);
            tempCommunityCards.Add(comb3[3]);
            tempCommunityCards.Add(comb3[4]);

            pos3 = flpodds.determineStraightFlush(tempHoleCards, tempCommunityCards);

            if (!pos3.getFlush() && !pos3.getStraight() && !pos3.getRoyalFlush())
            {
                pos3 = flpodds.determinePair(tempHoleCards, tempCommunityCards);
            }

            tempHoleCards = new List<Card>(2);
            tempCommunityCards = new List<Card>(3);

            tempHoleCards.Add(comb4[0]);
            tempHoleCards.Add(comb4[1]);
            tempCommunityCards.Add(comb4[2]);
            tempCommunityCards.Add(comb4[3]);
            tempCommunityCards.Add(comb4[4]);

            pos4 = flpodds.determineStraightFlush(tempHoleCards, tempCommunityCards);

            if (!pos4.getFlush() && !pos4.getStraight() && !pos4.getRoyalFlush())
            {
                pos4 = flpodds.determinePair(tempHoleCards, tempCommunityCards);
            }

            Hand best = pos0;

            if (best.getHandValue() < pos1.getHandValue())
            {
                best = pos1;
            }

            if (best.getHandValue() < pos2.getHandValue())
            {
                best = pos2;
            }

            if (best.getHandValue() < pos3.getHandValue())
            {
                best = pos3;
            }

            if (best.getHandValue() < pos4.getHandValue())
            {
                best = pos4;
            }

            return best;
        }
    }
}
