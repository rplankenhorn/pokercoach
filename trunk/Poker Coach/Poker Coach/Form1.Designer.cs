﻿namespace Poker_Coach
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdHoleUpdate = new System.Windows.Forms.Button();
            this.cbbxCardSuit2 = new System.Windows.Forms.ComboBox();
            this.cbbxCardValue2 = new System.Windows.Forms.ComboBox();
            this.cbbxCardSuit1 = new System.Windows.Forms.ComboBox();
            this.cbbxCardValue1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdFlopUpdate = new System.Windows.Forms.Button();
            this.cbbxFlopCard3Suit = new System.Windows.Forms.ComboBox();
            this.cbbxFlopCard3Value = new System.Windows.Forms.ComboBox();
            this.cbbxFlopCard2Suit = new System.Windows.Forms.ComboBox();
            this.cbbxFlopCard1Value = new System.Windows.Forms.ComboBox();
            this.cbbxFlopCard2Value = new System.Windows.Forms.ComboBox();
            this.cbbxFlopCard1Suit = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdTurnUpdate = new System.Windows.Forms.Button();
            this.cbbxTurnCardValue = new System.Windows.Forms.ComboBox();
            this.cbbxTurnCardSuit = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdRiverUpdate = new System.Windows.Forms.Button();
            this.cbbxRiverCardValue = new System.Windows.Forms.ComboBox();
            this.cbbxRiverCardSuit = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumOfOpponents = new System.Windows.Forms.TextBox();
            this.cmdOppPlus = new System.Windows.Forms.Button();
            this.cmdOppMinus = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdHoleUpdate);
            this.groupBox1.Controls.Add(this.cbbxCardSuit2);
            this.groupBox1.Controls.Add(this.cbbxCardValue2);
            this.groupBox1.Controls.Add(this.cbbxCardSuit1);
            this.groupBox1.Controls.Add(this.cbbxCardValue1);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Cards";
            // 
            // cmdHoleUpdate
            // 
            this.cmdHoleUpdate.Location = new System.Drawing.Point(162, 24);
            this.cmdHoleUpdate.Name = "cmdHoleUpdate";
            this.cmdHoleUpdate.Size = new System.Drawing.Size(120, 55);
            this.cmdHoleUpdate.TabIndex = 4;
            this.cmdHoleUpdate.Text = "Update";
            this.cmdHoleUpdate.UseVisualStyleBackColor = true;
            this.cmdHoleUpdate.Click += new System.EventHandler(this.cmdHoleUpdate_Click);
            // 
            // cbbxCardSuit2
            // 
            this.cbbxCardSuit2.FormattingEnabled = true;
            this.cbbxCardSuit2.Items.AddRange(new object[] {
            "Clubs",
            "Diamonds",
            "Hearts",
            "Spades"});
            this.cbbxCardSuit2.Location = new System.Drawing.Point(55, 58);
            this.cbbxCardSuit2.Name = "cbbxCardSuit2";
            this.cbbxCardSuit2.Size = new System.Drawing.Size(85, 21);
            this.cbbxCardSuit2.TabIndex = 3;
            // 
            // cbbxCardValue2
            // 
            this.cbbxCardValue2.FormattingEnabled = true;
            this.cbbxCardValue2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"});
            this.cbbxCardValue2.Location = new System.Drawing.Point(12, 58);
            this.cbbxCardValue2.Name = "cbbxCardValue2";
            this.cbbxCardValue2.Size = new System.Drawing.Size(37, 21);
            this.cbbxCardValue2.TabIndex = 2;
            // 
            // cbbxCardSuit1
            // 
            this.cbbxCardSuit1.FormattingEnabled = true;
            this.cbbxCardSuit1.Items.AddRange(new object[] {
            "CLUBS",
            "DIAMONDS",
            "HEARTS",
            "SPADES"});
            this.cbbxCardSuit1.Location = new System.Drawing.Point(55, 24);
            this.cbbxCardSuit1.Name = "cbbxCardSuit1";
            this.cbbxCardSuit1.Size = new System.Drawing.Size(85, 21);
            this.cbbxCardSuit1.TabIndex = 1;
            // 
            // cbbxCardValue1
            // 
            this.cbbxCardValue1.FormattingEnabled = true;
            this.cbbxCardValue1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"});
            this.cbbxCardValue1.Location = new System.Drawing.Point(12, 24);
            this.cbbxCardValue1.Name = "cbbxCardValue1";
            this.cbbxCardValue1.Size = new System.Drawing.Size(37, 21);
            this.cbbxCardValue1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdFlopUpdate);
            this.groupBox2.Controls.Add(this.cbbxFlopCard3Suit);
            this.groupBox2.Controls.Add(this.cbbxFlopCard3Value);
            this.groupBox2.Controls.Add(this.cbbxFlopCard2Suit);
            this.groupBox2.Controls.Add(this.cbbxFlopCard1Value);
            this.groupBox2.Controls.Add(this.cbbxFlopCard2Value);
            this.groupBox2.Controls.Add(this.cbbxFlopCard1Suit);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flop";
            // 
            // cmdFlopUpdate
            // 
            this.cmdFlopUpdate.Location = new System.Drawing.Point(238, 31);
            this.cmdFlopUpdate.Name = "cmdFlopUpdate";
            this.cmdFlopUpdate.Size = new System.Drawing.Size(84, 48);
            this.cmdFlopUpdate.TabIndex = 10;
            this.cmdFlopUpdate.Text = "Update";
            this.cmdFlopUpdate.UseVisualStyleBackColor = true;
            this.cmdFlopUpdate.Click += new System.EventHandler(this.cmdFlopUpdate_Click);
            // 
            // cbbxFlopCard3Suit
            // 
            this.cbbxFlopCard3Suit.FormattingEnabled = true;
            this.cbbxFlopCard3Suit.Items.AddRange(new object[] {
            "Clubs",
            "Diamonds",
            "Hearts",
            "Spades"});
            this.cbbxFlopCard3Suit.Location = new System.Drawing.Point(162, 58);
            this.cbbxFlopCard3Suit.Name = "cbbxFlopCard3Suit";
            this.cbbxFlopCard3Suit.Size = new System.Drawing.Size(71, 21);
            this.cbbxFlopCard3Suit.TabIndex = 9;
            // 
            // cbbxFlopCard3Value
            // 
            this.cbbxFlopCard3Value.FormattingEnabled = true;
            this.cbbxFlopCard3Value.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"});
            this.cbbxFlopCard3Value.Location = new System.Drawing.Point(162, 31);
            this.cbbxFlopCard3Value.Name = "cbbxFlopCard3Value";
            this.cbbxFlopCard3Value.Size = new System.Drawing.Size(37, 21);
            this.cbbxFlopCard3Value.TabIndex = 8;
            // 
            // cbbxFlopCard2Suit
            // 
            this.cbbxFlopCard2Suit.FormattingEnabled = true;
            this.cbbxFlopCard2Suit.Items.AddRange(new object[] {
            "Clubs",
            "Diamonds",
            "Hearts",
            "Spades"});
            this.cbbxFlopCard2Suit.Location = new System.Drawing.Point(82, 58);
            this.cbbxFlopCard2Suit.Name = "cbbxFlopCard2Suit";
            this.cbbxFlopCard2Suit.Size = new System.Drawing.Size(71, 21);
            this.cbbxFlopCard2Suit.TabIndex = 7;
            // 
            // cbbxFlopCard1Value
            // 
            this.cbbxFlopCard1Value.FormattingEnabled = true;
            this.cbbxFlopCard1Value.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"});
            this.cbbxFlopCard1Value.Location = new System.Drawing.Point(6, 31);
            this.cbbxFlopCard1Value.Name = "cbbxFlopCard1Value";
            this.cbbxFlopCard1Value.Size = new System.Drawing.Size(37, 21);
            this.cbbxFlopCard1Value.TabIndex = 4;
            // 
            // cbbxFlopCard2Value
            // 
            this.cbbxFlopCard2Value.FormattingEnabled = true;
            this.cbbxFlopCard2Value.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"});
            this.cbbxFlopCard2Value.Location = new System.Drawing.Point(82, 31);
            this.cbbxFlopCard2Value.Name = "cbbxFlopCard2Value";
            this.cbbxFlopCard2Value.Size = new System.Drawing.Size(37, 21);
            this.cbbxFlopCard2Value.TabIndex = 6;
            // 
            // cbbxFlopCard1Suit
            // 
            this.cbbxFlopCard1Suit.FormattingEnabled = true;
            this.cbbxFlopCard1Suit.Items.AddRange(new object[] {
            "Clubs",
            "Diamonds",
            "Hearts",
            "Spades"});
            this.cbbxFlopCard1Suit.Location = new System.Drawing.Point(6, 58);
            this.cbbxFlopCard1Suit.Name = "cbbxFlopCard1Suit";
            this.cbbxFlopCard1Suit.Size = new System.Drawing.Size(71, 21);
            this.cbbxFlopCard1Suit.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdTurnUpdate);
            this.groupBox3.Controls.Add(this.cbbxTurnCardValue);
            this.groupBox3.Controls.Add(this.cbbxTurnCardSuit);
            this.groupBox3.Location = new System.Drawing.Point(346, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turn";
            // 
            // cmdTurnUpdate
            // 
            this.cmdTurnUpdate.Location = new System.Drawing.Point(83, 31);
            this.cmdTurnUpdate.Name = "cmdTurnUpdate";
            this.cmdTurnUpdate.Size = new System.Drawing.Size(84, 48);
            this.cmdTurnUpdate.TabIndex = 12;
            this.cmdTurnUpdate.Text = "Update";
            this.cmdTurnUpdate.UseVisualStyleBackColor = true;
            this.cmdTurnUpdate.Click += new System.EventHandler(this.cmdTurnUpdate_Click);
            // 
            // cbbxTurnCardValue
            // 
            this.cbbxTurnCardValue.FormattingEnabled = true;
            this.cbbxTurnCardValue.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"});
            this.cbbxTurnCardValue.Location = new System.Drawing.Point(6, 31);
            this.cbbxTurnCardValue.Name = "cbbxTurnCardValue";
            this.cbbxTurnCardValue.Size = new System.Drawing.Size(37, 21);
            this.cbbxTurnCardValue.TabIndex = 10;
            // 
            // cbbxTurnCardSuit
            // 
            this.cbbxTurnCardSuit.FormattingEnabled = true;
            this.cbbxTurnCardSuit.Items.AddRange(new object[] {
            "Clubs",
            "Diamonds",
            "Hearts",
            "Spades"});
            this.cbbxTurnCardSuit.Location = new System.Drawing.Point(6, 58);
            this.cbbxTurnCardSuit.Name = "cbbxTurnCardSuit";
            this.cbbxTurnCardSuit.Size = new System.Drawing.Size(71, 21);
            this.cbbxTurnCardSuit.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdRiverUpdate);
            this.groupBox4.Controls.Add(this.cbbxRiverCardValue);
            this.groupBox4.Controls.Add(this.cbbxRiverCardSuit);
            this.groupBox4.Location = new System.Drawing.Point(527, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "River";
            // 
            // cmdRiverUpdate
            // 
            this.cmdRiverUpdate.Location = new System.Drawing.Point(83, 31);
            this.cmdRiverUpdate.Name = "cmdRiverUpdate";
            this.cmdRiverUpdate.Size = new System.Drawing.Size(84, 48);
            this.cmdRiverUpdate.TabIndex = 13;
            this.cmdRiverUpdate.Text = "Update";
            this.cmdRiverUpdate.UseVisualStyleBackColor = true;
            this.cmdRiverUpdate.Click += new System.EventHandler(this.cmdRiverUpdate_Click);
            // 
            // cbbxRiverCardValue
            // 
            this.cbbxRiverCardValue.FormattingEnabled = true;
            this.cbbxRiverCardValue.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"});
            this.cbbxRiverCardValue.Location = new System.Drawing.Point(6, 31);
            this.cbbxRiverCardValue.Name = "cbbxRiverCardValue";
            this.cbbxRiverCardValue.Size = new System.Drawing.Size(37, 21);
            this.cbbxRiverCardValue.TabIndex = 6;
            // 
            // cbbxRiverCardSuit
            // 
            this.cbbxRiverCardSuit.FormattingEnabled = true;
            this.cbbxRiverCardSuit.Items.AddRange(new object[] {
            "Clubs",
            "Diamonds",
            "Hearts",
            "Spades"});
            this.cbbxRiverCardSuit.Location = new System.Drawing.Point(6, 58);
            this.cbbxRiverCardSuit.Name = "cbbxRiverCardSuit";
            this.cbbxRiverCardSuit.Size = new System.Drawing.Size(71, 21);
            this.cbbxRiverCardSuit.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtNumOfOpponents);
            this.groupBox5.Controls.Add(this.cmdOppPlus);
            this.groupBox5.Controls.Add(this.cmdOppMinus);
            this.groupBox5.Location = new System.Drawing.Point(299, 283);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(254, 173);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Game Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "# of Opponents";
            // 
            // txtNumOfOpponents
            // 
            this.txtNumOfOpponents.Location = new System.Drawing.Point(12, 35);
            this.txtNumOfOpponents.Name = "txtNumOfOpponents";
            this.txtNumOfOpponents.Size = new System.Drawing.Size(81, 20);
            this.txtNumOfOpponents.TabIndex = 2;
            this.txtNumOfOpponents.Text = "1";
            // 
            // cmdOppPlus
            // 
            this.cmdOppPlus.Location = new System.Drawing.Point(55, 60);
            this.cmdOppPlus.Name = "cmdOppPlus";
            this.cmdOppPlus.Size = new System.Drawing.Size(38, 24);
            this.cmdOppPlus.TabIndex = 1;
            this.cmdOppPlus.Text = "+";
            this.cmdOppPlus.UseVisualStyleBackColor = true;
            // 
            // cmdOppMinus
            // 
            this.cmdOppMinus.Location = new System.Drawing.Point(12, 60);
            this.cmdOppMinus.Name = "cmdOppMinus";
            this.cmdOppMinus.Size = new System.Drawing.Size(38, 24);
            this.cmdOppMinus.TabIndex = 0;
            this.cmdOppMinus.Text = "-";
            this.cmdOppMinus.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.textBox9);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Location = new System.Drawing.Point(627, 176);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(188, 252);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hand Probabilities";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Pair";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(92, 226);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(82, 20);
            this.textBox9.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Two Pair";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(92, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(82, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Three of a Kind";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(92, 174);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(82, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Straight";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(92, 148);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(82, 20);
            this.textBox7.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Flush";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(92, 122);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(82, 20);
            this.textBox8.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Full House";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Four of a Kind";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(82, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Straight Flush";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Royal Flush";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(6, 15);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(241, 97);
            this.txtStatus.TabIndex = 6;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtStatus);
            this.groupBox7.Location = new System.Drawing.Point(12, 238);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(254, 125);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 533);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Poker Coach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbxCardSuit2;
        private System.Windows.Forms.ComboBox cbbxCardValue2;
        private System.Windows.Forms.ComboBox cbbxCardSuit1;
        private System.Windows.Forms.ComboBox cbbxCardValue1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbxFlopCard3Suit;
        private System.Windows.Forms.ComboBox cbbxFlopCard3Value;
        private System.Windows.Forms.ComboBox cbbxFlopCard2Suit;
        private System.Windows.Forms.ComboBox cbbxFlopCard1Value;
        private System.Windows.Forms.ComboBox cbbxFlopCard2Value;
        private System.Windows.Forms.ComboBox cbbxFlopCard1Suit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbxTurnCardValue;
        private System.Windows.Forms.ComboBox cbbxTurnCardSuit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbbxRiverCardValue;
        private System.Windows.Forms.ComboBox cbbxRiverCardSuit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumOfOpponents;
        private System.Windows.Forms.Button cmdOppPlus;
        private System.Windows.Forms.Button cmdOppMinus;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button cmdHoleUpdate;
        private System.Windows.Forms.Button cmdFlopUpdate;
        private System.Windows.Forms.Button cmdTurnUpdate;
        private System.Windows.Forms.Button cmdRiverUpdate;
    }
}
