namespace shuffler
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
            this.aShuffleButton = new System.Windows.Forms.Button();
            this.aCard1Label = new System.Windows.Forms.Label();
            this.aCard2Label = new System.Windows.Forms.Label();
            this.aCard3Label = new System.Windows.Forms.Label();
            this.aCard4Label = new System.Windows.Forms.Label();
            this.aCard5Label = new System.Windows.Forms.Label();
            this.aCard6Label = new System.Windows.Forms.Label();
            this.aCard7Label = new System.Windows.Forms.Label();
            this.aCardAmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.aNewCardTextBox = new System.Windows.Forms.TextBox();
            this.aAddToDeckButton = new System.Windows.Forms.Button();
            this.aDeckListBox = new System.Windows.Forms.ListBox();
            this.aRemoveCardButton = new System.Windows.Forms.Button();
            this.aDeckImportButton = new System.Windows.Forms.Button();
            this.aFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aDeleteDeckButton = new System.Windows.Forms.Button();
            this.aShuffledDeckListBox = new System.Windows.Forms.ListBox();
            this.aCommanderNameLabel = new System.Windows.Forms.Label();
            this.aCommanderPictureBox = new System.Windows.Forms.PictureBox();
            this.aCard6Picture = new System.Windows.Forms.PictureBox();
            this.aCard5Picture = new System.Windows.Forms.PictureBox();
            this.aCard4Picture = new System.Windows.Forms.PictureBox();
            this.aCard3Picture = new System.Windows.Forms.PictureBox();
            this.aCard2Picture = new System.Windows.Forms.PictureBox();
            this.aCard1Picture = new System.Windows.Forms.PictureBox();
            this.aCard7Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aCardAmountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCommanderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard6Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard5Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard4Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard3Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard7Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // aShuffleButton
            // 
            this.aShuffleButton.Location = new System.Drawing.Point(12, 12);
            this.aShuffleButton.Name = "aShuffleButton";
            this.aShuffleButton.Size = new System.Drawing.Size(225, 77);
            this.aShuffleButton.TabIndex = 0;
            this.aShuffleButton.Text = "Shuffle Deck";
            this.aShuffleButton.UseVisualStyleBackColor = true;
            this.aShuffleButton.Click += new System.EventHandler(this.aShuffleButton_Click);
            // 
            // aCard1Label
            // 
            this.aCard1Label.Location = new System.Drawing.Point(54, 397);
            this.aCard1Label.Name = "aCard1Label";
            this.aCard1Label.Size = new System.Drawing.Size(144, 18);
            this.aCard1Label.TabIndex = 17;
            this.aCard1Label.Text = "card 1";
            // 
            // aCard2Label
            // 
            this.aCard2Label.Location = new System.Drawing.Point(219, 397);
            this.aCard2Label.Name = "aCard2Label";
            this.aCard2Label.Size = new System.Drawing.Size(144, 18);
            this.aCard2Label.TabIndex = 18;
            this.aCard2Label.Text = "card 2";
            // 
            // aCard3Label
            // 
            this.aCard3Label.Location = new System.Drawing.Point(392, 397);
            this.aCard3Label.Name = "aCard3Label";
            this.aCard3Label.Size = new System.Drawing.Size(144, 18);
            this.aCard3Label.TabIndex = 19;
            this.aCard3Label.Text = "card 3";
            // 
            // aCard4Label
            // 
            this.aCard4Label.Location = new System.Drawing.Point(560, 397);
            this.aCard4Label.Name = "aCard4Label";
            this.aCard4Label.Size = new System.Drawing.Size(144, 18);
            this.aCard4Label.TabIndex = 20;
            this.aCard4Label.Text = "card 4";
            // 
            // aCard5Label
            // 
            this.aCard5Label.Location = new System.Drawing.Point(727, 397);
            this.aCard5Label.Name = "aCard5Label";
            this.aCard5Label.Size = new System.Drawing.Size(144, 18);
            this.aCard5Label.TabIndex = 21;
            this.aCard5Label.Text = "card 5";
            // 
            // aCard6Label
            // 
            this.aCard6Label.Location = new System.Drawing.Point(890, 397);
            this.aCard6Label.Name = "aCard6Label";
            this.aCard6Label.Size = new System.Drawing.Size(144, 18);
            this.aCard6Label.TabIndex = 22;
            this.aCard6Label.Text = "card 6";
            // 
            // aCard7Label
            // 
            this.aCard7Label.Location = new System.Drawing.Point(1052, 397);
            this.aCard7Label.Name = "aCard7Label";
            this.aCard7Label.Size = new System.Drawing.Size(144, 18);
            this.aCard7Label.TabIndex = 23;
            this.aCard7Label.Text = "card 7";
            // 
            // aCardAmountNumeric
            // 
            this.aCardAmountNumeric.Location = new System.Drawing.Point(981, 39);
            this.aCardAmountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aCardAmountNumeric.Name = "aCardAmountNumeric";
            this.aCardAmountNumeric.Size = new System.Drawing.Size(46, 20);
            this.aCardAmountNumeric.TabIndex = 24;
            this.aCardAmountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aNewCardTextBox
            // 
            this.aNewCardTextBox.Location = new System.Drawing.Point(1033, 38);
            this.aNewCardTextBox.Name = "aNewCardTextBox";
            this.aNewCardTextBox.Size = new System.Drawing.Size(255, 20);
            this.aNewCardTextBox.TabIndex = 25;
            // 
            // aAddToDeckButton
            // 
            this.aAddToDeckButton.Location = new System.Drawing.Point(1099, 64);
            this.aAddToDeckButton.Name = "aAddToDeckButton";
            this.aAddToDeckButton.Size = new System.Drawing.Size(127, 28);
            this.aAddToDeckButton.TabIndex = 27;
            this.aAddToDeckButton.Text = "Add to Deck";
            this.aAddToDeckButton.UseVisualStyleBackColor = true;
            this.aAddToDeckButton.Click += new System.EventHandler(this.aAddToDeckButton_Click);
            // 
            // aDeckListBox
            // 
            this.aDeckListBox.FormattingEnabled = true;
            this.aDeckListBox.Location = new System.Drawing.Point(1034, 98);
            this.aDeckListBox.Name = "aDeckListBox";
            this.aDeckListBox.Size = new System.Drawing.Size(253, 251);
            this.aDeckListBox.TabIndex = 29;
            // 
            // aRemoveCardButton
            // 
            this.aRemoveCardButton.Location = new System.Drawing.Point(1226, 355);
            this.aRemoveCardButton.Name = "aRemoveCardButton";
            this.aRemoveCardButton.Size = new System.Drawing.Size(61, 28);
            this.aRemoveCardButton.TabIndex = 30;
            this.aRemoveCardButton.Text = "Remove";
            this.aRemoveCardButton.UseVisualStyleBackColor = true;
            this.aRemoveCardButton.Click += new System.EventHandler(this.aRemoveCardButton_Click);
            // 
            // aDeckImportButton
            // 
            this.aDeckImportButton.Location = new System.Drawing.Point(709, 64);
            this.aDeckImportButton.Name = "aDeckImportButton";
            this.aDeckImportButton.Size = new System.Drawing.Size(166, 34);
            this.aDeckImportButton.TabIndex = 31;
            this.aDeckImportButton.Text = "Import Deck File";
            this.aDeckImportButton.UseVisualStyleBackColor = true;
            this.aDeckImportButton.Click += new System.EventHandler(this.aDeckImportButton_Click);
            // 
            // aFileNameTextBox
            // 
            this.aFileNameTextBox.Location = new System.Drawing.Point(656, 38);
            this.aFileNameTextBox.Name = "aFileNameTextBox";
            this.aFileNameTextBox.Size = new System.Drawing.Size(271, 20);
            this.aFileNameTextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "File Name:";
            // 
            // aDeleteDeckButton
            // 
            this.aDeleteDeckButton.Location = new System.Drawing.Point(1146, 355);
            this.aDeleteDeckButton.Name = "aDeleteDeckButton";
            this.aDeleteDeckButton.Size = new System.Drawing.Size(74, 28);
            this.aDeleteDeckButton.TabIndex = 34;
            this.aDeleteDeckButton.Text = "CLEAR";
            this.aDeleteDeckButton.UseVisualStyleBackColor = true;
            this.aDeleteDeckButton.Click += new System.EventHandler(this.aDeleteDeckButton_Click);
            // 
            // aShuffledDeckListBox
            // 
            this.aShuffledDeckListBox.FormattingEnabled = true;
            this.aShuffledDeckListBox.Location = new System.Drawing.Point(14, 111);
            this.aShuffledDeckListBox.Name = "aShuffledDeckListBox";
            this.aShuffledDeckListBox.Size = new System.Drawing.Size(222, 225);
            this.aShuffledDeckListBox.TabIndex = 35;
            // 
            // aCommanderNameLabel
            // 
            this.aCommanderNameLabel.Location = new System.Drawing.Point(293, 101);
            this.aCommanderNameLabel.Name = "aCommanderNameLabel";
            this.aCommanderNameLabel.Size = new System.Drawing.Size(144, 18);
            this.aCommanderNameLabel.TabIndex = 38;
            this.aCommanderNameLabel.Text = "Commander:";
            this.aCommanderNameLabel.TextChanged += new System.EventHandler(this.aCommanderNameLabel_TextChanged);
            // 
            // aCommanderPictureBox
            // 
            this.aCommanderPictureBox.Image = global::shuffler.Properties.Resources.CardBack;
            this.aCommanderPictureBox.Location = new System.Drawing.Point(296, 135);
            this.aCommanderPictureBox.Name = "aCommanderPictureBox";
            this.aCommanderPictureBox.Size = new System.Drawing.Size(145, 201);
            this.aCommanderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aCommanderPictureBox.TabIndex = 37;
            this.aCommanderPictureBox.TabStop = false;
            // 
            // aCard6Picture
            // 
            this.aCard6Picture.Image = ((System.Drawing.Image)(resources.GetObject("aCard6Picture.Image")));
            this.aCard6Picture.Location = new System.Drawing.Point(893, 431);
            this.aCard6Picture.Name = "aCard6Picture";
            this.aCard6Picture.Size = new System.Drawing.Size(144, 201);
            this.aCard6Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aCard6Picture.TabIndex = 7;
            this.aCard6Picture.TabStop = false;
            // 
            // aCard5Picture
            // 
            this.aCard5Picture.Image = ((System.Drawing.Image)(resources.GetObject("aCard5Picture.Image")));
            this.aCard5Picture.Location = new System.Drawing.Point(730, 431);
            this.aCard5Picture.Name = "aCard5Picture";
            this.aCard5Picture.Size = new System.Drawing.Size(142, 201);
            this.aCard5Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aCard5Picture.TabIndex = 6;
            this.aCard5Picture.TabStop = false;
            // 
            // aCard4Picture
            // 
            this.aCard4Picture.Image = ((System.Drawing.Image)(resources.GetObject("aCard4Picture.Image")));
            this.aCard4Picture.Location = new System.Drawing.Point(563, 431);
            this.aCard4Picture.Name = "aCard4Picture";
            this.aCard4Picture.Size = new System.Drawing.Size(142, 201);
            this.aCard4Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aCard4Picture.TabIndex = 5;
            this.aCard4Picture.TabStop = false;
            // 
            // aCard3Picture
            // 
            this.aCard3Picture.Image = ((System.Drawing.Image)(resources.GetObject("aCard3Picture.Image")));
            this.aCard3Picture.Location = new System.Drawing.Point(395, 431);
            this.aCard3Picture.Name = "aCard3Picture";
            this.aCard3Picture.Size = new System.Drawing.Size(143, 201);
            this.aCard3Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aCard3Picture.TabIndex = 4;
            this.aCard3Picture.TabStop = false;
            // 
            // aCard2Picture
            // 
            this.aCard2Picture.Image = ((System.Drawing.Image)(resources.GetObject("aCard2Picture.Image")));
            this.aCard2Picture.Location = new System.Drawing.Point(222, 431);
            this.aCard2Picture.Name = "aCard2Picture";
            this.aCard2Picture.Size = new System.Drawing.Size(145, 201);
            this.aCard2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aCard2Picture.TabIndex = 3;
            this.aCard2Picture.TabStop = false;
            // 
            // aCard1Picture
            // 
            this.aCard1Picture.Image = global::shuffler.Properties.Resources.CardBack;
            this.aCard1Picture.Location = new System.Drawing.Point(57, 431);
            this.aCard1Picture.Name = "aCard1Picture";
            this.aCard1Picture.Size = new System.Drawing.Size(141, 201);
            this.aCard1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aCard1Picture.TabIndex = 2;
            this.aCard1Picture.TabStop = false;
            // 
            // aCard7Picture
            // 
            this.aCard7Picture.Image = ((System.Drawing.Image)(resources.GetObject("aCard7Picture.Image")));
            this.aCard7Picture.Location = new System.Drawing.Point(1057, 431);
            this.aCard7Picture.Name = "aCard7Picture";
            this.aCard7Picture.Size = new System.Drawing.Size(139, 201);
            this.aCard7Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aCard7Picture.TabIndex = 1;
            this.aCard7Picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 644);
            this.Controls.Add(this.aCommanderNameLabel);
            this.Controls.Add(this.aCommanderPictureBox);
            this.Controls.Add(this.aShuffledDeckListBox);
            this.Controls.Add(this.aDeleteDeckButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aFileNameTextBox);
            this.Controls.Add(this.aDeckImportButton);
            this.Controls.Add(this.aRemoveCardButton);
            this.Controls.Add(this.aDeckListBox);
            this.Controls.Add(this.aAddToDeckButton);
            this.Controls.Add(this.aNewCardTextBox);
            this.Controls.Add(this.aCardAmountNumeric);
            this.Controls.Add(this.aCard7Label);
            this.Controls.Add(this.aCard6Label);
            this.Controls.Add(this.aCard5Label);
            this.Controls.Add(this.aCard4Label);
            this.Controls.Add(this.aCard3Label);
            this.Controls.Add(this.aCard2Label);
            this.Controls.Add(this.aCard1Label);
            this.Controls.Add(this.aCard6Picture);
            this.Controls.Add(this.aCard5Picture);
            this.Controls.Add(this.aCard4Picture);
            this.Controls.Add(this.aCard3Picture);
            this.Controls.Add(this.aCard2Picture);
            this.Controls.Add(this.aCard1Picture);
            this.Controls.Add(this.aCard7Picture);
            this.Controls.Add(this.aShuffleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.aCardAmountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCommanderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard6Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard5Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard4Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard3Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCard7Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aShuffleButton;
        private System.Windows.Forms.PictureBox aCard7Picture;
        private System.Windows.Forms.PictureBox aCard1Picture;
        private System.Windows.Forms.PictureBox aCard2Picture;
        private System.Windows.Forms.PictureBox aCard3Picture;
        private System.Windows.Forms.PictureBox aCard4Picture;
        private System.Windows.Forms.PictureBox aCard5Picture;
        private System.Windows.Forms.PictureBox aCard6Picture;
        private System.Windows.Forms.Label aCard1Label;
        private System.Windows.Forms.Label aCard2Label;
        private System.Windows.Forms.Label aCard3Label;
        private System.Windows.Forms.Label aCard4Label;
        private System.Windows.Forms.Label aCard5Label;
        private System.Windows.Forms.Label aCard6Label;
        private System.Windows.Forms.Label aCard7Label;
        private System.Windows.Forms.NumericUpDown aCardAmountNumeric;
        private System.Windows.Forms.TextBox aNewCardTextBox;
        private System.Windows.Forms.Button aAddToDeckButton;
        private System.Windows.Forms.ListBox aDeckListBox;
        private System.Windows.Forms.Button aRemoveCardButton;
        private System.Windows.Forms.Button aDeckImportButton;
        private System.Windows.Forms.TextBox aFileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aDeleteDeckButton;
        private System.Windows.Forms.ListBox aShuffledDeckListBox;
        private System.Windows.Forms.Label aCommanderNameLabel;
        private System.Windows.Forms.PictureBox aCommanderPictureBox;
    }
}

