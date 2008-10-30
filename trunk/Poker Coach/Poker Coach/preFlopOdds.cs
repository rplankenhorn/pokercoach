using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Coach
{
    public class preFlopOdds
    {
        private Card card1;
        private Card card2;
        private int numPlayers;
        private double[,] suitOdds;
        private double[,] unsuitOdds;
        public double pair = 1000;
        public double twopair = 1000;
        public double trips = 1000;
        public double straight = 1000;
        public double flush = 1000;
        public double fullHouse = 1000;
        public double quads = 1000;
        public double strtFlush = 1000;
        public double royal = 1000;


        public preFlopOdds(Card acard, Card bcard, int num)
        {
            card1 = acard;
            card2 = bcard;
            numPlayers = num;
            suitOdds = new double[14,14];
            unsuitOdds = new double[14,14];
            this.populate();


        }

        public double getPair()
        {
            return pair;
        }

        public double getTwoPair()
        {
            return twopair;
        }

        public double getTrips()
        {
            return trips;
        }

        public double getStraight()
        {
            return straight;
        }

        public double getFlush()
        {
            return flush;
        }

        public double getFullHouse()
        {
            return fullHouse;
        }

        public double getQuads()
        {
            return quads;
        }

        public double getStraightFlush()
        {
            return strtFlush;
        }

        public double getRoyal()
        {
            return royal;
        }

        public double getOdds()
        {
            if( card1.getSuitInt() == card2.getSuitInt()) //these are suited hands 
            {
                 
                flush = .837;
                quads = .0102;
                fullHouse = .092;
                trips = 1.57;
                twopair = 4.014;
                pair = 26.939;

                if ((card1.getValueInt() >= 10) && (card2.getValueInt() >= 10)) //covers royal case without aces
                {
                    royal = .0051;
                }
                else if ((card1.getValueInt() == 1) && (card2.getValueInt() >= 10))//covers royal case with card1 being ace
                {
                    royal = .0051;
                }
                else if ((card2.getValueInt() == 1) && (card1.getValueInt() >= 10))//covers royal case with card2 being ace
                {
                    royal = .0051;
                }
                else
                {
                    royal = 0.0;
                }


                //puts cards in order from highest to lowest value for table lookup
                if ((card1.getValueInt() == 1)) //for ace special case
                {
                    if ((card2.getValueInt() == 2) || (card2.getValueInt() == 13))//connected ace
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else if ((card2.getValueInt() == 3) || (card2.getValueInt() == 12)) //one gapped ace
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else if ((card2.getValueInt() == 4) || (card2.getValueInt() == 11)) //two gapped ace
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else if ((card2.getValueInt() == 5) || (card2.getValueInt() == 10)) //three gapped ace
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else //no shot at straight
                    {
                        straight = 0.0;
                        strtFlush = .0051;
                    }

                    return suitOdds[card1.getValueInt(), card2.getValueInt()];
                }
                else if ((card2.getValueInt() == 1)) //for ace special case
                {
                    if ((card1.getValueInt() == 2) || (card1.getValueInt() == 13))//connected ace
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else if ((card1.getValueInt() == 3) || (card1.getValueInt() == 12)) //one gapped ace
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else if ((card1.getValueInt() == 4) || (card1.getValueInt() == 11)) //two gapped ace
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else if ((card1.getValueInt() == 5) || (card1.getValueInt() == 10)) //three gapped ace
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else //no shot at straight
                    {
                        straight = 0.0;
                    }
                    return suitOdds[card2.getValueInt(), card1.getValueInt()];
                }

                else if((card1.getValueInt() > card2.getValueInt()))
                {
                    if (card1.getValueInt() - card2.getValueInt() == 1)//odds for connectors
                    {
                        straight = 1.306;
                        strtFlush = .02;
                    }
                    else if (card1.getValueInt() - card2.getValueInt() == 2)//odds for 1 gapped connectors
                    {
                        straight = .980;
                        strtFlush = .015;
                    }
                    else if (card1.getValueInt() - card2.getValueInt() == 3)//odds for 2 gapped connectors
                    {
                        straight = .653;
                        strtFlush = .010;
                    }
                    else if (card1.getValueInt() - card2.getValueInt() == 4)//odds for 3 gapped connectors
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else
                    {
                        straight = 0.0; //gapped more than three, no chance of straight
                    }

                    return suitOdds[card1.getValueInt(), card2.getValueInt()];
                }
                else 
                {
                    if (card2.getValueInt() - card1.getValueInt() == 1)//odds for connectors
                    {
                        straight = 1.306;
                        strtFlush = .02;
                    }
                    else if (card2.getValueInt() - card1.getValueInt() == 2)//odds for 1 gapped connectors
                    {
                        straight = .980;
                        strtFlush = .015;
                    }
                    else if (card2.getValueInt() - card1.getValueInt() == 3)//odds for 2 gapped connectors
                    {
                        straight = .653;
                        strtFlush = .010;
                    }
                    else if (card2.getValueInt() - card1.getValueInt() == 4)//odds for 3 gapped connectors
                    {
                        straight = .327;
                        strtFlush = .0051;
                    }
                    else
                    {
                        straight = 0.0; //gapped more than three, no chance of straight
                    }
                    return suitOdds[card2.getValueInt(), card1.getValueInt()];
                }


            }

            else //these are unsuited hands
            {
                flush = 0;
                strtFlush = 0;
                royal = 0;


                //puts cards in order from highest to lowest value for table lookup
                if ((card1.getValueInt() == 1)) // covers Ace as card 1
                {
                    if (card1.getValueInt() == card2.getValueInt()) //this would be pocket Aces
                    {
                        pair = 100;
                        twopair = 16.163;
                        trips = 11.83;
                        straight = 0;
                        fullHouse = .980;
                        quads = .245;
                    }
                    else //for non-paired hole cards
                    {
                        if ((card2.getValueInt() == 2) || (card2.getValueInt() == 13))//connected ace
                        {
                            straight = 1.306;
                        }
                        else if ((card2.getValueInt() == 3) || (card2.getValueInt() == 12)) //one gapped ace
                        {
                            straight = .980;
                        }
                        else if ((card2.getValueInt() == 4) || (card2.getValueInt() == 11)) //two gapped ace
                        {
                            straight = .653;
                        }
                        else if ((card2.getValueInt() == 5) || (card2.getValueInt() == 10)) //three gapped ace
                        {
                            straight = .327;
                        }
                        else //no shot at straight
                        {
                            straight = 0.0;
                        }
                        quads = .0102;
                        fullHouse = .092;
                        trips = 1.57;
                        twopair = 4.014;
                        pair = 26.939;
                    }

                    return unsuitOdds[card1.getValueInt(), card2.getValueInt()];
                }
                else if ((card2.getValueInt() == 1)) //covers Ace as card2
                {
                    if (card1.getValueInt() == card2.getValueInt())//again for pocket Aces (should never reach this state)
                    {
                        pair = 100;
                        twopair = 16.163;
                        trips = 11.83;
                        straight = 0;
                        fullHouse = .980;
                        quads = .245;
                    }
                    else
                    {
                        if ((card1.getValueInt() == 2) || (card1.getValueInt() == 13))//connected ace
                        {
                            straight = 1.306;
                        }
                        else if ((card1.getValueInt() == 3) || (card1.getValueInt() == 12)) //one gapped ace
                        {
                            straight = .980;
                        }
                        else if ((card1.getValueInt() == 4) || (card1.getValueInt() == 11)) //two gapped ace
                        {
                            straight = .653;
                        }
                        else if ((card1.getValueInt() == 5) || (card1.getValueInt() == 10)) //three gapped ace
                        {
                            straight = .327;
                        }
                        else //no shot at straight
                        {
                            straight = 0.0;
                        }
                        quads = .0102;
                        fullHouse = .092;
                        trips = 1.57;
                        twopair = 4.014;
                        pair = 26.939;
                    }

                    return unsuitOdds[card2.getValueInt(), card1.getValueInt()];
                }

                else if ((card1.getValueInt() >= card2.getValueInt()))//card 1 is non ace greater than or equal to card2
                {
                    if (card1.getValueInt() == card2.getValueInt()) //a pocket pair
                    {
                        pair = 100;
                        twopair = 16.163;
                        trips = 11.83;
                        straight = 0;
                        fullHouse = .980;
                        quads = .245;
                    }
                    else
                    {
                        if (card1.getValueInt() - card2.getValueInt() == 1)//odds for connectors
                        {
                            straight = 1.306;
                        }
                        else if (card1.getValueInt() - card2.getValueInt() == 2)//odds for 1 gapped connectors
                        {
                            straight = .980;
                        }
                        else if (card1.getValueInt() - card2.getValueInt() == 3)//odds for 2 gapped connectors
                        {
                            straight = .653;
                        }
                        else if (card1.getValueInt() - card2.getValueInt() == 4)//odds for 3 gapped connectors
                        {
                            straight = .327;
                        }
                        else
                        {
                            straight = 0.0; //gapped more than three, no chance of straight
                        }
                        quads = .0102;
                        fullHouse = .092;
                        trips = 1.57;
                        twopair = 4.014;
                        pair = 26.939;
                    }

                    return unsuitOdds[card1.getValueInt(), card2.getValueInt()];
                }
                else //card2 is non-ace greater than card1
                {
                    if (card2.getValueInt() - card1.getValueInt() == 1)//odds for connectors
                    {
                        straight = 1.306;
                    }
                    else if (card2.getValueInt() - card1.getValueInt() == 2)//odds for 1 gapped connectors
                    {
                        straight = .980;
                    }
                    else if (card2.getValueInt() - card1.getValueInt() == 3)//odds for 2 gapped connectors
                    {
                        straight = .653;
                    }
                    else if (card2.getValueInt() - card1.getValueInt() == 4)//odds for 3 gapped connectors
                    {
                        straight = .327;
                    }
                    else
                    {
                        straight = 0.0; //gapped more than three, no chance of straight
                    }
                    quads = .0102;
                    fullHouse = .092;
                    trips = 1.57;
                    twopair = 4.014;
                    pair = 26.939;

                    return unsuitOdds[card2.getValueInt(), card1.getValueInt()];
                }
            }

        }

        private void populate()
        {
            //hardcoded preflop odds of winning,
            //based off simulations of millions of hands
            if (numPlayers >= 2) //no simulation table for 7 players, so combine 7 and 8 players (should be very similar)
            {
                unsuitOdds[1, 1] = 39.05;
                unsuitOdds[1, 13] = 22.68;
                unsuitOdds[1, 12] = 20.98;
                unsuitOdds[1, 11] = 19.7;
                unsuitOdds[1, 10] = 18.74;
                unsuitOdds[1, 9] = 16.27;
                unsuitOdds[1, 8] = 15.55;
                unsuitOdds[1, 7] = 14.94;
                unsuitOdds[1, 6] = 14.39;
                unsuitOdds[1, 5] = 15.1;
                unsuitOdds[1, 4] = 14.63;
                unsuitOdds[1, 3] = 14.15;
                unsuitOdds[1, 2] = 13.54;

                unsuitOdds[13, 13] = 33.26;
                unsuitOdds[13, 12] = 20.31;
                unsuitOdds[13, 11] = 19.1;
                unsuitOdds[13, 10] = 18.18;
                unsuitOdds[13, 9] = 15.62;
                unsuitOdds[13, 8] = 14.01;
                unsuitOdds[13, 7] = 13.48;
                unsuitOdds[13, 6] = 13.02;
                unsuitOdds[13, 5] = 12.65;
                unsuitOdds[13, 4] = 12.21;
                unsuitOdds[13, 3] = 11.79;
                unsuitOdds[13, 2] = 11.41;

                unsuitOdds[12, 12] = 28.71;
                unsuitOdds[12, 11] = 18.67;
                unsuitOdds[12, 10] = 17.83;
                unsuitOdds[12, 9] = 15.27;
                unsuitOdds[12, 8] = 13.6;
                unsuitOdds[12, 7] = 12.22;
                unsuitOdds[12, 6] = 11.81;
                unsuitOdds[12, 5] = 11.46;
                unsuitOdds[12, 4] = 11.03;
                unsuitOdds[12, 3] = 10.63;
                unsuitOdds[12, 2] = 10.26;

                unsuitOdds[11, 11] = 25.13;
                unsuitOdds[11, 10] = 17.86;
                unsuitOdds[11, 9] = 15.34;
                unsuitOdds[11, 8] = 13.68;
                unsuitOdds[11, 7] = 12.18;
                unsuitOdds[11, 6] = 10.94;
                unsuitOdds[11, 5] = 10.64;
                unsuitOdds[11, 4] = 10.22;
                unsuitOdds[11, 3] = 9.83;
                unsuitOdds[11, 2] = 9.46;

                unsuitOdds[10, 10] = 22.32;
                unsuitOdds[10, 9] = 15.71;
                unsuitOdds[10, 8] = 14.07;
                unsuitOdds[10, 7] = 12.55;
                unsuitOdds[10, 6] = 11.18;
                unsuitOdds[10, 5] = 10.06;
                unsuitOdds[10, 4] = 9.66;
                unsuitOdds[10, 3] = 9.28;
                unsuitOdds[10, 2] = 8.93;

                unsuitOdds[9, 9] = 19.89;
                unsuitOdds[9, 8] = 13.73;
                unsuitOdds[9, 7] = 12.54;
                unsuitOdds[9, 6] = 11.22;
                unsuitOdds[9, 5] = 9.97;
                unsuitOdds[9, 4] = 8.76;
                unsuitOdds[9, 3] = 8.4;
                unsuitOdds[9, 2] = 8.04;

                unsuitOdds[8, 8] = 13.73;
                unsuitOdds[8, 7] = 12.79;
                unsuitOdds[8, 6] = 11.7;
                unsuitOdds[8, 5] = 10.47;
                unsuitOdds[8, 4] = 9.12;
                unsuitOdds[8, 3] = 7.96;
                unsuitOdds[8, 2] = 7.61;

                unsuitOdds[7, 7] = 16.85;
                unsuitOdds[7, 6] = 12.08;
                unsuitOdds[7, 5] = 11.07;
                unsuitOdds[7, 4] = 9.73;
                unsuitOdds[7, 3] = 8.41;
                unsuitOdds[7, 2] = 7.28;

                unsuitOdds[6, 6] = 15.84;
                unsuitOdds[6, 5] = 11.51;
                unsuitOdds[6, 4] = 10.39;
                unsuitOdds[6, 3] = 9.08;
                unsuitOdds[6, 2] = 7.79;

                unsuitOdds[5, 5] = 14.93;
                unsuitOdds[5, 4] = 11.12;
                unsuitOdds[5, 3] = 10.04;
                unsuitOdds[5, 2] = 8.73;

                unsuitOdds[4, 4] = 14.31;
                unsuitOdds[4, 3] = 9.38;
                unsuitOdds[4, 2] = 8.3;

                unsuitOdds[3, 3] = 13.83;
                unsuitOdds[3, 2] = 7.67;

                unsuitOdds[2, 2] = 13.49;

                //suit odds
                suitOdds[1, 13] = 26.0;
                suitOdds[1, 12] = 24.51;
                suitOdds[1, 11] = 23.41;
                suitOdds[1, 10] = 22.55;
                suitOdds[1, 9] = 20.28;
                suitOdds[1, 8] = 19.66;
                suitOdds[1, 7] = 19.12;
                suitOdds[1, 6] = 18.62;
                suitOdds[1, 5] = 19.29;
                suitOdds[1, 4] = 18.86;
                suitOdds[1, 3] = 18.41;
                suitOdds[1, 2] = 17.86;

                suitOdds[13, 12] = 23.72;
                suitOdds[13, 11] = 22.66;
                suitOdds[13, 10] = 21.87;
                suitOdds[13, 9] = 19.5;
                suitOdds[13, 8] = 18.05;
                suitOdds[13, 7] = 17.57;
                suitOdds[13, 6] = 17.17;
                suitOdds[13, 5] = 16.83;
                suitOdds[13, 4] = 16.44;
                suitOdds[13, 3] = 16.06;
                suitOdds[13, 2] = 15.7;

                suitOdds[12, 11] = 22.1;
                suitOdds[12, 10] = 21.38;
                suitOdds[12, 9] = 19.03;
                suitOdds[12, 8] = 17.51;
                suitOdds[12, 7] = 16.22;
                suitOdds[12, 6] = 15.85;
                suitOdds[12, 5] = 15.56;
                suitOdds[12, 4] = 15.16;
                suitOdds[12, 3] = 14.81;
                suitOdds[12, 2] = 14.46;

                suitOdds[11, 10] = 21.26;
                suitOdds[11, 9] = 18.96;
                suitOdds[11, 8] = 17.44;
                suitOdds[11, 7] = 16.07;
                suitOdds[11, 6] = 14.92;
                suitOdds[11, 5] = 14.66;
                suitOdds[11, 4] = 14.28;
                suitOdds[11, 3] = 13.92;
                suitOdds[11, 2] = 13.59;

                suitOdds[10, 9] = 19.18;
                suitOdds[10, 8] = 17.68;
                suitOdds[10, 7] = 16.3;
                suitOdds[10, 6] = 15.03;
                suitOdds[10, 5] = 13.98;
                suitOdds[10, 4] = 13.64;
                suitOdds[10, 3] = 13.3;
                suitOdds[10, 2] = 12.95;

                suitOdds[9, 8] = 17.31;
                suitOdds[9, 7] = 16.2;
                suitOdds[9, 6] = 14.99;
                suitOdds[9, 5] = 13.81;
                suitOdds[9, 4] = 12.71;
                suitOdds[9, 3] = 12.37;
                suitOdds[9, 2] = 12.03;

                suitOdds[8, 7] = 16.38;
                suitOdds[8, 6] = 15.37;
                suitOdds[8, 5] = 14.22;
                suitOdds[8, 4] = 12.98;
                suitOdds[8, 3] = 11.88;
                suitOdds[8, 2] = 11.57;

                suitOdds[7, 6] = 15.66;
                suitOdds[7, 5] = 14.74;
                suitOdds[7, 4] = 13.48;
                suitOdds[7, 3] = 12.25;
                suitOdds[7, 2] = 11.19;

                suitOdds[6, 5] = 15.12;
                suitOdds[6, 4] = 14.07;
                suitOdds[6, 3] = 12.85;
                suitOdds[6, 2] = 11.62;

                suitOdds[5, 4] = 14.74;
                suitOdds[5, 3] = 13.71;
                suitOdds[5, 2] = 12.5;

                suitOdds[4, 3] = 13.09;
                suitOdds[4, 2] = 12.08;

                suitOdds[3, 2] = 11.49;



            }
        }





    

    

    }
}
