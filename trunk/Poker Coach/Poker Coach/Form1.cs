using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poker_Coach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            CARDVALUE value = (CARDVALUE)Enum.Parse(typeof(CARDVALUE), cbbxCardValue1.SelectedItem.ToString(), true);
            SUITS suit = (SUITS)Enum.Parse(typeof(SUITS), cbbxCardSuit1.SelectedItem.ToString(), true);
            Card card1 = new Card(suit,value);
            value = (CARDVALUE)Enum.Parse(typeof(CARDVALUE), cbbxCardValue2.SelectedItem.ToString(), true);
            suit = (SUITS)Enum.Parse(typeof(SUITS), cbbxCardSuit2.SelectedItem.ToString(), true);
            Card card2 = new Card(suit, value);
            txtStatus.Text = card1.ToString();
            txtStatus.Text += " and " + card2.ToString();
            //Colour c = (Colour) Enum.Parse(typeof(Colour), "Red", true);
        }
    }
}
