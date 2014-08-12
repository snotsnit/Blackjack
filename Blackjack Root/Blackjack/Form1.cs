using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlackJackLateNightAttempt
{
    public partial class Form1 : Form
    {
        int[] Cards = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 }; //Card possibilities (4 tens because: 10, jack, queen, king)
        int Two = 0;
        int Three = 0;
        int Four = 0;
        int Five = 0;
        int Six = 0;
        int Seven = 0;
        int Eight = 0;
        int Nine = 0;
        int Ten = 0;
        int Card; // The current drawn card by either player or dealer
        int Hand = 0; // Player's hand
        int DealerHand = 0; // Dealer's hand
        int Held = 0; // Ammount of cards held by player
        int Wins = 0; // Wins
        int Losses = 0; // Losses
        int Ties = 0; // Ties
        Random Rand = new Random(); // Using randoms for card selection
        
		private PictureBox[] picPlayBoxes;

        public Form1()
        {
            InitializeComponent();
            picPlayBoxes = new PictureBox[] { picPlay1, picPlay2, picPlay3 };
        }

        private void buttonNew_Click_1(object sender, EventArgs e)
        {
            int Aces = 0; // Being sure not to get 2 aces in a row so it doesn't glitch
            Hand = 0; // Reset hand
            DealerHand = 0; // Reset dealer's hand
            Held = 0; // Reset cards held
            labelStanding.Visible = false; // Remove the label indicating the standing dealer
            buttonHit.Enabled = true; // Enable hit
            buttonStand.Enabled = true; // Enable stand

            while (Held < 2)
            { // Giving 2 cards at the beginning
                if (Rand.Next(1, 14) == 1 && Aces == 0)
                { // Got Ace
                    AceShow();
                    Aces++;
                    Held++;
                }
                else
                { // Random normal card
                    GetCard();
                }
            }

            // Giving dealer 2 cards
            Card = Cards[Rand.Next(0, 12)];
            DealerHand += Card;
            Card = Cards[Rand.Next(0, 12)];
            DealerHand += Card;

            // Updating current player values
            labelHand.Text = Hand.ToString();
            labelHeld.Text = Held.ToString();       
        }

        private void buttonOkay_Click_1(object sender, EventArgs e)
        {
            // "Okay" button for when you get an Ace
            if (radioButtonHigh.Checked)
            { // Low Ace
                Hand += 11;
                picPlay3.ImageLocation = @"images\hearts-a-150.png";
                picPlay3.Visible = true;                
            }
            else
            { // High Ace
                Hand += 1;
                picPlay3.ImageLocation = @"images\spades-a-150.png";
                picPlay3.Visible = true;
            }

			// Removing Ace stuff, enabling hit and stand again
			buttonOkay.Visible = false;
			radioButtonHigh.Visible = false;
			radioButtonLow.Visible = false;
			label8.Visible = false;
			buttonHit.Enabled = true;
			buttonStand.Enabled = true;

			// Updating player values
			labelHand.Text = Hand.ToString();

			//if (Hand == 21)
			//{ // If player gets black jack
			//    MessageBox.Show("BLACK JACK! YOU WIN!", "Win");
			//    buttonHit.Enabled = false;
			//    buttonStand.Enabled = false;
			//    Wins++;
			//    labelWins.Text = Wins.ToString();
			//}
			//else if (Hand > 21)
			//{ // If player busts
			//    MessageBox.Show("Bust! You lose!", "Lose");
			//    buttonHit.Enabled = false;
			//    buttonStand.Enabled = false;
			//    Losses++;
			//    labelLosses.Text = Losses.ToString();
			//} 
        }

        void AceShow()
        { // Shortcut to show Ace stuff
            buttonOkay.Visible = true;
            radioButtonHigh.Visible = true;
            radioButtonHigh.Visible = true;
            buttonHit.Enabled = false;
            buttonStand.Enabled = false;
        }

        void GetCard()
        { // Picking a card
            int Drawn = 0;
            Card = Cards[Rand.Next(0, 12)];

            switch (Card)
            {
                case 1:
                    if (Two < 4)
                    {
                        Two++;
                        Hand += Card;
                        Held++;
                        Drawn++;
                        picPlay1.Visible = false; 
						picPlay1.ImageLocation = @"images\clubs-2-150.png";
						picPlay1.Visible = true;
                    }
                    break;

                case 2:
                    if (Three < 4)
                    {
                        Three++;
                        Hand += Card;
                        Held++;
                        Drawn++;

                        if (picPlay1.Visible == true)
                        {
                            picPlay2.ImageLocation = @"images\diamonds-3-150.png";
                            picPlay2.Visible = true;
                        }
                        else
                        {
                            picPlay1.ImageLocation = @"images\spades-3-150.png";
                            picPlay1.Visible = true;
                        }
                    }
                    break;

                case 3:
                    if (Four < 4)
                    {
                        Four++;
                        Hand += Card;
                        Held++;
                        Drawn++;

                        if (picPlay1.Visible == true)
                        {
                            picPlay2.ImageLocation = @"images\clubs-4-150.png";
                            picPlay2.Visible = true;
                        }
                        else
                        {
                            picPlay1.ImageLocation = @"images\hearts-4-150.png";
                            picPlay1.Visible = true;
                        }
                    }
                    break;

                case 4:
                    if (Five < 4)
                    {
                        Five++;
                        Hand += Card;
                        Held++;
                        Drawn++;

                        if (picPlay1.Visible == true)
                        {
                            picPlay2.ImageLocation = @"images\clubs-5-150.png";
                            picPlay2.Visible = true;
                        }
                        else
                        {
                            picPlay1.ImageLocation = @"images\hearts-5-150.png";
                            picPlay1.Visible = true;
                        }
                    }
                    break;

                case 5:
                    if (Six < 4)
                    {
                        Six++;
                        Hand += Card;
                        Held++;
                        Drawn++;

                        if (picPlay1.Visible == true)
                        {
                            picPlay2.ImageLocation = @"images\spades-6-150.png";
                            picPlay2.Visible = true;
                        }
                        else
                        {
                            picPlay1.ImageLocation = @"images\clubs-6-150.png";
                            picPlay1.Visible = true;
                        }
                    }
                    break;

                case 6:
                    if (Seven < 4)
                    {
                        Seven++;
                        Hand += Card;
                        Held++;
                        Drawn++;

                        if (picPlay1.Visible == true)
                        {
                            picPlay2.ImageLocation = @"images\hearts-7-150.png";
                            picPlay2.Visible = true;
                        }
                        else
                        {
                            picPlay1.ImageLocation = @"images\diamonds-7-150.png";
                            picPlay1.Visible = true;
                        }
                    }
                    break;

                case 7:
                    if (Eight < 4)
                    {
                        Eight++;
                        Hand += Card;
                        Held++;
                        Drawn++;

                        if (picPlay1.Visible == true)
                        {
                            picPlay2.ImageLocation = @"images\clubs-8-150.png";
                            picPlay2.Visible = true;
                        }
                        else
                        {
                            picPlay1.ImageLocation = @"images\spades-8-150.png";
                            picPlay1.Visible = true;
                        }
                    }
                    break;

                case 8:
                    if (Nine < 4)
                    {
                        Nine++;
                        Hand += Card;
                        Held++;
                        Drawn++;

                        if (picPlay1.Visible == true)
                        {
                            picPlay2.ImageLocation = @"images\clubs-9-150.png";
                            picPlay2.Visible = true;
                        }
                        else
                        {
                            picPlay1.ImageLocation = @"images\hearts-9-150.png";
                            picPlay1.Visible = true;
                        }
                    }
                    break;

                case 9:
                    if (Ten < 16)
                    {
                        Ten++;
                        Hand += Card;
                        Held++;
                        Drawn++;

                        if (picPlay1.Visible == true)
                        {
                            picPlay2.ImageLocation = @"images\clubs-10-150.png";
                            picPlay2.Visible = true;
                        }
                        else
                        {
                            picPlay1.ImageLocation = @"images\hearts-10-150.png";
                            picPlay1.Visible = true;
                        }
                    }
                    break;
            }

            if (Drawn != 1)
            {
                GetCard();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Exit
            Environment.Exit(0); // Close program  
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {
            // Stand
			while (DealerHand < 16)
			{ // Mild AI for dealer to keep drawing cards on a low hand
				Card = Cards[Rand.Next(0, 12)];
				DealerHand += Card;
			}
			if (Hand > DealerHand)
			{ // If player has more than dealer
				MessageBox.Show("You win! Dealer had: " + DealerHand.ToString() + ", and you had: " + Hand.ToString(), "Win");
				buttonHit.Enabled = false;
				buttonStand.Enabled = false;
				Wins++;
				labelWins.Text = Wins.ToString();
				picPlay1.Visible = false;
				picPlay2.Visible = false;
				picPlay3.Visible = false;
			}
			else if (DealerHand > Hand && DealerHand <= 21)
			{ // If dealer has more than player and dealer didn't bust
				MessageBox.Show("You lose! Dealer had " + DealerHand.ToString() + ", and you had: " + Hand.ToString(), "Lose");
				buttonHit.Enabled = false;
				buttonStand.Enabled = false;
				Losses++;
				labelLosses.Text = Losses.ToString();
				picPlay1.Visible = false;
				picPlay2.Visible = false;
				picPlay3.Visible = false;
			}
			else if (DealerHand > 21)
			{ // If dealer busts
				MessageBox.Show("Dealer bust with " + DealerHand.ToString() + "! You Win!", "Won");
				buttonHit.Enabled = false;
				buttonStand.Enabled = false;
				Wins++;
				labelWins.Text = Wins.ToString();
				picPlay1.Visible = false;
				picPlay2.Visible = false;
				picPlay3.Visible = false;
			}
			if (Hand == 21)
			{ // If player gets black jack
				MessageBox.Show("BLACK JACK! YOU WIN!", "Win");
				buttonHit.Enabled = false;
				buttonStand.Enabled = false;
				Wins++;
				labelWins.Text = Wins.ToString();
				picPlay1.Visible = false;
				picPlay2.Visible = false;
				picPlay3.Visible = false;
			}
			else if (Hand > 21)
			{ // If player busts
				MessageBox.Show("Bust! You lose!", "Lose");
				buttonHit.Enabled = false;
				buttonStand.Enabled = false;
				Losses++;
				labelLosses.Text = Losses.ToString();
				picPlay1.Visible = false;
				picPlay2.Visible = false;
				picPlay3.Visible = false;
			}
			else
			{ // If equal hands (tie)
				MessageBox.Show("It's a tie! Both you and the Dealer had " + Hand.ToString(), "Tie");
				buttonHit.Enabled = false;
				buttonStand.Enabled = false;
				Ties++;
				labelTies.Text = Ties.ToString();
				picPlay1.Visible = false;
				picPlay2.Visible = false;
				picPlay3.Visible = false;
			}
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
            // Hit
			if (Rand.Next(1, 14) == 1)
			{ // Ace
				AceShow();
				Held++;
			}
			else
			{ // Random normal card
				GetCard();
			}

			// Updating player values
			labelHeld.Text = Held.ToString();
			labelHand.Text = Hand.ToString();

			if (Hand == 21)
			{ // If player gets black jack
				MessageBox.Show("BLACK JACK! YOU WIN!", "Win");
				buttonHit.Enabled = false;
				buttonStand.Enabled = false;
				Wins++;
				labelWins.Text = Wins.ToString();
				picPlay1.Visible = false;
				picPlay2.Visible = false;
				picPlay3.Visible = false;
			}
			else if (Hand > 21)
			{ // If players busts
				MessageBox.Show("Bust! You lose!", "Lose");
				buttonHit.Enabled = false;
				buttonStand.Enabled = false;
				Losses++;
				labelLosses.Text = Losses.ToString();
				picPlay1.Visible = false;
				picPlay2.Visible = false;
				picPlay3.Visible = false;
			}
			else
			{ // If the player did not win or lose (Hand under 21)
				if (DealerHand < 16)
				{ // Mild AI for the dealer not to bust so easily
					Card = Cards[Rand.Next(0, 12)];
					DealerHand += Card;
				}
				else
				{ // Dealer standing rather than drawing a card
					labelStanding.Visible = true;
				}

				if (DealerHand == 21)
				{ // If dealer gets black jack
					MessageBox.Show("Dealer got Black Jack. You lose!", "Lose");
					buttonHit.Enabled = false;
					buttonStand.Enabled = false;
					Losses++;
					labelLosses.Text = Losses.ToString();
					picPlay1.Visible = false;
					picPlay2.Visible = false;
					picPlay3.Visible = false;
				}
				else if (DealerHand > 21)
				{ // If dealer busts
					MessageBox.Show("Dealer bust with " + DealerHand.ToString() + "! You Win!", "Win");
					buttonHit.Enabled = false;
					buttonStand.Enabled = false;
					Wins++;
					labelWins.Text = Wins.ToString();
					picPlay1.Visible = false;
					picPlay2.Visible = false;
					picPlay3.Visible = false;
				}
			} 
        }
    }
}

