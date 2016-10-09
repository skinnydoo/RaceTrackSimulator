using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator {
	public class Greyhound {

		public int StartingPosition;	// Where my PictureBox starts
		public int RacetrackLength;		// How long the race track is
		public PictureBox MyPictureBox = null;	// My PictureBox object (the dog)
		public int Location = 0;	// My location on the track
		public Random Randomizer;	// An instance of Random

		/// <summary>
		/// Makes a dog move ( or run ) 1, 2, 3 or 4 spaces at random
		/// </summary>
		/// <returns> true if I won, false otherwise </returns>
		public bool Run () {

			// Move foward either 1, 2, 3, or 4 spaces at random
			Location += Randomizer.Next ( 1, 4 );
			
			// Update the position of the dog on the form
			MyPictureBox.Left = StartingPosition + Location;

			// return true if I won the race
			if ( Location >= RacetrackLength )
				return true;
			else
				return false;
		}


		/// <summary>
		/// Makes a dog take its starting position
		/// </summary>
		public void TakeStartingPosition () {

			// Reset my location to 0 and my PictureBox to starting position
			Location = 0;
			MyPictureBox.Left = StartingPosition;
		}
	}
}
