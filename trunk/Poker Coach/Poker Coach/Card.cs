﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum SUITS
{
    CLUBS = 1,
    DIAMONDS = 2,
    HEARTS = 3,
    SPADES = 4
};

public enum CARDVALUE
{
    ACE = 14,
    TWO = 2,
    THREE = 3,
    FOUR = 4,
    FIVE = 5,
    SIX = 6,
    SEVEN = 7,
    EIGHT = 8,
    NINE = 9,
    TEN = 10,
    JACK = 11,
    QUEEN = 12,
    KING = 13
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

        public void setSuit(SUITS s)
        {
            suit = s;
        }

        public CARDVALUE getValue()
        {
            return value;
        }

        public void setValue(CARDVALUE v)
        {
            value = v;
        }
    }
}
