namespace Racetrack_Simulator {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
			this.bettingParlorGroupBox = new System.Windows.Forms.GroupBox();
			this.raceButton = new System.Windows.Forms.Button();
			this.alBetLabel = new System.Windows.Forms.Label();
			this.bobBetLabel = new System.Windows.Forms.Label();
			this.joeBetLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dogNnumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.betButton = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.alRadioButton = new System.Windows.Forms.RadioButton();
			this.bobRadioButton = new System.Windows.Forms.RadioButton();
			this.joeRadioButton = new System.Windows.Forms.RadioButton();
			this.minimumBetLabel = new System.Windows.Forms.Label();
			this.greyhound1 = new System.Windows.Forms.PictureBox();
			this.greyhound2 = new System.Windows.Forms.PictureBox();
			this.greyhound3 = new System.Windows.Forms.PictureBox();
			this.greyhound4 = new System.Windows.Forms.PictureBox();
			this.raceTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
			this.bettingParlorGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dogNnumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.greyhound1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.greyhound2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.greyhound3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.greyhound4)).BeginInit();
			this.SuspendLayout();
			// 
			// raceTrackPictureBox
			// 
			this.raceTrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raceTrackPictureBox.Image")));
			this.raceTrackPictureBox.Location = new System.Drawing.Point(12, 12);
			this.raceTrackPictureBox.Name = "raceTrackPictureBox";
			this.raceTrackPictureBox.Size = new System.Drawing.Size(2256, 726);
			this.raceTrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.raceTrackPictureBox.TabIndex = 0;
			this.raceTrackPictureBox.TabStop = false;
			// 
			// bettingParlorGroupBox
			// 
			this.bettingParlorGroupBox.Controls.Add(this.raceButton);
			this.bettingParlorGroupBox.Controls.Add(this.alBetLabel);
			this.bettingParlorGroupBox.Controls.Add(this.bobBetLabel);
			this.bettingParlorGroupBox.Controls.Add(this.joeBetLabel);
			this.bettingParlorGroupBox.Controls.Add(this.label4);
			this.bettingParlorGroupBox.Controls.Add(this.dogNnumericUpDown);
			this.bettingParlorGroupBox.Controls.Add(this.label3);
			this.bettingParlorGroupBox.Controls.Add(this.betNumericUpDown);
			this.bettingParlorGroupBox.Controls.Add(this.betButton);
			this.bettingParlorGroupBox.Controls.Add(this.nameLabel);
			this.bettingParlorGroupBox.Controls.Add(this.alRadioButton);
			this.bettingParlorGroupBox.Controls.Add(this.bobRadioButton);
			this.bettingParlorGroupBox.Controls.Add(this.joeRadioButton);
			this.bettingParlorGroupBox.Controls.Add(this.minimumBetLabel);
			this.bettingParlorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bettingParlorGroupBox.Location = new System.Drawing.Point(293, 761);
			this.bettingParlorGroupBox.Name = "bettingParlorGroupBox";
			this.bettingParlorGroupBox.Size = new System.Drawing.Size(1607, 366);
			this.bettingParlorGroupBox.TabIndex = 2;
			this.bettingParlorGroupBox.TabStop = false;
			this.bettingParlorGroupBox.Text = "Betting Parlor";
			// 
			// raceButton
			// 
			this.raceButton.Location = new System.Drawing.Point(1094, 85);
			this.raceButton.Name = "raceButton";
			this.raceButton.Size = new System.Drawing.Size(435, 228);
			this.raceButton.TabIndex = 13;
			this.raceButton.Text = "Race!";
			this.raceButton.UseVisualStyleBackColor = true;
			this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
			// 
			// alBetLabel
			// 
			this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.alBetLabel.Location = new System.Drawing.Point(555, 211);
			this.alBetLabel.Name = "alBetLabel";
			this.alBetLabel.Size = new System.Drawing.Size(439, 33);
			this.alBetLabel.TabIndex = 12;
			this.alBetLabel.Text = "alBetLabel";
			// 
			// bobBetLabel
			// 
			this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bobBetLabel.Location = new System.Drawing.Point(555, 150);
			this.bobBetLabel.Name = "bobBetLabel";
			this.bobBetLabel.Size = new System.Drawing.Size(439, 33);
			this.bobBetLabel.TabIndex = 11;
			this.bobBetLabel.Text = "bobBetLabel";
			// 
			// joeBetLabel
			// 
			this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.joeBetLabel.Location = new System.Drawing.Point(555, 87);
			this.joeBetLabel.Name = "joeBetLabel";
			this.joeBetLabel.Size = new System.Drawing.Size(439, 33);
			this.joeBetLabel.TabIndex = 10;
			this.joeBetLabel.Text = "joeBetLabel";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(555, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 31);
			this.label4.TabIndex = 9;
			this.label4.Text = "Bets";
			// 
			// dogNnumericUpDown
			// 
			this.dogNnumericUpDown.Location = new System.Drawing.Point(632, 282);
			this.dogNnumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.dogNnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.dogNnumericUpDown.Name = "dogNnumericUpDown";
			this.dogNnumericUpDown.Size = new System.Drawing.Size(120, 38);
			this.dogNnumericUpDown.TabIndex = 8;
			this.dogNnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(353, 287);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(273, 31);
			this.label3.TabIndex = 7;
			this.label3.Text = "bucks on dog number";
			// 
			// betNumericUpDown
			// 
			this.betNumericUpDown.Location = new System.Drawing.Point(222, 280);
			this.betNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.betNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.betNumericUpDown.Name = "betNumericUpDown";
			this.betNumericUpDown.Size = new System.Drawing.Size(105, 38);
			this.betNumericUpDown.TabIndex = 6;
			this.betNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// betButton
			// 
			this.betButton.Location = new System.Drawing.Point(107, 276);
			this.betButton.Name = "betButton";
			this.betButton.Size = new System.Drawing.Size(84, 43);
			this.betButton.TabIndex = 5;
			this.betButton.Text = "Bets";
			this.betButton.UseVisualStyleBackColor = true;
			this.betButton.Click += new System.EventHandler(this.betButton_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(6, 282);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(81, 31);
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "name";
			// 
			// alRadioButton
			// 
			this.alRadioButton.AutoSize = true;
			this.alRadioButton.Location = new System.Drawing.Point(12, 209);
			this.alRadioButton.Name = "alRadioButton";
			this.alRadioButton.Size = new System.Drawing.Size(216, 35);
			this.alRadioButton.TabIndex = 3;
			this.alRadioButton.Text = "alRadioButton";
			this.alRadioButton.UseVisualStyleBackColor = true;
			this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
			// 
			// bobRadioButton
			// 
			this.bobRadioButton.AutoSize = true;
			this.bobRadioButton.Location = new System.Drawing.Point(12, 148);
			this.bobRadioButton.Name = "bobRadioButton";
			this.bobRadioButton.Size = new System.Drawing.Size(240, 35);
			this.bobRadioButton.TabIndex = 2;
			this.bobRadioButton.Text = "bobRadioButton";
			this.bobRadioButton.UseVisualStyleBackColor = true;
			this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
			// 
			// joeRadioButton
			// 
			this.joeRadioButton.AutoSize = true;
			this.joeRadioButton.Location = new System.Drawing.Point(12, 85);
			this.joeRadioButton.Name = "joeRadioButton";
			this.joeRadioButton.Size = new System.Drawing.Size(231, 35);
			this.joeRadioButton.TabIndex = 1;
			this.joeRadioButton.Text = "joeRadioButton";
			this.joeRadioButton.UseVisualStyleBackColor = true;
			this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
			// 
			// minimumBetLabel
			// 
			this.minimumBetLabel.AutoSize = true;
			this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minimumBetLabel.Location = new System.Drawing.Point(6, 34);
			this.minimumBetLabel.Name = "minimumBetLabel";
			this.minimumBetLabel.Size = new System.Drawing.Size(304, 31);
			this.minimumBetLabel.TabIndex = 0;
			this.minimumBetLabel.Text = "Minimum bet : 5 bucks";
			// 
			// greyhound1
			// 
			this.greyhound1.Image = ((System.Drawing.Image)(resources.GetObject("greyhound1.Image")));
			this.greyhound1.Location = new System.Drawing.Point(61, 37);
			this.greyhound1.Name = "greyhound1";
			this.greyhound1.Size = new System.Drawing.Size(179, 93);
			this.greyhound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.greyhound1.TabIndex = 3;
			this.greyhound1.TabStop = false;
			// 
			// greyhound2
			// 
			this.greyhound2.Image = ((System.Drawing.Image)(resources.GetObject("greyhound2.Image")));
			this.greyhound2.Location = new System.Drawing.Point(61, 232);
			this.greyhound2.Name = "greyhound2";
			this.greyhound2.Size = new System.Drawing.Size(179, 93);
			this.greyhound2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.greyhound2.TabIndex = 4;
			this.greyhound2.TabStop = false;
			// 
			// greyhound3
			// 
			this.greyhound3.Image = ((System.Drawing.Image)(resources.GetObject("greyhound3.Image")));
			this.greyhound3.Location = new System.Drawing.Point(61, 433);
			this.greyhound3.Name = "greyhound3";
			this.greyhound3.Size = new System.Drawing.Size(179, 93);
			this.greyhound3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.greyhound3.TabIndex = 5;
			this.greyhound3.TabStop = false;
			// 
			// greyhound4
			// 
			this.greyhound4.Image = ((System.Drawing.Image)(resources.GetObject("greyhound4.Image")));
			this.greyhound4.Location = new System.Drawing.Point(61, 597);
			this.greyhound4.Name = "greyhound4";
			this.greyhound4.Size = new System.Drawing.Size(179, 93);
			this.greyhound4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.greyhound4.TabIndex = 6;
			this.greyhound4.TabStop = false;
			// 
			// raceTimer
			// 
			this.raceTimer.Interval = 5;
			this.raceTimer.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(2295, 1164);
			this.Controls.Add(this.greyhound1);
			this.Controls.Add(this.greyhound4);
			this.Controls.Add(this.greyhound3);
			this.Controls.Add(this.greyhound2);
			this.Controls.Add(this.bettingParlorGroupBox);
			this.Controls.Add(this.raceTrackPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "A Dat at the Races";
			((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
			this.bettingParlorGroupBox.ResumeLayout(false);
			this.bettingParlorGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dogNnumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.greyhound1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.greyhound2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.greyhound3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.greyhound4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox raceTrackPictureBox;
		private System.Windows.Forms.GroupBox bettingParlorGroupBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown dogNnumericUpDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown betNumericUpDown;
		private System.Windows.Forms.Button betButton;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.RadioButton alRadioButton;
		private System.Windows.Forms.RadioButton bobRadioButton;
		private System.Windows.Forms.RadioButton joeRadioButton;
		private System.Windows.Forms.Label minimumBetLabel;
		private System.Windows.Forms.Label alBetLabel;
		private System.Windows.Forms.Label bobBetLabel;
		private System.Windows.Forms.Label joeBetLabel;
		private System.Windows.Forms.Button raceButton;
		private System.Windows.Forms.PictureBox greyhound1;
		private System.Windows.Forms.PictureBox greyhound2;
		private System.Windows.Forms.PictureBox greyhound3;
		private System.Windows.Forms.PictureBox greyhound4;
		private System.Windows.Forms.Timer raceTimer;
	}
}

