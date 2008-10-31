using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum SUITS
{
    INPLAY = 0,
    CLUBS = 1,
    DIAMONDS = 2,
    HEARTS = 3,
    SPADES = 4
};

public enum CARDVALUE
{
    INPLAY = 0,
    A = 1,
    TWO = 2,
    THREE = 3,
    FOUR = 4,
    FIVE = 5,
    SIX = 6,
    SEVEN = 7,
    EIGHT = 8,
    NINE = 9,
    TEN = 10,
    J = 11,
    Q = 12,
    K = 13
};

namespace Poker_Coach
{
    public class Card
    {
        private SUITS suit;
        private CARDVALUE value;

        public Card(SUITS s, CARDVALUE v)
        {
            suit = s;
            value = v;
        }

        public SUITS getSuit()
        {
            return suit;
        }

        public int getSuitInt()
        {
            return (int)suit;
        }

        public void setSuit(SUITS s)
        {
            suit = s;
        }

        public CARDVALUE getValue()
        {
            return value;
        }

        public int getValueInt()
        {
            return (int)value;
        }

        public void setValue(CARDVALUE v)
        {
            value = v;
        }

        public override string ToString()
        {
            return value + " of " + suit;
        }

        public int compareValue(Card temp)
        {
            if (this.getValue() > temp.getValue())
            {
                return 1;
            }
            else if (this.getValue() < temp.getValue())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public Boolean compareSuit(Card temp)
        {
            if(this.getSuit().Equals(temp.getSuit()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string formatCardValue()
        {
            if (this.getValueInt() == 11)
            {
                return "Jack";
            }
            else if (this.getValueInt() == 12)
            {
                return "Queen";
            }
            else if (this.getValueInt() == 13)
            {
                return "King";
            }
            else if (this.getValueInt() == 14 || this.getValueInt() == 1)
            {
                return "Ace";
            }
            else if (this.getValueInt() == 2)
            {
                return "Two";
            }
            else if (this.getValueInt() == 3)
            {
                return "Three";
            }
            else if (this.getValueInt() == 4)
            {
                return "Four";
            }
            else if (this.getValueInt() == 5)
            {
                return "Five";
            }
            else if (this.getValueInt() == 6)
            {
                return "Six";
            }
            else if (this.getValueInt() == 7)
            {
                return "Seven";
            }
            else if (this.getValueInt() == 8)
            {
                return "Eight";
            }
            else if (this.getValueInt() == 9)
            {
                return "Nine";
            }
            else if (this.getValueInt() == 10)
            {
                return "Ten";
            }
            else
            {
                return this.getValue().ToString();
            }
        }

        public string formatCardValuePlural()
        {
            if (this.getValueInt() == 11)
            {
                return "Jacks";
            }
            else if (this.getValueInt() == 12)
            {
                return "Queens";
            }
            else if (this.getValueInt() == 13)
            {
                return "Kings";
            }
            else if (this.getValueInt() == 14 || this.getValueInt() == 1)
            {
                return "Aces";
            }
            else if (this.getValueInt() == 2)
            {
                return "Twos";
            }
            else if (this.getValueInt() == 3)
            {
                return "Threes";
            }
            else if (this.getValueInt() == 4)
            {
                return "Fours";
            }
            else if (this.getValueInt() == 5)
            {
                return "Fives";
            }
            else if (this.getValueInt() == 6)
            {
                return "Sixes";
            }
            else if (this.getValueInt() == 7)
            {
                return "Sevens";
            }
            else if (this.getValueInt() == 8)
            {
                return "Eights";
            }
            else if (this.getValueInt() == 9)
            {
                return "Nines";
            }
            else if (this.getValueInt() == 10)
            {
                return "Tens";
            }
            else
            {
                return this.getValue().ToString();
            }
        }

        public Card maxOfThree(Card two, Card three)
        {
            if (this.getValueInt() == 1)
            {
                return this;
            }
            else if (two.getValueInt() == 1)
            {
                return two;
            }
            else if (three.getValueInt() == 1)
            {
                return three;
            }
            else if (this.getValueInt() > two.getValueInt() && this.getValueInt() > three.getValueInt())
            {
                return this;
            }
            else if (two.getValueInt() > this.getValueInt() && two.getValueInt() > three.getValueInt())
            {
                return two;
            }
            else
            {
                return three;
            }
        }

        public static int maxIndex(List<Card> cards)
        {
            int index = 0;

            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].getValueInt() > cards[index].getValueInt())
                {
                    index = i;
                }
            }

            return index;
        }
    }
}

