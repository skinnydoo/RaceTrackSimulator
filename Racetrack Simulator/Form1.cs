using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator {
	public partial class Form1 : Form {

		Greyhound[] GreyhoundArray = new Greyhound[4];	// Array of four dogs that will run the race
		Guy[] GuyArray = new Guy[3];	// Array of three Guy objects to keep track of the three guys
		Random MyRandomizer = new Random ();	// An instance of Random

		bool betPlaced = false;	// to verify if at least one guy has placed a bet

		public Form1 () {
			InitializeComponent ();

			minimumBetLabel.Text = "Minimum bet: " + betNumericUpDown.Minimum + " bucks";
			nameLabel.Text = "";

			// Dog 1 initialization
			GreyhoundArray[0] = new Greyhound () {
				StartingPosition = greyhound1.Left,
				MyPictureBox = greyhound1,
				RacetrackLength = raceTrackPictureBox.Width - greyhound1.Width,
				Randomizer = MyRandomizer
			};

			// Dog 2 initialization
			GreyhoundArray[1] = new Greyhound () {
				StartingPosition = greyhound2.Left,
				MyPictureBox = greyhound2,
				RacetrackLength = raceTrackPictureBox.Width - greyhound2.Width,
				Randomizer = MyRandomizer
			};

			// Dog 3 initialization
			GreyhoundArray[2] = new Greyhound () {
				StartingPosition = greyhound3.Left,
				MyPictureBox = greyhound3,
				RacetrackLength = raceTrackPictureBox.Width - greyhound3.Width,
				Randomizer = MyRandomizer
			};

			// Dog 4 initialization
			GreyhoundArray[3] = new Greyhound () {
				StartingPosition = greyhound4.Left,
				MyPictureBox = greyhound4,
				RacetrackLength = raceTrackPictureBox.Width - greyhound4.Width,
				Randomizer = MyRandomizer
			};

			// Guy 1 (Joe) initialization
			GuyArray[0] = new Guy () { Name = "Joe", Cash = 50, MyBet = null, MyLabel = joeBetLabel, MyRadioButton = joeRadioButton };

			// Guy 2 (Bob) initialization
			GuyArray[1] = new Guy () { Name = "Bob", Cash = 75, MyBet = null, MyLabel = bobBetLabel, MyRadioButton = bobRadioButton };

			// Guy 3 (Al) initialization
			GuyArray[2] = new Guy () { Name = "Al", Cash = 45, MyBet = null, MyLabel = alBetLabel, MyRadioButton = alRadioButton };

			// clear each guy's bet to zero and update their label
			for ( int i = 0; i < GuyArray.Length; ++i ) {

				GuyArray[i].ClearBet ();
				GuyArray[i].UpdateLabels ();
			}
		}


		/// <summary>
		/// This method will run everytime the Bets button is clicked.
		/// It allows each guy to place his bet
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void betButton_Click ( object sender, EventArgs e ) {

			if ( joeRadioButton.Checked ) {

				betPlaced = GuyArray[0].PlaceBet ( ( int )betNumericUpDown.Value, ( int )dogNnumericUpDown.Value );
			}
			else if ( bobRadioButton.Checked ) {

				betPlaced = GuyArray[1].PlaceBet ( ( int )betNumericUpDown.Value, ( int )dogNnumericUpDown.Value );
			}
			else if ( alRadioButton.Checked ) {

				betPlaced = GuyArray[2].PlaceBet ( ( int )betNumericUpDown.Value, ( int )dogNnumericUpDown.Value );
			}
		}

		/// <summary>
		/// When the race button is clicked, each dog will take
		/// their starting position and the race will start
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void raceButton_Click ( object sender, EventArgs e ) {

			if ( betPlaced ) {

				for ( int i = 0; i < GreyhoundArray.Length; ++i ) {

					GreyhoundArray[i].TakeStartingPosition ();
				}

				raceTimer.Start ();	// starts the race's timer
				bettingParlorGroupBox.Enabled = false;	// During the race, no bets can be placed
			}
			else {

				MessageBox.Show ( "No Bets have been placed!", "Pay up if you wanna race!" );
			}
		}

		/// <summary>
		/// When the user click the race button, the form starts
		/// the timer, which starts the dogs by calling their Run() method
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick ( object sender, EventArgs e ) {

			for ( int i = 0; i < GreyhoundArray.Length; ++i ) {

				// Do we have a winner?
				if ( GreyhoundArray[i].Run () ) {

					raceTimer.Stop ();	// if we have a winner, stop the timer
					bettingParlorGroupBox.Enabled = true;
					int winner = i + 1;
					MessageBox.Show ( "Dog #" + winner + " won the race!", "We have a winner" );

					// each guy collects his winnings
					for ( int j = 0; j < GuyArray.Length; ++j ) {

						GuyArray[j].Collect ( winner );
					}

					betPlaced = false;
				}
			}

		}


		/// <summary>
		/// Displays the name of the guy that is betting next to the Bets button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void joeRadioButton_CheckedChanged ( object sender, EventArgs e ) {

			if ( joeRadioButton.Checked ) {

				nameLabel.Text = GuyArray[0].Name;
			}

		}


		/// <summary>
		/// Displays the name of the guy that is betting next to the Bets button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bobRadioButton_CheckedChanged ( object sender, EventArgs e ) {

			if ( bobRadioButton.Checked ) {

				nameLabel.Text = GuyArray[1].Name;
			}

		}


		/// <summary>
		/// Displays the name of the guy that is betting next to the Bets button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void alRadioButton_CheckedChanged ( object sender, EventArgs e ) {

			if ( alRadioButton.Checked ) {

				nameLabel.Text = GuyArray[2].Name;
			}

		}


	}
}
