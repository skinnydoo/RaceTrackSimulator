using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator {
	public class Bet {

		public int Amount;	// the amount of cash that was bet
		public int Dog;		// the number of the dog the bet is on
		public Guy Bettor;	// the guy who place the bet

		/// <summary>
		///  Return a string that says who placed the bet, how much cash
		///  was bet, and which dog he bet on ( joe bets 8 on dog #4). 
		///  If the amount is zero, no bet was placed ( joe hasn't placed a bet)
		/// </summary>
		/// <returns></returns>
		public string GetDescription () {

			if ( Amount == 0 ) {

				return Bettor.Name + " hasn't placed a bet";
			}
			else {

				return Bettor.Name + " bets " + Amount + " on dog #" + Dog;
			}
		}

		/// <summary>
		/// The parameter is the winner of the race. If the dog won,
		/// return the amount bet. Otherwise, return the negative of the amount bet
		/// </summary>
		/// <param name="winner"></param>
		/// <returns> amount bet, otherwise, the negative of the amoun bet  </returns>
		public int PayOut ( int winner ) {

			if ( Dog == winner )
				
				return Amount;
			else
				
				return -Amount;
		}
	}
}
