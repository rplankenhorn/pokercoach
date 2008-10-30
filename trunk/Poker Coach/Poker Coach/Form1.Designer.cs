namespace Poker_Coach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdHoleUpdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numPosition = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numPlayers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Pair = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TwoPair = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Trips = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Straight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Flush = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FullHouse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Quads = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StraightFlush = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Royal = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coachBox = new System.Windows.Forms.GroupBox();
            this.txtCoach = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numChipCount = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numPotSize = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.numCostToPlay = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.coachBox.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChipCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostToPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.cmdHoleUpdate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbbxCardSuit2);
            this.groupBox1.Controls.Add(this.cbbxCardValue2);
            this.groupBox1.Controls.Add(this.cbbxCardSuit1);
            this.groupBox1.Controls.Add(this.cbbxCardValue1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(206, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Cards";
            // 
            // cmdHoleUpdate
            // 
            this.cmdHoleUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdHoleUpdate.Location = new System.Drawing.Point(162, 24);
            this.cmdHoleUpdate.Name = "cmdHoleUpdate";
            this.cmdHoleUpdate.Size = new System.Drawing.Size(120, 55);
            this.cmdHoleUpdate.TabIndex = 4;
            this.cmdHoleUpdate.Text = "Update";
            this.cmdHoleUpdate.UseVisualStyleBackColor = true;
            this.cmdHoleUpdate.Click += new System.EventHandler(this.cmdHoleUpdate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-188, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Position";
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
            "Clubs",
            "Diamonds",
            "Hearts",
            "Spades"});
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
            this.groupBox2.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Controls.Add(this.cmdFlopUpdate);
            this.groupBox2.Controls.Add(this.cbbxFlopCard3Suit);
            this.groupBox2.Controls.Add(this.cbbxFlopCard3Value);
            this.groupBox2.Controls.Add(this.cbbxFlopCard2Suit);
            this.groupBox2.Controls.Add(this.cbbxFlopCard1Value);
            this.groupBox2.Controls.Add(this.cbbxFlopCard2Value);
            this.groupBox2.Controls.Add(this.cbbxFlopCard1Suit);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(206, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flop";
            // 
            // cmdFlopUpdate
            // 
            this.cmdFlopUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.groupBox3.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Controls.Add(this.cmdTurnUpdate);
            this.groupBox3.Controls.Add(this.cbbxTurnCardValue);
            this.groupBox3.Controls.Add(this.cbbxTurnCardSuit);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(540, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turn";
            // 
            // cmdTurnUpdate
            // 
            this.cmdTurnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.groupBox4.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Controls.Add(this.cmdRiverUpdate);
            this.groupBox4.Controls.Add(this.cbbxRiverCardValue);
            this.groupBox4.Controls.Add(this.cbbxRiverCardSuit);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(721, 433);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "River";
            // 
            // cmdRiverUpdate
            // 
            this.cmdRiverUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.groupBox5.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.numPosition);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.numPlayers);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(12, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 176);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Game Info";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Max = Dealer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "2 = Big Blind";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "1 = Small Blind";
            // 
            // numPosition
            // 
            this.numPosition.Location = new System.Drawing.Point(6, 145);
            this.numPosition.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPosition.Name = "numPosition";
            this.numPosition.Size = new System.Drawing.Size(120, 20);
            this.numPosition.TabIndex = 8;
            this.numPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Position";
            // 
            // numPlayers
            // 
            this.numPlayers.Location = new System.Drawing.Point(6, 35);
            this.numPlayers.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numPlayers.Name = "numPlayers";
            this.numPlayers.Size = new System.Drawing.Size(120, 20);
            this.numPlayers.TabIndex = 4;
            this.numPlayers.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numPlayers.ValueChanged += new System.EventHandler(this.numPlayers_ValueChanged);
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
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.Pair);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.TwoPair);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.Trips);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.Straight);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.Flush);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.FullHouse);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.Quads);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.StraightFlush);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.Royal);
            this.groupBox6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Location = new System.Drawing.Point(12, 281);
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
            // Pair
            // 
            this.Pair.Location = new System.Drawing.Point(92, 226);
            this.Pair.Name = "Pair";
            this.Pair.ReadOnly = true;
            this.Pair.Size = new System.Drawing.Size(82, 20);
            this.Pair.TabIndex = 16;
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
            // TwoPair
            // 
            this.TwoPair.Location = new System.Drawing.Point(92, 200);
            this.TwoPair.Name = "TwoPair";
            this.TwoPair.ReadOnly = true;
            this.TwoPair.Size = new System.Drawing.Size(82, 20);
            this.TwoPair.TabIndex = 14;
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
            // Trips
            // 
            this.Trips.Location = new System.Drawing.Point(92, 174);
            this.Trips.Name = "Trips";
            this.Trips.ReadOnly = true;
            this.Trips.Size = new System.Drawing.Size(82, 20);
            this.Trips.TabIndex = 12;
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
            // Straight
            // 
            this.Straight.Location = new System.Drawing.Point(92, 148);
            this.Straight.Name = "Straight";
            this.Straight.ReadOnly = true;
            this.Straight.Size = new System.Drawing.Size(82, 20);
            this.Straight.TabIndex = 10;
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
            // Flush
            // 
            this.Flush.Location = new System.Drawing.Point(92, 122);
            this.Flush.Name = "Flush";
            this.Flush.ReadOnly = true;
            this.Flush.Size = new System.Drawing.Size(82, 20);
            this.Flush.TabIndex = 8;
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
            // FullHouse
            // 
            this.FullHouse.Location = new System.Drawing.Point(92, 97);
            this.FullHouse.Name = "FullHouse";
            this.FullHouse.ReadOnly = true;
            this.FullHouse.Size = new System.Drawing.Size(82, 20);
            this.FullHouse.TabIndex = 6;
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
            // Quads
            // 
            this.Quads.Location = new System.Drawing.Point(92, 71);
            this.Quads.Name = "Quads";
            this.Quads.ReadOnly = true;
            this.Quads.Size = new System.Drawing.Size(82, 20);
            this.Quads.TabIndex = 4;
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
            // StraightFlush
            // 
            this.StraightFlush.Location = new System.Drawing.Point(92, 45);
            this.StraightFlush.Name = "StraightFlush";
            this.StraightFlush.ReadOnly = true;
            this.StraightFlush.Size = new System.Drawing.Size(82, 20);
            this.StraightFlush.TabIndex = 2;
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
            // Royal
            // 
            this.Royal.Location = new System.Drawing.Point(92, 19);
            this.Royal.Name = "Royal";
            this.Royal.ReadOnly = true;
            this.Royal.Size = new System.Drawing.Size(82, 20);
            this.Royal.TabIndex = 0;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStatus.Location = new System.Drawing.Point(6, 15);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(241, 64);
            this.txtStatus.TabIndex = 6;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox7.Controls.Add(this.txtStatus);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(494, 121);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(254, 89);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 165);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // coachBox
            // 
            this.coachBox.BackColor = System.Drawing.Color.DarkRed;
            this.coachBox.Controls.Add(this.txtCoach);
            this.coachBox.Controls.Add(this.pictureBox1);
            this.coachBox.ForeColor = System.Drawing.Color.White;
            this.coachBox.Location = new System.Drawing.Point(206, 210);
            this.coachBox.Name = "coachBox";
            this.coachBox.Size = new System.Drawing.Size(542, 213);
            this.coachBox.TabIndex = 9;
            this.coachBox.TabStop = false;
            this.coachBox.Text = "The Coach Says:";
            // 
            // txtCoach
            // 
            this.txtCoach.Location = new System.Drawing.Point(155, 19);
            this.txtCoach.Name = "txtCoach";
            this.txtCoach.Size = new System.Drawing.Size(292, 188);
            this.txtCoach.TabIndex = 9;
            this.txtCoach.Text = "";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.numCostToPlay);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.numPotSize);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.numChipCount);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox8.Location = new System.Drawing.Point(206, 26);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(447, 89);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Chip Amounts";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-188, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Position";
            // 
            // numChipCount
            // 
            this.numChipCount.Location = new System.Drawing.Point(6, 37);
            this.numChipCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numChipCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChipCount.Name = "numChipCount";
            this.numChipCount.Size = new System.Drawing.Size(120, 20);
            this.numChipCount.TabIndex = 6;
            this.numChipCount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numChipCount.ValueChanged += new System.EventHandler(this.numChipCount_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Your Chip Count";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(156, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Pot Size";
            // 
            // numPotSize
            // 
            this.numPotSize.Location = new System.Drawing.Point(159, 37);
            this.numPotSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPotSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPotSize.Name = "numPotSize";
            this.numPotSize.Size = new System.Drawing.Size(120, 20);
            this.numPotSize.TabIndex = 8;
            this.numPotSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(306, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Cost To Play";
            // 
            // numCostToPlay
            // 
            this.numCostToPlay.Location = new System.Drawing.Point(309, 37);
            this.numCostToPlay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCostToPlay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCostToPlay.Name = "numCostToPlay";
            this.numCostToPlay.Size = new System.Drawing.Size(120, 20);
            this.numCostToPlay.TabIndex = 10;
            this.numCostToPlay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(895, 533);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.coachBox);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Poker Coach";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.coachBox.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChipCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostToPlay)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Royal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Pair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TwoPair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Trips;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Straight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Flush;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FullHouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Quads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StraightFlush;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button cmdHoleUpdate;
        private System.Windows.Forms.Button cmdFlopUpdate;
        private System.Windows.Forms.Button cmdTurnUpdate;
        private System.Windows.Forms.Button cmdRiverUpdate;
        private System.Windows.Forms.NumericUpDown numPlayers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox coachBox;
        private System.Windows.Forms.RichTextBox txtCoach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numPosition;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numPotSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numChipCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numCostToPlay;
    }
}

