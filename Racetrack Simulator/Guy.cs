using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator {
	public class Guy {

		public string Name;	// The Guy's name
		public Bet MyBet;	// instance of Bet that has his bet
		public int Cash;	// How much cash he has

		public RadioButton MyRadioButton;	// My Radiobutton
		public Label MyLabel;	// My Label


		/// <summary>
		/// Set my label to my bet's description, and the label on my 
		/// radio button to show my cash ("Joe has 43 bucks")
		/// </summary>
		public void UpdateLabels () {

			MyLabel.Text = MyBet.GetDescription ();
			MyRadioButton.Text = Name + " has " + Cash + " bucks";			

		}

		/// <summary>
		/// Reset my bet so it's zero
		/// </summary>
		public void ClearBet () { PlaceBet ( 0, 1 ); } 
		
		/// <summary>
		/// Place a new bet and store it in my bet field
		/// </summary>
		/// <param name="betAmount"></param>
		/// <param name="dogToWin"></param>
		/// <returns> true if the guy had enough money to bet </returns>
		public bool PlaceBet ( int betAmount, int dogToWin ) {

			if ( Cash >= betAmount ) {

				MyBet = new Bet () { Amount = betAmount, Dog = dogToWin, Bettor = this };

				UpdateLabels ();

				return true;
			}
			else {

				MessageBox.Show ( Name + " you don't have enough money!", "You Can't Bet!" );
				return false;
			}

		}


		/// <summary>
		/// Ask my bet to pay out, clear my bet, and update my labels
		/// </summary>
		/// <param name="winner"></param>
		public void Collect ( int winner ) {

			Cash += MyBet.PayOut (winner);
			ClearBet ();
			UpdateLabels ();
		}

	}
}
