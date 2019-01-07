using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace shuffler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aAddToDeckButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aCardAmountNumeric.Value; i++)
            {
                aDeckListBox.Items.Add(aNewCardTextBox.Text);
            }

            aCardAmountNumeric.Value = 1;

            aNewCardTextBox.Text = "";

        }

        private void aRemoveCardButton_Click(object sender, EventArgs e)
        {
            aDeckListBox.Items.Remove(aDeckListBox.SelectedItem);
        }


        private void aShuffleButton_Click(object sender, EventArgs e)
        {
            aShuffledDeckListBox.Items.Clear();

            List<string> shuffleUP = new List<string>();

            foreach(string card in aDeckListBox.Items)
            {
                shuffleUP.Add(card);
            }


            var shuffledcards = shuffleUP.OrderBy(a => Guid.NewGuid()).ToList();

            foreach (string card in shuffledcards)
            {
                aShuffledDeckListBox.Items.Add(card);
            }

            try
            {
                aCard1Label.Text = aShuffledDeckListBox.Items[0].ToString();
                string name1 = aCard1Label.Text;
                aCard1Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(name1);


                aCard2Label.Text = aShuffledDeckListBox.Items[1].ToString();
                string name2 = aCard2Label.Text;
                aCard2Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(name2);


                aCard3Label.Text = aShuffledDeckListBox.Items[2].ToString();
                string name3 = aCard3Label.Text;
                aCard3Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(name3);


                aCard4Label.Text = aShuffledDeckListBox.Items[3].ToString();
                string name4 = aCard4Label.Text;
                aCard4Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(name4);


                aCard5Label.Text = aShuffledDeckListBox.Items[4].ToString();
                string name5 = aCard5Label.Text;
                aCard5Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(name5);


                aCard6Label.Text = aShuffledDeckListBox.Items[5].ToString();
                string name6 = aCard6Label.Text;
                aCard6Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(name6);


                aCard7Label.Text = aShuffledDeckListBox.Items[6].ToString();
                string name7 = aCard7Label.Text;
                aCard7Picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(name7);


            }
            catch
            {
                aCard1Label.Text = "Less than 7 cards!";
                aCard2Label.Text = "Less than 7 cards!";
                aCard3Label.Text = "Less than 7 cards!";
                aCard4Label.Text = "Less than 7 cards!";
                aCard5Label.Text = "Less than 7 cards!";
                aCard6Label.Text = "Less than 7 cards!";
                aCard7Label.Text = "Less than 7 cards!";
            }
        }



        private void aDeckImportButton_Click(object sender, EventArgs e)
        {

            aDeckListBox.Items.Clear();

            try
            {
                StreamReader deckImport = new StreamReader("assets\\" + aFileNameTextBox.Text + ".txt");

                string cardReader;

                while ((cardReader = deckImport.ReadLine()) != null)
                {


                    string[] splitUp = cardReader.Split(new char[] { ' ' }, 2);


                    int amount = Convert.ToInt32(splitUp[0]);

                    if(Convert.ToInt32(splitUp[0]) == 0)
                    {
                        aCommanderNameLabel.Text = splitUp[1];
                    }

                    for (int i = 0; i < amount; i++)
                    {
                        aDeckListBox.Items.Add(splitUp[1]);
                    }

                    
                }

            }
            catch
            {
                aFileNameTextBox.Text = "";
            }




        }

        private void aDeleteDeckButton_Click(object sender, EventArgs e)
        {
            aDeckListBox.Items.Clear();
        }

        private void aCommanderNameLabel_TextChanged(object sender, EventArgs e)
        {
            string name = aCommanderNameLabel.Text;
            aCommanderPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(name);
        }


    }

}
