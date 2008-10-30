using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Poker_Coach
{
    public partial class Form1 : Form
    {
        //List to store hole cards
        public List<Card> holecards;

        //List to store community cards (Flop, turn, river)
        public List<Card> community;

        public Card[,] cardsLeft;

        //all of these doubles are percent values
     


        public Form1()
        {
            InitializeComponent();
            txtCoach.Text += "Welcome, let's win kid...\r\n\rInput your two cards\r\n\r";
        }

        private void populateCardsLeft()
        {
            //Array for storing cards left in deck.
            //14: number of cards in suit +1.  Since enum starts at 1.  Easier than always subtracting 1.
            //5: number of suits + 1.
            cardsLeft = new Card[5,14];

            int i = 0;
            int j = 0;

            //Populates two dimmentional array for cards left.
            //[SUITS,VALUE] follow SUITS Enum and CARDVALUE Enum.
            for (i = 1; i < 5; i++)
            {
                for (j = 1; j < 14; j++)
                {
                    cardsLeft[i,j] = new Card((SUITS)i, (CARDVALUE)j);
                }
            }
        }

        private void cmdFlopUpdate_Click(object sender, EventArgs e)
        {
            if (cbbxFlopCard1Value.SelectedIndex > -1 && cbbxFlopCard1Suit.SelectedIndex > -1 &&
                cbbxFlopCard2Value.SelectedIndex > -1 && cbbxFlopCard2Suit.SelectedIndex > -1 &&
                cbbxFlopCard3Value.SelectedIndex > -1 && cbbxFlopCard3Suit.SelectedIndex > -1)
            {
                community = new List<Card>(5);

                CARDVALUE value = (CARDVALUE)Enum.Parse(typeof(CARDVALUE), cbbxFlopCard1Value.SelectedItem.ToString(), true);
                SUITS suit = (SUITS)Enum.Parse(typeof(SUITS), cbbxFlopCard1Suit.SelectedItem.ToString(), true);

                community.Add(new Card(suit, value));
                cardsLeft[community[0].getSuitInt(), community[0].getValueInt()] = new Card(0, 0);

                value = (CARDVALUE)Enum.Parse(typeof(CARDVALUE), cbbxFlopCard2Value.SelectedItem.ToString(), true);
                suit = (SUITS)Enum.Parse(typeof(SUITS), cbbxFlopCard2Suit.SelectedItem.ToString(), true);

                community.Add(new Card(suit, value));
                cardsLeft[community[1].getSuitInt(), community[1].getValueInt()] = new Card(0, 0);

                value = (CARDVALUE)Enum.Parse(typeof(CARDVALUE), cbbxFlopCard3Value.SelectedItem.ToString(), true);
                suit = (SUITS)Enum.Parse(typeof(SUITS), cbbxFlopCard3Suit.SelectedItem.ToString(), true);

                community.Add(new Card(suit, value));
                cardsLeft[community[2].getSuitInt(), community[2].getValueInt()] = new Card(0, 0);

                txtStatus.Text += "\r\n\r\nFlop is: " + community[0].ToString() + ", " + community[1].ToString() +
                    ", and " + community[2].ToString();

                FlopOdds flpodds = new FlopOdds();

                txtStatus.Text += flpodds.determinePair(holecards, community);
            }
        }

        private void cmdHoleUpdate_Click(object sender, EventArgs e)
        {

            //Makes sure something is selected before updating.
            if (cbbxCardSuit1.SelectedIndex > -1 && cbbxCardSuit2.SelectedIndex > -1 &&
                cbbxCardValue1.SelectedIndex > -1 && cbbxCardValue2.SelectedIndex > -1)
            {
                //Deck Initialize
                populateCardsLeft();

                //Initialize List
                holecards = new List<Card>(2);
                double odds;

                //Convert string to ENUM
                CARDVALUE value = (CARDVALUE)Enum.Parse(typeof(CARDVALUE), cbbxCardValue1.SelectedItem.ToString(), true);
                SUITS suit = (SUITS)Enum.Parse(typeof(SUITS), cbbxCardSuit1.SelectedItem.ToString(), true);

                //Create first hole card
                Card card1 = new Card(suit, value);

                //Convert string to ENUM
                value = (CARDVALUE)Enum.Parse(typeof(CARDVALUE), cbbxCardValue2.SelectedItem.ToString(), true);
                suit = (SUITS)Enum.Parse(typeof(SUITS), cbbxCardSuit2.SelectedItem.ToString(), true);

                //Create second hole card
                Card card2 = new Card(suit, value);

                //Add hole cards to List
                holecards.Add(card1);
                holecards.Add(card2);

                preFlopOdds pre = new preFlopOdds(card1, card2, (int) numPlayers.Value);
                odds = pre.getOdds();

                cardsLeft[holecards[0].getSuitInt(), holecards[0].getValueInt()] = new Card(0,0);
                cardsLeft[holecards[1].getSuitInt(), holecards[1].getValueInt()] = new Card(0,0);
                
                //update preflop hand probabilites, these are hands you can make with the flop ONLY!!!
                Royal.Text = pre.getRoyal().ToString() + "%";
                StraightFlush.Text = " <= " + pre.getStraightFlush().ToString() + "%";
                Quads.Text = pre.getQuads().ToString() + "%";
                FullHouse.Text = pre.getFullHouse().ToString() + "%";
                Flush.Text = pre.getFlush().ToString() + "%";
                Straight.Text = " <= " + pre.getStraight().ToString() + "%";
                Trips.Text = pre.getTrips().ToString() + "%";
                TwoPair.Text = pre.getTwoPair().ToString() + "%";
                Pair.Text =  pre.getPair().ToString() + "%";

                //Output to status
                txtStatus.Text += "\r\n\r\nYour hand: " + holecards[0].ToString();
                txtStatus.Text += " and " + holecards[1].ToString();
                txtStatus.Text += "\r\n\r\nCurrent pre-flop odds to win: " + odds.ToString() + "%";
                txtStatus.SelectionStart = txtStatus.Text.Length;
                txtStatus.ScrollToCaret();

                Coach ourCoach = new Coach(1);

                double temp = ourCoach.preFlopCalc(odds, (double)numChipCount.Value, (double)numPotSize.Value, (int)numPosition.Value, (double)numCostToPlay.Value, (int)numPlayers.Value);

                txtCoach.Text += ourCoach.preFlopDecision(temp, (double)numCostToPlay.Value);

            }
        }

        private void cmdTurnUpdate_Click(object sender, EventArgs e)
        {
            if (cbbxTurnCardSuit.SelectedIndex > -1 && cbbxTurnCardValue.SelectedIndex > -1 &&
                community != null && community.Count == 3)
            {
                CARDVALUE value = (CARDVALUE)Enum.Parse(typeof(CARDVALUE), cbbxTurnCardValue.SelectedItem.ToString(), true);
                SUITS suit = (SUITS)Enum.Parse(typeof(SUITS), cbbxTurnCardSuit.SelectedItem.ToString(), true);

                Card turn = new Card(suit, value);

                community.Add(turn);
                cardsLeft[community[3].getSuitInt(), community[3].getValueInt()] = new Card(0, 0);

                txtStatus.Text += "\r\n\r\nTurn Updated: " + turn.ToString();
            }
        }

        private void cmdRiverUpdate_Click(object sender, EventArgs e)
        {
            if (cbbxRiverCardSuit.SelectedIndex > -1 && cbbxRiverCardValue.SelectedIndex > -1 &&
                community != null)
            {
                CARDVALUE value = (CARDVALUE)Enum.Parse(typeof(CARDVALUE), cbbxRiverCardValue.SelectedItem.ToString(), true);
                SUITS suit = (SUITS)Enum.Parse(typeof(SUITS), cbbxRiverCardSuit.SelectedItem.ToString(), true);

                Card river = new Card(suit, value);

                community.Add(river);
                cardsLeft[community[4].getSuitInt(), community[4].getValueInt()] = new Card(0, 0);

                txtStatus.Text += "\r\n\r\nRiver Updated: " + river.ToString();
            }
        }

        private void numPlayers_ValueChanged(object sender, EventArgs e)
        {
            numPosition.Maximum = numPlayers.Value;
        }

        private void numChipCount_ValueChanged(object sender, EventArgs e)
        {
            numCostToPlay.Maximum = numChipCount.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numPosition.Maximum = numPlayers.Value;
            numCostToPlay.Maximum = numChipCount.Value;
        }
    }
}
